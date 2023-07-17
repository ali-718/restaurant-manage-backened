using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using Microsoft.IdentityModel.Tokens;
using Restaurant_Manage_Backened.Helpers.Response;
using Restaurant_Manage_Backened.Models;

namespace fyp_manage_backened.Data
{
    public class AuthRepository : IAuthRepository
    {
        private readonly DataContext _context;
        private readonly IConfiguration _config;

        public AuthRepository(DataContext context, IConfiguration config)
        {
            _context = context;
            _config = config;
        }

        public async Task<ServiceResponse<string>> Login(string username, string password)
        {
            var response = new ServiceResponse<string>();
            var user = await _context.Users.FirstOrDefaultAsync(u => u.Username.ToLower().Equals(username.ToLower()));
            if (user is null)
            {
                response.isSuccess = false;
                response.Message = "User not found";

                return response;
            }
            if (!verifyPasswordHash(password, user.PasswordHash, user.PasswordSalt))
            {
                response.isSuccess = false;
                response.Message = "Wrong Password";
                return response;
            }
            response.data = createToken(user);
            return response;
        }

        public async Task<ServiceResponse<int>> Register(User user, string password)
        {
            var response = new ServiceResponse<int>();
            bool isUserExists = await userExists(user.Username);
            if (isUserExists)
            {
                response.isSuccess = false;
                response.Message = $"User with username '{user.Username}' already exists";
                return response;
            }
            createPasswordHash(password, out byte[] passwordHash, out byte[] passwordSalt);
            user.PasswordHash = passwordHash;
            user.PasswordSalt = passwordSalt;
            _context.Users.Add(user);
            await _context.SaveChangesAsync();
            response.data = user.Id;
            return response;
        }

        public async Task<bool> userExists(string username)
        {
            var user = await _context.Users.AnyAsync(u => u.Username.ToLower() == username.ToLower());
            if (user)
            {
                return true;
            }
            return false;
        }

        private void createPasswordHash(string password, out byte[] passwordHash, out byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512())
            {
                passwordHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                passwordSalt = hmac.Key;
            }
        }


        private bool verifyPasswordHash(string password, byte[] passwordHash, byte[] passwordSalt)
        {
            using (var hmac = new System.Security.Cryptography.HMACSHA512(passwordSalt))
            {
                var computedHash = hmac.ComputeHash(System.Text.Encoding.UTF8.GetBytes(password));
                return computedHash.SequenceEqual(passwordHash);
            }
        }

        private string createToken(User user)
        {
            var claims = new List<Claim>{
                new Claim("NameIdentifier", user.Id.ToString()),
                new Claim("Name", user.Username),
                new Claim("Role", user!.Role!.ToString())
        };
            var appSettingsToken = _config.GetSection("AppSettings:Token").Value;
            if (appSettingsToken is null)
                throw new Exception("AppSetting token is null here");

            SymmetricSecurityKey key = new SymmetricSecurityKey(System.Text.Encoding.UTF8
            .GetBytes(appSettingsToken));
            SigningCredentials credentials = new SigningCredentials(key, SecurityAlgorithms.HmacSha512Signature);

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = credentials
            };

            JwtSecurityTokenHandler tokenHandler = new JwtSecurityTokenHandler();
            SecurityToken token = tokenHandler.CreateToken(tokenDescriptor);

            return tokenHandler.WriteToken(token);
        }
    }
}
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using Microsoft.Extensions.Options;
using Microsoft.IdentityModel.Tokens;
using ParksAPI.Models;
using ParksAPI.Helpers;
using Microsoft.AspNetCore.Authorization;


namespace ParksAPI.Services
{
    public interface IUserService
    {
        User Authenticate(string username, string password);
        IEnumerable<User> GetAll();
        void Create(User user);
    }

    public class UserService : IUserService
    {
         private ParksContext _db;
        private List<User> _users;
       
        private readonly AppSettings _appSettings;

        public UserService(ParksContext db, IOptions<AppSettings> appSettings)
        {
            _db = db;
            _users = _db.Users.ToList();
            _appSettings = appSettings.Value;
        }

        public User Authenticate(string username, string password)
        {
            var user = _users.SingleOrDefault(x => x.Username == username && x.Password == password);

        
            if (user == null)
                return null;
                   
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.ASCII.GetBytes(_appSettings.Secret);
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(new Claim[] 
                {
                    new Claim(ClaimTypes.Name, user.UserId.ToString())
                }),
                Expires = DateTime.UtcNow.AddDays(7),
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature)
            };
            var token = tokenHandler.CreateToken(tokenDescriptor);
            user.Token = tokenHandler.WriteToken(token);

            user.Password = null;

            return user;
        }

        public IEnumerable<User> GetAll()
        {
       
            return _users.Select(x => {
                x.Password = null;
                return x;
            });
        }

        public void Create(User newUser)
        {
            _db.Users.Add(newUser);
            _db.SaveChanges();
        }
    }
}
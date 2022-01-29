using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using Proiect.DAL.Constants;
using Proiect.DAL.Entities;
using Proiect.DAL.Entities.DTOs;
using Proiect.DAL.Repositories.SessionTokenRepository;
using Proiect.DAL.Repositories.UserRepository;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Proiect.DAL.Services
{
    public class UserService : IUserService
    {
        private readonly UserManager<User> _userManager;
        private readonly IUserRepository _repository;
        private readonly ISessionTokenRepository _token_repo;

        public UserService(UserManager<User> userManager, IUserRepository repository,ISessionTokenRepository sessionTokenRepository)
        {
            _userManager = userManager;
            _repository = repository;
            _token_repo = sessionTokenRepository;

        }

        public async Task<string> LoginUser(LoginUserDTO dto)
        {
            User user = await _userManager.FindByEmailAsync(dto.Email);
            
            if(user != null)
            {
                user = await _repository.GetByIdWithRoles(user.Id);

                List<string> roles = user.UserRoles.Select(ur => ur.Role.Name).ToList();

                var newJti = Guid.NewGuid().ToString();
                var TokenHandler = new JwtSecurityTokenHandler();
                var signinkey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("this is my custom secret key for auth"));

                var token = GenerateJwtToken(signinkey, user, roles, TokenHandler, newJti);

                _token_repo.Create(new SessionToken(newJti, user.Id, token.ValidTo));
                await _token_repo.SaveAsync();

                return TokenHandler.WriteToken(token);
            }

            return null;
        }

        private SecurityToken GenerateJwtToken(SymmetricSecurityKey signinKey,User user,List<string> roles,JwtSecurityTokenHandler tokenHandler,string jti)
        {
            var subject = new ClaimsIdentity(new Claim[]{
                new Claim(ClaimTypes.Email,user.Email),
                new Claim(ClaimTypes.Name,user.FirstName+" "+user.LastName),
                new Claim(ClaimTypes.NameIdentifier,user.Id.ToString()),
                new Claim(JwtRegisteredClaimNames.Jti,jti)
            }); 

            foreach(var role in roles)
            {
                subject.AddClaim(new Claim(ClaimTypes.Role, role));
            }
            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = subject,
                Expires = DateTime.Now.AddDays(1),
                SigningCredentials = new SigningCredentials(signinKey, SecurityAlgorithms.HmacSha256)
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);

            return token;
        }

        public async Task<bool> RegisterUserAsync(RegisterUserDTO dto)
        {
            

                var registerUser = new User();
                registerUser.Email = dto.Email;
                registerUser.UserName = dto.Email;
                registerUser.FirstName = dto.FirstName;
                registerUser.LastName = dto.LastName;
                

                var result = await _userManager.CreateAsync(registerUser, dto.Password);

                if (result.Succeeded)
                {
                    await _userManager.AddToRoleAsync(registerUser, UserRoleType.User);

                    return true;
                }

            return false;

        }
    

     
    }
}

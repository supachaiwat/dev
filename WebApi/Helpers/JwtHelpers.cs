using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using WebApi.Models;

namespace WebApi.Helpers{
    public static class JwtHelpers
    {
        public static UserTokens GenTokenkey(UserTokens model, JwtSettings jwtSettings){
            try
            {
                var UserToken = new UserTokens();
                if(model == null) throw new ArgumentException(nameof(model));

                // Get secret key
                var key = System.Text.Encoding.ASCII.GetBytes(jwtSettings.IssuerSigningKey);
                Guid Id = Guid.Empty;
                DateTime expireTime = DateTime.UtcNow.AddDays(1);
                UserToken.validaty = expireTime.TimeOfDay;
                var JWToken = new JwtSecurityTokey(
                    
                );
                UserToken.Token = new JwtSecurityTokenHandler().WriteToken(JWToken);
                var idRefreshToken = Guid.NewGuid();
                UserToken.UserName = model.UserName;
                UserToken.Id = model.Id;
                UserToken.GuidId = Id;
                return UserToken;
            }catch(Exception){
                throw;
            }
        }
    }
}
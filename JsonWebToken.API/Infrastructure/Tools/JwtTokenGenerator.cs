using JsonWebToken.API.Core.Application.DTO;
using JsonWebToken.API.Core.Domain;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;

namespace JsonWebToken.API.Infrastructure.Tools
{
    public class JwtTokenGenerator
    {
        public static string GenerateToken(CheckUserResponseDto dto)
        {
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Role, dto.Role));
            claims.Add(new Claim(ClaimTypes.Name, dto.Username));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, dto.Id.ToString()));

            JwtSecurityToken token = new(issuer: JwtTokenSettings.Issuer, audience: JwtTokenSettings.Audience, claims: null, notBefore: DateTime.Now, expires: DateTime.Now.AddDays(JwtTokenSettings.Expire));

            JwtSecurityTokenHandler handler = new();

            return handler.WriteToken(token);
        }
    }
}

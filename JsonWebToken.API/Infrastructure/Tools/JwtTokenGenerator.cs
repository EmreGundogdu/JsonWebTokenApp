using JsonWebToken.API.Core.Application.DTO;
using JsonWebToken.API.Core.Domain;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace JsonWebToken.API.Infrastructure.Tools
{
    public class JwtTokenGenerator
    {
        public static JwtTokenResponse GenerateToken(CheckUserResponseDto dto)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(JwtTokenSettings.Key));
            SigningCredentials signingCredentials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);
            List<Claim> claims = new List<Claim>();

            claims.Add(new Claim(ClaimTypes.Role, dto.Role));
            claims.Add(new Claim(ClaimTypes.Name, dto.Username));
            claims.Add(new Claim(ClaimTypes.NameIdentifier, dto.Id.ToString()));

            var expireDate = DateTime.UtcNow.AddMinutes(1);

            JwtSecurityToken token = new(issuer: JwtTokenSettings.Issuer, audience: JwtTokenSettings.Audience, claims: claims, notBefore: DateTime.UtcNow, expires:expireDate, signingCredentials: signingCredentials);

            JwtSecurityTokenHandler handler = new();

            return new JwtTokenResponse(handler.WriteToken(token),expireDate);
        }
    }
}

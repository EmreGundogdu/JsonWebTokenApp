namespace JsonWebToken.API.Infrastructure.Tools
{
    public class JwtTokenSettings
    {
        /*
         * ValidAudience = "https://localhost",
        ValidIssuer = "http://localhost",
        ClockSkew = TimeSpan.Zero,
        ValidateLifetime = true,
        IssuerSigningKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("emreemreemre1.")),
        ValidateIssuerSigningKey = true
         */
        public const string Issuer = "https://localhost";
        public const string Audience = "http://localhost";
        public const string Key = "emreemreemre1.";
        public const int Expire = 30;
    }
}

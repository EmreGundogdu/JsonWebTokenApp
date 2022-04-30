namespace JsonWebToken.API.Infrastructure.Tools
{
    public class JwtTokenResponse
    {
        public string Token { get; set; }
        public DateTime ExpireData { get; set; }

        public JwtTokenResponse(string token, DateTime expireData)
        {
            Token = token;
            ExpireData = expireData;
        }
    }
}

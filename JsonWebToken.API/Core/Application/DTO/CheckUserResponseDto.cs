namespace JsonWebToken.API.Core.Application.DTO
{
    public class CheckUserResponseDto
    {
        public string Username { get; set; } = string.Empty;
        public string Role { get; set; } = string.Empty;
        public int Id { get; set; }

        public bool IsExist { get; set; }
    }
}

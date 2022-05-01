namespace JsonWebToken.API.Core.Application.DTO
{
    public class CheckUserResponseDto
    {
        public string? Username { get; set; } 
        public string? Role { get; set; } 
        public int Id { get; set; }

        public bool IsExist { get; set; }
    }
}

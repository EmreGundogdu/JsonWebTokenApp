namespace JsonWebToken.API.Core.Application.DTO
{
    public class ProductListDto
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stcok { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
    }
}

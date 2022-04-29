namespace JsonWebToken.API.Core.Domain
{
    public class Product
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int Stcok { get; set; }
        public decimal Price { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public Product()
        {
            Category = new Category();
        }
    }
}

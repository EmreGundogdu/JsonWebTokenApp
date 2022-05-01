using System.ComponentModel.DataAnnotations;

namespace JsonWebToken.Front.Models
{
    public class CategoryCreateRequestModel
    {
        [Required(ErrorMessage ="Definition required")]
        public string Definition { get; set; }
    }
}

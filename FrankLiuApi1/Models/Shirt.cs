using FrankLiuApi1.Models.Validations;
using System.ComponentModel.DataAnnotations;

namespace FrankLiuApi1.Models
{

    //Using data-annotation for model-validation
    public class Shirt
    {
        public int ShirtId { get; set; }
        [Required]
        public string? Brand { get; set; }
        [Required]
        public string? Color { get; set; }
        [Shirts_EnsureRightSizing]
        public int? Size { get; set; }
        [Required]
        public string? Gender { get; set; }
        
        public double? Price { get; set; }
        

    }
}

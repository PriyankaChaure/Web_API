using System.ComponentModel.DataAnnotations;

namespace CURDUsingAPIEx.Models
{
    public class Product
    {
        public Int64 ProductID { get; set; }
        [Required(ErrorMessage ="Please Input Product Name")]
        public string ProductName { get; set; }
        [Required(ErrorMessage ="Please Input MfgName")]
        [StringLength(10,MinimumLength =5,ErrorMessage ="Please Input 5 to 10 Characters!")]
        public string MfgName { get; set; }
        [Required(ErrorMessage ="Please Input Price")]
        [Range(1000,10000,ErrorMessage ="Price Should be in Range 1000-10000")]
        public decimal Price { get; set; }
    }
}

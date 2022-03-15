using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Demo23_WebApp.Models
{
    [Table("Products")]
    public class Product
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int ProductId { get; set; }


        [Display(Name ="Name of product")]
        [Required(ErrorMessage ="Product name is required")]
        [StringLength(50, ErrorMessage = "Product Name can not more then 50 characters.")]
        [MinLength(3, ErrorMessage ="Product Name can not less then 3 characters." )]
        public string ProductName { get; set; }

        [Required(ErrorMessage ="Can not be Empty")]
        [Range(minimum:1,maximum:100,ErrorMessage ="Product Qunitity need to be between 1 to 100")]
        public int Quntity { get; set; }

        [Required(ErrorMessage = "Can not be Empty")]
        [Range(minimum: 1, maximum: 10000, ErrorMessage = "Product price need to be between 1 to 10000")]
        public int Price { get; set; }
    }
}

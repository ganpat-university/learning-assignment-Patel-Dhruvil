using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace Demo23_WebApp.Models
{
    [Table("Departments")]
    public class Department
    {
        [Key]
        [Display(Name ="DepartmentId")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int DepartmentId { get; set; }

        [Display(Name ="DepartmentName")]
        [Required]
        [StringLength(50,ErrorMessage ="limit of characters is 50")]
        public string DepartmentName { get; set; }
    }
}

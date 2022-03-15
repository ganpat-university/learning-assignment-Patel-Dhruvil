using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
namespace Demo23_WebApp.Models

{
    [Table("Subjects")]
    public class Subject
    {
        [Key]
        [Display(Name ="Subject Id")]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public short SubjectId { get; set; }

        [Required]
        [Display(Name = "Subject Name")]
        public string SubjectName { get; set; }

        #region navigation properties to the Department Model

        [Display(Name ="Department Name")]
        [Required]
        [ForeignKey(nameof(Subject.Department))]
        public int DepartmentId { get; set; }

        public Department Department { get; set; }

        #endregion


    }
}

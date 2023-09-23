using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEF_App.Models
{
    public class Doctor
    {
        [Key]//if you use key you dont need to use required
        [Column("doctorno")]//to specify column name to be stored in db if not specified it takes as method name itself
        public int Id { get; set; }

        [Required]
        [StringLength(20)]//Nvarchar size is 20
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20 chars")]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string Speciality { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,2)")]
        public decimal VisitingFees { get; set; }
        [Required]
        [Column(TypeName = "numeric(11,0)")]
        public decimal PhoneNumber { get; set; }
    }
}

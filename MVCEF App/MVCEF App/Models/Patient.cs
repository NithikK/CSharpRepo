using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MVCEF_App.Models
{
    public class Patient
    {
        [Key]
        [Column("patientno")]
        public int Id { get; set; }
        
        [Required]
        [StringLength(20)]//Nvarchar size is 20
        [MinLength(3, ErrorMessage = "Name must be between 3 and 20 chars")]
        public string Name { get; set; } = string.Empty;
        [Required]
        public string City { get; set; } = string.Empty;
        [Required]
        public DateTime DateOfBirth { get; set; }
        //public int AppointmentID { get; set; }
        [Required]
        [Column(TypeName = "numeric(18,0)")]
        public decimal PhoneNumber { get; set; }
    }
}

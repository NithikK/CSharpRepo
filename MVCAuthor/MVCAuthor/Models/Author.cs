using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace MVCAuthor.Models
{
    public class Author
    {
        [Key]//Anotations
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int AuthorID { set; get; }

        [StringLength(25, ErrorMessage = "Author Name must not have more than 25 chars")]
        [MinLength(3, ErrorMessage = "Author Name must have at least 3 chars")]
        [Required(ErrorMessage = "AuthorName is Required")]
        public String AuthorName { set; get; }

        [Range(1, int.MaxValue, ErrorMessage = "Must Have Published Atleast 1 Book")]
        [Required(ErrorMessage = "Total No of Books Published is Required")]
        public int TotalBooks { set; get; }

        [Required(ErrorMessage = "Royalty is Required")]
        public String Royalty { set; get; }

        [Required(ErrorMessage = "Date of Birth is Required")]
        public DateTime DOB { set; get; }
    }
}

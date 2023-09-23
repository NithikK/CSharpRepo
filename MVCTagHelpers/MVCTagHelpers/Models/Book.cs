using System.ComponentModel.DataAnnotations;

namespace MVCTagHelpers.Models
{
    public class Book
    {
        [Key]
        public int BookID { set; get; }
        public String Title { set; get; }
        public float Cost { set; get; }
        public String AuthorName { set; get; }
    }
}

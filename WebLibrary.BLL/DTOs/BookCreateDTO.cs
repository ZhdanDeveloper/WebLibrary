using System.ComponentModel.DataAnnotations;
namespace WebLibrary.BLL.DTOs
{
    public class BookCreateDTO
    {
        [Required, MaxLength(150)]
        public string Name { get; set; }
        [Required, MaxLength(20)]
        public string Author { get; set; }
        public int PageNumber { get; set; }
        public string Genre { get; set; }
    }
}
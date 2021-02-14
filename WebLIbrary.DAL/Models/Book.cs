using System;
namespace WebLibrary.DAL.Models
{
    public class Book
    {
        public int Id { get; set; }
        public DateTime CreatedAt { get; set; } = DateTime.UtcNow;
        public string ISBN { get; set; }
        public string Name { get; set; }
        public string Author { get; set; }
        public int PageNumber { get; set; }
        public string Genre { get; set; }
    }
}
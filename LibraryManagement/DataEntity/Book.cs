using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LibraryManagement.DataEntity
{

    public class Book
    {
        [Key]

        public int BookId { get; set; }
        public string? Title { get; set; }
        public string? Author { get; set; }
        public int Year { get; set; }
        public int Page { get; set; }
        public string? Category { get; set; }
        public string? Image { get; set; }
    }

}
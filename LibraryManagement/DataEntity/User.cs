using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LibraryManagement.DataEntity
{

    public class User
    {
        [Key]

        public int UserId { get; set; }
        public string? UserName { get; set; }
        public string? UserSurname { get; set; }
        public string? Gender { get; set; }
        public string? Image { get; set; }
        public string? PhoneNumber { get; set; }
        public string? Email { get; set; }
    }

}
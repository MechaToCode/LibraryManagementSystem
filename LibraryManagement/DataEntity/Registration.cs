using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore.Metadata.Internal;

namespace LibraryManagement.DataEntity
{

    public class Registration
    {
        [Key]

        public int RegistrationId { get; set; }
        public int BookId { get; set; }
        public int UserId { get; set; }

    }
}
using System.ComponentModel.DataAnnotations;
using static ECommerceSite.Infrastructure.Constants.DataConstants;

namespace ECommerceSite.Infrastructure.Data.Models
{
    public class User
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(UserFirstNameMaxLength)]
        public string FirstName { get; set; } = string.Empty;

        [Required]
        [MaxLength(UserLastNameMaxLength)]
        public string LastName { get; set; } = string.Empty;

        //[Required]
        //public int PhoneNumber { get; set; }

        //[Required]
        //public string Password { get; set; } = string.Empty;

    }
}

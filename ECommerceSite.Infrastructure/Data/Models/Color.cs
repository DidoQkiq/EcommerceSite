using System.ComponentModel.DataAnnotations;
using static ECommerceSite.Infrastructure.Constants.DataConstants;

namespace ECommerceSite.Infrastructure.Data.Models
{
    public class Color
    {
        [Required]
        public int Id { get; set; }

        [Required]
        [MaxLength(ColorNameMaxLength)]
        public string ShoeColor { get; set; } = string.Empty;
    }
}

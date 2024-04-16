using System.ComponentModel.DataAnnotations;
using static ECommerceSite.Infrastructure.Constants.DataConstants;

namespace ECommerceSite.Infrastructure.Data.Models
{
    public class Brand
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(BrandNameMaxLength)]
        public string Name { get; set; } = string.Empty;
    }
}
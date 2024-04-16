using System.ComponentModel.DataAnnotations;
using static ECommerceSite.Infrastructure.Constants.DataConstants;

namespace ECommerceSite.Infrastructure.Data.Models
{
    public class Category
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [MaxLength(CategoryNameMaxLength)]
        public string Name { get; set; } = string.Empty;
    }
}

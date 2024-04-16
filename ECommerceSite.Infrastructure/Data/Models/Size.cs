using System.ComponentModel.DataAnnotations;

namespace ECommerceSite.Infrastructure.Data.Models
{
    public class Size
    {
        [Key]
        public int Id { get; set; }

        [Required]
        public int ShoeSize { get; set; }
    }
}

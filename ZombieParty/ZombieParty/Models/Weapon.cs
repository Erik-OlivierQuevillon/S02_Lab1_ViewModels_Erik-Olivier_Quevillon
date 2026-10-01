using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace ZombieParty.Models
{
    public class Weapon
    {
        [Required]
        [MaxLength(250)]
        [MinLength(2)]
        [DisplayName]
        
        public string Name { get; set; }
        [MaxLength(2500)]
        [DisplayName]
        public string? Description { get; set; }
        [Range(0,500)]
        public decimal Force { get; set; }
        [DataType(DataType.Currency)]
        [Range(0,100000,ErrorMessage ="The Price has to be between 0 and 100000")]
        public decimal Price { get; set; }
        [DataType(DataType.DateTime)]
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        [DataType(DataType.ImageUrl)]
        [DisplayName]
        public string? Image { get; set; }

        [DisplayName]
        public int Qty { get; set; }
        public int QtyBought { get; set; }

    }
}

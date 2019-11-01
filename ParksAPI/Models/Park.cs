using System.ComponentModel.DataAnnotations;

namespace ParksAPI.Models
{
    public class Park
    {
        public int ParkId { get; set; }
        
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        
        [Required]
        [StringLength(20)]
        public string State { get; set; }
        
        public int Miles { get; set; }
        
    }
}
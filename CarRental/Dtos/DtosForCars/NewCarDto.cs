using System.ComponentModel.DataAnnotations;

namespace CarRental.Dtos.DtosForCars
{
    public class NewCarDto
    {
        [Required]
        [MaxLength(255)]
        public string Name { get; set; }
        [Required]
        [MaxLength(255)]
        public string Description { get; set; }
        [Range(0, 100000)]
        public double DailyPrice { get; set; } = 999;
    }
}
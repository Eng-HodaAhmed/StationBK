using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StationBK.Core.Entities.Station
{
    public class Fuel
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string FuelName { get; set; }
        [Required]
        public float PreviousBalance { get; set; }
        [Required]
        public float CurrentBalance { get; set; }
        [Required]
        public float Amount { get; set; }

        [Required]
        public float Price { get; set; }

    }
}

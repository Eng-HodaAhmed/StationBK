using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StationBK.Core.Entities.Station
{
    public class FuelBalance
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
        public float IncomeAmount { get; set; }
        [Required]
        public float SalesAmount { get; set; }
        [Required]
        public float RemainAmount { get; set; }
        [Required]
        public float Commission { get; set; }

    }
}

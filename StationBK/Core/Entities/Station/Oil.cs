using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StationBK.Core.Entities.Station
{
    public class Oil
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Date { get; set; }
        [Required]
        public string OilName { get; set; }
        [Required]
        public float PreviousAmount { get; set; }
        [Required]
        public float IncomeAmount { get; set; }
        [Required]
        public float Price { get; set; }
        [Required]
        public float SoldAmount { get; set; }
        [Required]
        public float TotalPrice { get; set; }
        [Required]
        public float CurrentAmount { get; set; }
        [Required]
        public float Commission { get; set; }


    }
}

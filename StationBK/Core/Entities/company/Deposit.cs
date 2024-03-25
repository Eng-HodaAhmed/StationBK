using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StationBK.Core.Entities.company
{
    public class Deposit
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public float price { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public string priceType { get; set; }


    }
}

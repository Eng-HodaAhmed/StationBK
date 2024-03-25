
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace StationBK.Core.Entities.company
{
    public class Purchace
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int id { get; set; }
        [Required]
        public int quantity { get; set; }
        [Required]
        public DateTime date { get; set; }
        [Required]
        public string productName { get; set; }
        [Required]
        public float price { get; set; }
    }
}

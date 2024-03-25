using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;


namespace StationBK.Core.Entities.company
{
    public class Price
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public float solarPrice { get; set; }
        public float petrol80Price { get; set; }
        public float petrol92Price { get; set; }
        public DateTime date { get; set; }
        public Price()
        {
            date = DateTime.Now;
        }
    }

}

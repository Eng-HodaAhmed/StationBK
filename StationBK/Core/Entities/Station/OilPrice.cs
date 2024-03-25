using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace StationBK.Core.Entities.Station
{
    public class OilPrice
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        public float extra { get; set; }
        public float xpl { get; set; }
        public float sj { get; set; }
        public float coopFact4 { get; set; }
        public float coopFact5 { get; set; }
        public float coopFact20 { get; set; }
        public float mobil { get; set; }
        public float shell { get; set; }
        public float bakm { get; set; }
        public float shahm1 { get; set; }
        public float shahm2 { get; set; }
        public float shahm3 { get; set; }
        public float superStan4 { get; set; }
        public float superStan20 { get; set; }
        public float hydraulic { get; set; }
        public float troosSmall { get; set; }
        public float troosLarge { get; set; }
        public DateTime date { get; set; }
        public OilPrice()
        {
            date = DateTime.Now;
        }
    }
}

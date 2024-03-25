using System.ComponentModel.DataAnnotations;

namespace StationBK.Core.Entities.Station
{
    public class MonthlyBalance
    {
        [Key]
        public string Date { get; set; }
        public float OilEarns { get; set; }
        public float SolarEarns { get; set; }
        public float Banzeen80Earns { get; set; }
        public float Banzeen92Earns { get; set; }

    }
}

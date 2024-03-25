using System.ComponentModel.DataAnnotations;

namespace StationBK.Core.Entities.Station
{
    public class DailyShift
    {
        [Key]
        public string Date { get; set; }
        [Required]
        public string UserName { get; set; }
        public float Teps { get; set; }
        public float Washing { get; set; }
        public float FuelsMoney { get; set; }
        public float OilsMoney { get; set; }
        public float ExpensesMony { get; set; }
        public float CashMoney { get; set; }
        public float CrediteMoney { get; set; }
        public float deposit { get; set; }




    }
}

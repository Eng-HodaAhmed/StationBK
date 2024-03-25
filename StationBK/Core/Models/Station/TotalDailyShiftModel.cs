using System.ComponentModel.DataAnnotations;
using System.Runtime.CompilerServices;

namespace StationBK.Core.Models.Station
{
    public class TotalDailyShiftModel
    {
        public float Washing { get; set; }
        public float ExpensesMony { get; set; }
        public float CashMoney { get; set; }
        public float CrediteMoney { get; set; }
        public float Deposit { get; set; }

        public TotalDailyShiftModel(float cash,float credit,float expense,float washing, float deposit)
        {
            this.Washing = washing;
            this.CashMoney = cash;
            this.CrediteMoney = credit;
            this.Deposit = deposit;
            this.ExpensesMony = expense;
        }
    }
}

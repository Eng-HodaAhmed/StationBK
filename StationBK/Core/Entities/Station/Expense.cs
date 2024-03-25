using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StationBK.Core.Entities.Station
{
    public class Expense
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id { get; set; }
        [Required]
        public string Date { get; set; }
        public string ExpenseName { get; set;}
        public float ExpenseAmount { get; set;}
    }
}


using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace StationBK.Core.Entities.company
{

    public class Balance
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int BalanceId { get; set; }

        [Required]
        public float balance { get; set; }
        [Required]
        public int month { get; set; }
    }
}

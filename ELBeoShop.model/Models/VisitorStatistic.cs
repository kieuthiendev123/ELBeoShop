using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELBeoShop.model.Models
{
    [Table("VisitorStatistics")]
    public class VisitorStatistic
    {
        [Key]
        public int ID { get; set; }
        [Required]
        public string VisitedDate { get; set; }
        [Required]
        [MaxLength(50)]
        public string IPAddres { get; set; }
    }
}

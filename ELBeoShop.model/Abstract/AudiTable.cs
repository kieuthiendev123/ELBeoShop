using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ELBeoShop.model.Abstract
{
    public abstract class AudiTable : IAuditTable
    {
        public DateTime? CreatedDate { get; set; }
        [MaxLength(256)]
        public string CreatedBy { get; set; }
        public DateTime? UpdateDate { get ; set; }
        [MaxLength(256)]
        public string UpdateBy { get ; set; }
        [MaxLength(256)]
        public string MetaKeyWord { get; set; }
        [MaxLength(256)]
        public string MetaDescription { get; set; }
        [Required]
        public bool Status { get; set; }

    }
}

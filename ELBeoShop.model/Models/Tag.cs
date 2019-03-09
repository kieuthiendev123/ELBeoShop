using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELBeoShop.model.Models
{
    [Table("Tags")]
    public class Tag
    {
        [Key]
        [MaxLength(50)]
        public string ID { get; set; }
        [Column(TypeName ="nvarchar")]
        [Required]
        public string Name { get; set; }
        [Required]
        public string Type { get; set; }
        public virtual IEnumerable<PostTag> PostTags { get; set; }
    }
}
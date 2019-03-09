﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ELBeoShop.model.Models
{
    [Table("MenuGroups")]
    public class MenuGroup
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [MaxLength(10)]
        public string ID { get; set; }

        [Required]
        [MaxLength(50)]
        public string Name { get; set; }
        public virtual IEnumerable<Menu> Menus { get; set; }
    }
}
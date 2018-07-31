using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Rockcodeafrica.Domains
{
    public class Article : BaseEntity
    {
        [Required]
        [StringLength(255)]
        public string Title { get; set; }

        [Required]
        public string Content { get; set; }
        public string Image { get; set; }
        public DateTime Date { get; set; }

        public bool Published { get; set; }
    }
}

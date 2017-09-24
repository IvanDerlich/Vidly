using System;
using System.ComponentModel.DataAnnotations;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Genre
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public String Name { get; set; }
    }
}
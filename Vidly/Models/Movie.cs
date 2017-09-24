using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        
        public int Id { get; set; }
        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        //public int MyProperty { get; set; }
        //[Required]
        //[StringLength(50)]
        //public short Genre { get; set; }
        [Required]
        [StringLength(50)]
        public string ReleaseDate { get; set; }
        [Required]
        [StringLength(50)]
        public string DateAdded{ get; set; }
        [Required]
        public short NumberInStock{ get; set; }
    }
}
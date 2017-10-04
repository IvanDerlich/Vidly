namespace DatabaseCodeFirst.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Customer
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        public bool IsSuscribedToNewsLetter { get; set; }

        public byte MembershipTypeId { get; set; }

        public DateTime? BirthDate { get; set; }

        public virtual MembershipType MembershipType { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERMSystemObjects.Models
{
    [Table("PaymentStatus")]
    public partial class PaymentStatus
    {
        public PaymentStatus()
        {
            Payments = new HashSet<Payment>();
        }

        [Key]
        [Column("StatusID")]
        public int StatusId { get; set; }
        [StringLength(50)]
        public string StatusName { get; set; } = null!;

        [InverseProperty("Status")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}

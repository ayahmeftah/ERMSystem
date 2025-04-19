using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERMSystemObjects.Models
{
    [Table("Payment")]
    public partial class Payment
    {
        [Key]
        [Column("PaymentID")]
        public int PaymentId { get; set; }
        [StringLength(30)]
        public string PaymentMethod { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime PaymentDate { get; set; }
        public double Deposit { get; set; }
        [Column("TransactionID")]
        public int TransactionId { get; set; }
        [Column("StatusID")]
        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        [InverseProperty("Payments")]
        public virtual PaymentStatus Status { get; set; } = null!;
        [ForeignKey("TransactionId")]
        [InverseProperty("Payments")]
        public virtual RentalTransaction Transaction { get; set; } = null!;
    }
}

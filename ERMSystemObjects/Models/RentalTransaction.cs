using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERMSystemObjects.Models
{
    [Table("RentalTransaction")]
    public partial class RentalTransaction
    {
        public RentalTransaction()
        {
            Payments = new HashSet<Payment>();
            ReturnRecords = new HashSet<ReturnRecord>();
        }

        [Key]
        [Column("TransactionID")]
        public int TransactionId { get; set; }
        public int RentalPeriod { get; set; }
        public double RentalFee { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReturnDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActualRentalStartDate { get; set; }
        [Column("RequestID")]
        public int RequestId { get; set; }

        [ForeignKey("RequestId")]
        [InverseProperty("RentalTransactions")]
        public virtual RentalRequest Request { get; set; } = null!;
        [InverseProperty("Transaction")]
        public virtual ICollection<Payment> Payments { get; set; }
        [InverseProperty("Transaction")]
        public virtual ICollection<ReturnRecord> ReturnRecords { get; set; }
    }
}

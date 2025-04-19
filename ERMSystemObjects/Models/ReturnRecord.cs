using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERMSystemObjects.Models
{
    [Table("ReturnRecord")]
    public partial class ReturnRecord
    {
        [Key]
        [Column("ReturnRecordID")]
        public int ReturnRecordId { get; set; }
        [StringLength(50)]
        public string ReturnCondition { get; set; } = null!;
        public double LateReturnFee { get; set; }
        public double AdditionalCharges { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActualReturnDate { get; set; }
        [Column("TransactionID")]
        public int TransactionId { get; set; }

        [ForeignKey("TransactionId")]
        [InverseProperty("ReturnRecords")]
        public virtual RentalTransaction Transaction { get; set; } = null!;
    }
}

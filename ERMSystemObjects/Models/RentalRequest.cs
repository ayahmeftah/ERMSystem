using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERMSystemObjects.Models
{
    [Table("RentalRequest")]
    public partial class RentalRequest
    {
        public RentalRequest()
        {
            RentalTransactions = new HashSet<RentalTransaction>();
        }

        [Key]
        [Column("RequestID")]
        public int RequestId { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime RentalStartDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ReturnDate { get; set; }
        public double TotalCost { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        [Column("StatusID")]
        public int StatusId { get; set; }

        [ForeignKey("EquipmentId")]
        [InverseProperty("RentalRequests")]
        public virtual Equipment Equipment { get; set; } = null!;
        [ForeignKey("StatusId")]
        [InverseProperty("RentalRequests")]
        public virtual RentalRequestStatus Status { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("RentalRequests")]
        public virtual User User { get; set; } = null!;
        [InverseProperty("Request")]
        public virtual ICollection<RentalTransaction> RentalTransactions { get; set; }
    }
}

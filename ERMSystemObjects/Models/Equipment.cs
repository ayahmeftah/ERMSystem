using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERMSystemObjects.Models
{
    public partial class Equipment
    {
        public Equipment()
        {
            Feedbacks = new HashSet<Feedback>();
            RentalRequests = new HashSet<RentalRequest>();
        }

        [Key]
        [Column("EquipmentID")]
        public int EquipmentId { get; set; }
        [StringLength(50)]
        public string EquipmentName { get; set; } = null!;
        [StringLength(200)]
        public string Description { get; set; } = null!;
        public double RentalPrice { get; set; }
        [StringLength(50)]
        public string AvailabilityStatus { get; set; } = null!;
        [StringLength(50)]
        public string ConditionStatus { get; set; } = null!;
        [Column("CategoryID")]
        public int CategoryId { get; set; }

        [ForeignKey("CategoryId")]
        [InverseProperty("Equipment")]
        public virtual Category Category { get; set; } = null!;
        [InverseProperty("Equipment")]
        public virtual ICollection<Feedback> Feedbacks { get; set; }
        [InverseProperty("Equipment")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
    }
}

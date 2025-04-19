using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERMSystemObjects.Models
{
    [Table("Notification")]
    public partial class Notification
    {
        [Key]
        [Column("NotificationID")]
        public int NotificationId { get; set; }
        [StringLength(200)]
        public string MessegeContent { get; set; } = null!;
        [StringLength(50)]
        public string NotificationType { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime NotificationDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime NotificationTime { get; set; }
        [Column("UserID")]
        public int UserId { get; set; }
        [Column("StatusID")]
        public int StatusId { get; set; }

        [ForeignKey("StatusId")]
        [InverseProperty("Notifications")]
        public virtual NotificationStatus Status { get; set; } = null!;
        [ForeignKey("UserId")]
        [InverseProperty("Notifications")]
        public virtual User User { get; set; } = null!;
    }
}

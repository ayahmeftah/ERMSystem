using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERMSystemObjects.Models
{
    [Table("Log")]
    public partial class Log
    {
        [Key]
        [Column("LogID")]
        public int LogId { get; set; }
        [StringLength(50)]
        public string Action { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime ActionDate { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime ActionTime { get; set; }
        [StringLength(100)]
        public string AffectedData { get; set; } = null!;
        [StringLength(50)]
        public string Source { get; set; } = null!;
        [Column("UserID")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Logs")]
        public virtual User User { get; set; } = null!;
    }
}

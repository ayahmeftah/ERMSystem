using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERMSystemObjects.Models
{
    [Table("Document")]
    public partial class Document
    {
        [Key]
        [Column("DocumentID")]
        public int DocumentId { get; set; }
        [StringLength(200)]
        public string StoragePath { get; set; } = null!;
        [StringLength(50)]
        public string FileName { get; set; } = null!;
        [Column(TypeName = "datetime")]
        public DateTime UploadDate { get; set; }
        [StringLength(50)]
        public string FileType { get; set; } = null!;
        [Column("UserID")]
        public int UserId { get; set; }

        [ForeignKey("UserId")]
        [InverseProperty("Documents")]
        public virtual User User { get; set; } = null!;
    }
}

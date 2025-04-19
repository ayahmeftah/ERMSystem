using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace ERMSystemObjects.Models
{
    [Table("RentalRequestStatus")]
    public partial class RentalRequestStatus
    {
        public RentalRequestStatus()
        {
            RentalRequests = new HashSet<RentalRequest>();
        }

        [Key]
        [Column("StatusID")]
        public int StatusId { get; set; }
        [StringLength(50)]
        public string StatusName { get; set; } = null!;

        [InverseProperty("Status")]
        public virtual ICollection<RentalRequest> RentalRequests { get; set; }
    }
}

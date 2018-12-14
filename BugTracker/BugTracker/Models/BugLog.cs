namespace BugTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("BugLog")]
    public partial class BugLog
    {
        [Key]
        public int BugID { get; set; }

        [Required]
        [StringLength(50)]
        public string Title { get; set; }

        [Required]
        public string Description { get; set; }

        public DateTime Created { get; set; }

        public int UserID { get; set; }

        public int PriorityID { get; set; }

        public int? StatusID { get; set; }
       
        public virtual Principal Principal { get; set; }

        public virtual Status Status { get; set; }
    }
}

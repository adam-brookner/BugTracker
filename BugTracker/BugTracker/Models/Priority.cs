namespace BugTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Priority")]
    public partial class Priority
    {
        public int PriorityID { get; set; }

        [Required]
        [StringLength(50)]
        public string PriorityName { get; set; }

        [Required]
        public string Description { get; set; }
    }
}

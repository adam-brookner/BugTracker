namespace BugTracker.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Principal")]
    public partial class Principal
    {
        [Key]
        public int UserID { get; set; }

        [Required]
        [StringLength(50)]
        public string Forename { get; set; }

        [Required]
        [StringLength(50)]
        public string Surname { get; set; }

        [Required]
        [StringLength(50)]
        public string Email { get; set; }

        [Column("Phone Number")]
        [Required]
        [StringLength(11)]
        public string Phone_Number { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Required]
        [StringLength(10)]
        public string PostCode { get; set; }

        public int DepartmentID { get; set; }

        [StringLength(50)]
        public string JobDescription { get; set; }

        public virtual Department Department { get; set; }
    }
}

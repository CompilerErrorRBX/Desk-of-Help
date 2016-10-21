namespace WebApplication3.Controllers
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("User")]
    public partial class User
    {
		[Key]
        public int ID { get; set; }

        [StringLength(254)]
        public string emailAddress { get; set; }

        public string photo { get; set; }

        public string firstName { get; set; }

        public string lastName { get; set; }

        [Required]
        [StringLength(64)]
        public string passwordHash { get; set; }

        [Required]
        [StringLength(20)]
        public string passwordSalt { get; set; }

        public bool verified { get; set; }
    }
}

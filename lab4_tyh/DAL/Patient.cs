namespace lab4_tyh
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Patient")]
    public partial class Patient
    {
        [StringLength(50)]
        public string Id { get; set; }

        [StringLength(50)]
        public string Name { get; set; }

        [Column(TypeName = "date")]
        public DateTime? Birthday { get; set; }

        [StringLength(50)]
        public string Region { get; set; }

        [StringLength(50)]
        public string District { get; set; }

        [StringLength(50)]
        public string City { get; set; }

        [StringLength(50)]
        public string Disease1 { get; set; }

        public virtual Disease Disease { get; set; }
    }
}

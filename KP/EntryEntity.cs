namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Entry")]
    public partial class EntryEntity
    {
        [Key]
        public long id_entry { get; set; }

        public long id_patient { get; set; }

        public long id_procedure { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("date_receipt")]
        public string Datereceipt { get; set; }

        [Column("status_receipt")]
        public long Statusreceipt { get; set; }

        //[Column("id_specialization")]
        public virtual ProcedureEntity Procedure { get; set; }

        //[Column("id_specialization")]
        public virtual PatientEntity Patient { get; set; }
    }
}

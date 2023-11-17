namespace StomatologyProject
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Doctor")]
    public partial class DoctorEntity
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DoctorEntity()
        {
            Procedure = new HashSet<ProcedureEntity>();
        }

        [Key]
        public long id_doctor { get; set; }

        public long id_user { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("last_name")]
        public string Lastname { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("name")]
        public string Name { get; set; }

        [StringLength(2147483647)]
        [Column("middle_name")]
        public string Middlename { get; set; }

        [Column("id_specialization")]
        public long Specialization { get; set; }

        [Required]
        [StringLength(2147483647)]
        [Column("contact_info")]
        public string Contactinfo { get; set; }

        public virtual UserEntity User { get; set; }

        public virtual SpecializationEntity Specialization_ { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ProcedureEntity> Procedure { get; set; }
    }
}

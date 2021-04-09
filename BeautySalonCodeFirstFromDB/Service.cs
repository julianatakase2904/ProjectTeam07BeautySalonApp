namespace BeautySalonCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Service
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Service()
        {
            Appointments = new HashSet<Appointment>();
        }

        [Column(Order = 0)]
        [Key]
        public int ServiceId { get; set; }

        [Required]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ServiceName { get; set; }

        [Column(Order = 2)]
        public decimal ServicePrice { get; set; }

        [Column(Order = 3)]
        public int? ProductId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Appointment> Appointments { get; set; }

        public virtual Inventory Inventory { get; set; }
    }
}

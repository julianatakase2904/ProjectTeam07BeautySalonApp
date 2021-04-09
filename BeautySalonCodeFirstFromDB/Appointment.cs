namespace BeautySalonCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Appointment
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Appointment()
        {
            Payments = new HashSet<Payment>();
        }

        [Key]
        public int AppointmentId { get; set; }

        [Required]
        [StringLength(50)]
        public string AppointmentDate { get; set; }

        [Required]
        [StringLength(50)]
        public string AppointmentTime { get; set; }

        public int ClientId { get; set; }

        public int EmployeeId { get; set; }

        public int ServiceId { get; set; }

        public virtual Client Client { get; set; }

        public virtual Employee Employee { get; set; }

        public virtual Service Service { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Payment> Payments { get; set; }
    }
}

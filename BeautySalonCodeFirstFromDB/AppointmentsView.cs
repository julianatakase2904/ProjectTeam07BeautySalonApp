namespace BeautySalonCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("AppointmentsView")]
    public partial class AppointmentsView
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string AppointmentDate { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string AppointmentTime { get; set; }

        [Key]
        [Column(Order = 2)]
        [StringLength(50)]
        public string ClientFirstName { get; set; }

        [Key]
        [Column(Order = 3)]
        [StringLength(50)]
        public string ClientLastName { get; set; }

        [Key]
        [Column(Order = 4)]
        [StringLength(50)]
        public string EmployeeFirstName { get; set; }

        [Key]
        [Column(Order = 5)]
        [StringLength(50)]
        public string EmployeeLastName { get; set; }

        [Key]
        [Column(Order = 6)]
        [StringLength(50)]
        public string ServiceName { get; set; }

        [Key]
        [Column(Order = 7)]
        public decimal ServicePrice { get; set; }
    }
}

namespace BeautySalonCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Payment
    {
        public int PaymentId { get; set; }

        public int EmployeeId { get; set; }

        public int AppointmentId { get; set; }

        public decimal Tax { get; set; }
        public decimal Paid { get; set; }

        public virtual Appointment Appointment { get; set; }

        public virtual Employee Employee { get; set; }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace BeautySalonCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ServiceInventoryView")]
    public partial class ServiceInventoryView
    {
        [Key]
        [Column(Order = 0)]
        public int ServiceId { get; set; }

        [Column(Order = 1)]
        [StringLength(50)]
        public string ServiceName { get; set; }

        [Column(Order = 2)]
        public decimal ServicePrice { get; set; }

        [Column(Order = 3)]
        public int ProductId { get; set; }

        [Column(Order = 4)]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Column(Order = 5)]
        public int ProductQuantity { get; set; }
    }
}

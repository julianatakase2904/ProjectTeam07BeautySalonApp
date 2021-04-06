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

    [Table("ServicesView")]
    public partial class ServicesView
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ServiceName { get; set; }

        [Column(Order = 1)]
        public decimal ServicePrice { get; set; }

        [Column(Order = 2)]
        [StringLength(50)]
        public string ProductName { get; set; }
    }
}

namespace BeautySalonCodeFirstFromDB
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("SalesView")]
    public partial class SalesView
    {
        [Key]
        [Column(Order = 0)]
        public int ProductId { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(50)]
        public string ProductName { get; set; }

        [Key]
        [Column(Order = 2)]
        public int ProductQuantity { get; set; }

        [Key]
        [Column(Order = 3)]
        public int Sell { get; set; }

        [Key]
        [Column(Order = 4)]
        public int Remain { get; set; }
    }
}

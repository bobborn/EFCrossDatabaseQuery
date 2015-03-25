namespace EFCrossDatabaseQuery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("OrderItem")]
    public partial class OrderItem
    {
        [Key]
        public int ItemId { get; set; }

        public int OrderNo { get; set; }

        public int ProductId { get; set; }

        public int Count { get; set; }

        public decimal Price { get; set; }

        public virtual Order Order { get; set; }
    }
}

namespace EFCrossDatabaseQuery
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Order")]
    public partial class Order
    {
        public Order()
        {
            OrderItem = new HashSet<OrderItem>();
        }

        [Key]
        public int OrderNo { get; set; }

        public int MemberId { get; set; }

        public decimal TotalMoney { get; set; }

        public virtual ICollection<OrderItem> OrderItem { get; set; }

        public virtual Member Member { get; set; }
    }
}

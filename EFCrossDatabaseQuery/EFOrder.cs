namespace EFCrossDatabaseQuery
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EFOrderContext : DbContext
    {

        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderItem> OrderItems { get; set; }

        public virtual DbSet<Member> Members { get; set; }

        public virtual DbSet<Product> Products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Order>()
                .HasMany(e => e.OrderItem)
                .WithRequired(e => e.Order)
                .WillCascadeOnDelete(false);


            modelBuilder.Entity<Order>()
                .HasRequired(t => t.Member)
                .WithMany()
                .HasForeignKey(t => t.MemberId);
        }
    }
}

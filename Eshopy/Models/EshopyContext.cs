namespace Eshopy.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EshopyContext : DbContext
    {
        public EshopyContext()
            : base("name=EshopyConnection")
        {
        }

      
        public virtual DbSet<Products> Products { get; set; }
        public virtual DbSet<Cart> Carts { get; set; }
        public virtual DbSet<Order> Orders { get; set; }
        public virtual DbSet<OrderDetail> OrderDetails { get; set; }
     
    }
}

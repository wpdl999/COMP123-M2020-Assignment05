namespace COMP123_M2020_Assignment05
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    /*
    Author's name : Wooram Moon
    Author's student Number : 301098673
    Date last Modified : 
    Program description
    1st Revision : Aug 12th
 */
    public partial class ProductsModel : DbContext
    {
        public ProductsModel()
            : base("name=ProductsModel")
        {
        }

        public virtual DbSet<Products> products { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Products>()
                .Property(e => e.cost)
                .HasPrecision(19, 4);
        }
    }
}

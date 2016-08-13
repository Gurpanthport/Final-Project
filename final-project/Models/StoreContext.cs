namespace final_project.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class StoreContext : DbContext
    {
        public StoreContext()
            : base("name=StoreConnection")
        {
        }

        public virtual DbSet<StoreType> StoreTypes { get; set; }
        public virtual DbSet<StoreItem> StoreItems { get; set; }
    }
}

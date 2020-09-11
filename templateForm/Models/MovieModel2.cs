namespace templateForm.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class MovieModel2 : DbContext
    {
        public MovieModel2()
            : base("name=MovieModel2")
        {
        }

        public virtual DbSet<movies> movies { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}

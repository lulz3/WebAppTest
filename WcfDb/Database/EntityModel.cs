namespace WcfDb
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class EntityModel : DbContext
    {
        public EntityModel() : base("name=EntityModel")
        {
            //Database.SetInitializer<EntityModel>(new CreateDatabaseIfNotExists<EntityModel>());
            //Database.SetInitializer<EntityModel>(new DropCreateDatabaseAlways<EntityModel>());
            //Database.SetInitializer<EntityModel>(null);
        }

        public virtual DbSet<Auto> Auto { get; set; }
        public virtual DbSet<Clovek> Clovek { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //modelBuilder.Configurations.Add(new AutoEntityConfiguration());

            modelBuilder.Entity<Clovek>()
                .HasMany(e => e.Auto)
                .WithRequired(e => e.Clovek)
                .HasForeignKey(e => e.Id_Clovek)
                .WillCascadeOnDelete(false);
        }
        /*
        public class DBInitializer : CreateDatabaseIfNotExists<EntityModel>
        {
            protected override void Seed(EntityModel context)
            {
                base.Seed(context);
            }
        }
        */
    }
}

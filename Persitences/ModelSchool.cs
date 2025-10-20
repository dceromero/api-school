using System.Data.Entity;
using WebApiSchool.Entitys;

namespace WebApiSchool.Persitences
{
    public partial class ModelSchool : DbContext
    {
        public ModelSchool()
            : base("name=ModelSchool")
        {
            Database.SetInitializer<ModelSchool>(null);
        }

        public virtual DbSet<UsuarioEntity> UsuarioEntities{ get; set; }

        public virtual DbSet<MenuEntity> MenuEntities { get; set; }


        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<UsuarioEntity>()
                .HasKey(e => e.nombreUsr);
        }
    }
}

using Business.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ResourceAccess.Repository.Config
{
    public class RolConfig : EntityTypeConfiguration<Rol>
    {
        public RolConfig()
        {
            this.ToTable("t_Rol");

            this.HasKey(m => m.ID).Property(m => m.ID).HasColumnName("ID_Rol");

            this.Property(m => m.Descripcion).IsRequired();
        }
    }
}

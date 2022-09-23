using Business.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ResourceAccess.Repository.Config
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            this.ToTable("t_Usuario");

            this.HasKey(p => p.ID).Property(p => p.ID).HasColumnName("ID_Usuario").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.NombreUsuario).IsRequired();
            this.Property(p => p.Clave).IsRequired();
            this.Property(p => p.Habilitado).IsRequired();
            this.Property(p => p.CambiaClave).IsOptional();

            this.HasOptional(p => p.Persona).WithMany().Map(m => m.MapKey("ID_Persona")).WillCascadeOnDelete(true);
            this.HasOptional(p => p.Rol).WithMany().Map(m => m.MapKey("ID_Rol")).WillCascadeOnDelete(false);

            this.Ignore(p => p.Descripcion);
        }
    }
}

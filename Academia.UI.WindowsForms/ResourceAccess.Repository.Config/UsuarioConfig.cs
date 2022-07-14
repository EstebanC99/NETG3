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
            this.Property(p => p.Nombre).IsRequired();
            this.Property(p => p.Apellido).IsRequired();
            this.Property(p => p.Email).IsOptional();
            this.Property(p => p.CambiaClave).IsOptional();
        }
    }
}

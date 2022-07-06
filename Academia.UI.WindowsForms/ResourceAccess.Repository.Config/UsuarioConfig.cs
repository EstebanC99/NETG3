using Business.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity.ModelConfiguration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ResourceAccess.Repository.Config
{
    public class UsuarioConfig : EntityTypeConfiguration<Usuario>
    {
        public UsuarioConfig()
        {
            this.ToTable("t_Usuario");

            this.HasKey(p => p.ID).Property(p => p.ID).HasColumnName("ID_Usuario");

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

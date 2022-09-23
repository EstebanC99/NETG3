using Business.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;
using static Business.Entities.Global.TiposPersonas;

namespace ResourceAccess.Repository.Config
{
    public class PersonaConfig : EntityTypeConfiguration<Persona>
    {
        public PersonaConfig()
        {
            this.Map(m =>
            {
                m.ToTable("t_Persona");
            })
                .Map<Alumno>(m => m.Requires("TipoPersona").HasValue((int)TiposPersona.Alumno))
                .Map<Profesor>(m => m.Requires("TipoPersona").HasValue((int)TiposPersona.Profesor))
                .Map<Administrador>(m => m.Requires("TipoPersona").HasValue((int)TiposPersona.Administrador));

            this.HasKey(p => p.ID).Property(p => p.ID).HasColumnName("ID_Persona").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(p => p.Nombre).IsRequired();
            this.Property(p => p.Apellido).IsRequired();
            this.Property(p => p.FechaNacimiento).IsRequired();

            this.Property(p => p.Direccion).IsOptional();
            this.Property(p => p.Email).IsOptional();
            this.Property(p => p.Telefono).IsOptional();
            this.Property(p => p.Legajo).IsOptional();

            this.HasOptional(p => p.Plan).WithMany().Map(m => m.MapKey("ID_Plan"));

            this.Ignore(p => p.Descripcion);
        }
    }
}

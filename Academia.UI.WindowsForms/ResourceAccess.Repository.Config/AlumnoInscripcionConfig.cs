using Business.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ResourceAccess.Repository.Config
{
    public class AlumnoInscripcionConfig : EntityTypeConfiguration<AlumnoInscripcion>
    {
        public AlumnoInscripcionConfig()
        {
            this.ToTable("t_AlumnoInscripcion");

            this.HasKey(m => new { m.ID, m.ID_Persona_Alumno, m.ID_Curso });
            this.Property(m => m.ID).HasColumnName("ID_Inscripcion").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.HasRequired(m => m.Curso).WithMany().Map(m => m.MapKey("ID_Curso"));
            this.HasRequired(m => m.Alumno).WithMany().Map(m => m.MapKey("ID_Persona_Alumno"));

            this.Ignore(m => m.Descripcion);
        }
    }
}

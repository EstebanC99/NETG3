using Business.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ResourceAccess.Repository.Config
{
    public class DocenteCursoConfig : EntityTypeConfiguration<DocenteCurso>
    {
        public DocenteCursoConfig()
        {
            this.ToTable("t_DocenteCurso");

            this.HasKey(m => new { m.ID, m.ID_Persona_Profesor });
            this.Property(m => m.ID).HasColumnName("ID_DocenteCurso").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(m => m.Cargo).IsRequired();

            this.HasRequired(m => m.Curso).WithMany().Map(m => m.MapKey("ID_Curso"));
            this.HasRequired(m => m.Profesor).WithMany().Map(m => m.MapKey("ID_Persona_Profesor"));

            this.Ignore(m => m.Descripcion);

        }
    }
}

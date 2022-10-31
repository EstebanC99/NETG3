using Business.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ResourceAccess.Repository.Config
{
    public class CursoConfig : EntityTypeConfiguration<Curso>
    {
        public CursoConfig()
        {
            this.ToTable("t_Curso");

            this.HasKey(m => m.ID).Property(m => m.ID).HasColumnName("ID_Curso").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(m => m.AnioCalendario).IsRequired();
            this.Property(m => m.Cupo).IsRequired();

            this.HasRequired(m => m.Materia).WithMany().Map(m => m.MapKey("ID_Materia"));
            this.HasOptional(m => m.Comision).WithMany().Map(m => m.MapKey("ID_Comision"));

            this.HasMany(m => m.Inscriptos).WithRequired(m => m.Curso).HasForeignKey(m => m.ID_Curso).WillCascadeOnDelete();

            this.Ignore(m => m.Descripcion);
        }
    }
}

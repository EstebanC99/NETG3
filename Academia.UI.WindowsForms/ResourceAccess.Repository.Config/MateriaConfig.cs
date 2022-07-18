using Business.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ResourceAccess.Repository.Config
{
    public class MateriaConfig : EntityTypeConfiguration<Materia>
    {
        public MateriaConfig()
        {
            this.ToTable("t_Materia");

            this.HasKey(m => m.ID).Property(m => m.ID).HasColumnName("ID_Materia").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(m => m.Descripcion).IsRequired();
            this.Property(m => m.HsSemanales).IsRequired();
            this.Property(m => m.HsTotales).IsRequired();

            this.HasRequired(m => m.Plan).WithMany().Map(m => m.MapKey("ID_Plan"));
        }
    }
}

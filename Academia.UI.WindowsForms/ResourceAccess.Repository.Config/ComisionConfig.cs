using Business.Entities;
using System.Data.Entity.ModelConfiguration;

namespace ResourceAccess.Repository.Config
{
    public class ComisionConfig : EntityTypeConfiguration<Comision>
    {
        public ComisionConfig()
        {
            this.ToTable("t_Comision");

            this.HasKey(m => m.ID).Property(m => m.ID).HasColumnName("ID_Comision").HasDatabaseGeneratedOption(System.ComponentModel.DataAnnotations.Schema.DatabaseGeneratedOption.Identity);

            this.Property(m => m.Descripcion).IsRequired();
            this.Property(m => m.AnioEspecialidad).IsRequired();

            this.HasOptional(m => m.Plan).WithMany().Map(m => m.MapKey("ID_Plan"));
        }
    }
}

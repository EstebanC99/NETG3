using Business.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ResourceAccess.Repository.Config
{
    public class PlanConfig : EntityTypeConfiguration<Plan>
    {
        public PlanConfig()
        {
            this.ToTable("t_Plan");

            this.HasKey(m => m.ID).Property(m => m.ID).HasColumnName("ID_Plan").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.Descripcion).IsRequired();

            this.HasRequired(m => m.Especialidad).WithMany().Map(m => m.MapKey("ID_Especialidad"));
        }
    }
}

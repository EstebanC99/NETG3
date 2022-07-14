using Business.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace ResourceAccess.Repository.Config
{
    public class EspecialidadConfig : EntityTypeConfiguration<Especialidad>
    {
        public EspecialidadConfig()
        {
            this.ToTable("t_Especialidad");

            this.HasKey(m => m.ID).Property(m => m.ID).HasColumnName("ID_Especialidad").HasDatabaseGeneratedOption(DatabaseGeneratedOption.Identity);

            this.Property(m => m.Descripcion).IsRequired();
        }
    }
}

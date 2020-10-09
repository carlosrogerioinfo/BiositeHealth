using Biosite.Domain.ExamName.Entities;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Biosite.Infra.Persistence.Mappings
{
    public class ExamMapping : EntityTypeConfiguration<Exam>
    {
        public ExamMapping()
        {
            ToTable("biositeapp_exam");

            HasKey(x => x.Id);
            Property(x => x.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.BiologicalValue).IsRequired();
            Property(x => x.ExamCode).IsRequired();
            Property(x => x.ExamName).IsRequired().HasMaxLength(255);
            Property(x => x.ExamUnit).IsRequired().HasMaxLength(20);
            Property(x => x.PatientResult).IsRequired();
            Property(x => x.ReferenceMinValue).IsRequired();
            Property(x => x.ReferenceMaxValue).IsRequired();
            Property(x => x.UseQuartil).IsRequired();
            Property(x => x.LastUpdate).IsRequired();
        }
    }
}

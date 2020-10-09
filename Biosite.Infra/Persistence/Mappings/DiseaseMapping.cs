using Biosite.Domain.Problem.Entities;
using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace Biosite.Infra.Persistence.Mappings
{
    public class DiseaseMapping : EntityTypeConfiguration<Disease>
    {
        public DiseaseMapping()
        {
            ToTable("biositeapp_disease");

            HasKey(x => x.Id);

            Property(x => x.CID).IsRequired().HasMaxLength(10);
            Property(x => x.Name).IsRequired().HasMaxLength(255);
            Property(x => x.Description).IsRequired().HasMaxLength(1000);

            // 1:N Relationship
            // One disease can have many prescriptions
            //HasMany(x => x.Prescriptions)
            //    .WithRequired(x => x.Disease)
            //    .HasForeignKey(x => x.DiseaseId);

        }
    }
}

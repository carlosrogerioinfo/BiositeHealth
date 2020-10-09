using Biosite.Domain.Formulation.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Biosite.Infra.Persistence.Mappings
{
    public class PrescriptionMapping : EntityTypeConfiguration<Prescription>
    {
        public PrescriptionMapping()
        {
            ToTable("biositeapp_prescription");

            HasKey(x => x.Id);
            //Property(x => x.Id).HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            Property(x => x.Name).IsRequired().HasMaxLength(250);
            Property(x => x.Description).IsRequired().HasMaxLength(4000);
            Property(x => x.Active);
            Property(x => x.LastUpdate);

            //Onde disease can have many prescriptions
            HasMany(x => x.PrescriptionDetails)
                .WithRequired(x => x.Prescription)
                .HasForeignKey(x => x.PrescriptionId);



            //HasRequired(x => x.Nutraceutical)
            //    .WithMany(x => x.Prescriptions)
            //    .HasForeignKey(c => c.NutraceuticalId);
        }
    }
}

using Biosite.Domain.Formulation.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace Biosite.Infra.Persistence.Mappings
{
    public class PrescriptionDetailMapping : EntityTypeConfiguration<PrescriptionDetail>
    {
        public PrescriptionDetailMapping()
        {
            ToTable("biositeapp_prescription_detail");

            HasKey(x => x.Id);

            Property(x => x.Dosage).IsRequired().HasMaxLength(500);
            Property(x => x.Group).IsRequired();

            Property(x => x.Posology).IsRequired().HasMaxLength(4000);
            Property(x => x.Information).IsRequired().HasMaxLength(4000);
            Property(x => x.Note).IsRequired().HasMaxLength(4000);

            Property(x => x.Active);
            Property(x => x.LastUpdate);

            HasRequired(x => x.Prescription)
                .WithMany(x => x.PrescriptionDetails)
                .HasForeignKey(c => c.PrescriptionId);

            HasRequired(x => x.Nutraceutical)
                .WithMany(x => x.PrescriptionDetails)
                .HasForeignKey(c => c.NutraceuticalId);


            //Onde disease can have many prescriptions
            //HasRequired(x => x.Disease)
            //    .WithMany(x => x.Prescriptions)
            //    .HasForeignKey(c => c.DiseaseId);

            //HasRequired(x => x.Nutraceutical)
            //    .WithMany(x => x.Prescriptions)
            //    .HasForeignKey(c => c.NutraceuticalId);

        }
    }
}

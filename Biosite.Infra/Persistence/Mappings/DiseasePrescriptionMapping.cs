using Biosite.Domain.Formulation.Entities;
using System.Data.Entity.ModelConfiguration;
using System.ComponentModel.DataAnnotations.Schema;
using System;
using Biosite.Domain.Problem.Entities;

namespace Biosite.Infra.Persistence.Mappings
{
    public class DiseasePrescriptionMapping : EntityTypeConfiguration<DiseasePrescription>
    {
        public DiseasePrescriptionMapping()
        {
            ToTable("biositeapp_disease_prescription");

            HasKey(x => x.Id);

            HasRequired(x => x.Disease)
                .WithMany(x => x.DiseasePrescription)
                .HasForeignKey(c => c.DiseaseId);

            HasRequired(x => x.Prescription)
                .WithMany(x => x.DiseasePrescription)
                .HasForeignKey(c => c.PrescriptionId);

        }
    }
}
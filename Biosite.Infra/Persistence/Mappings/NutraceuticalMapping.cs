using Biosite.Domain.Substance.Entities;
using System.Data.Entity.ModelConfiguration;

namespace Biosite.Infra.Persistence.Mappings
{
    public class NutraceuticalMapping : EntityTypeConfiguration<Nutraceutical>
    {
        public NutraceuticalMapping()
        {
            ToTable("biositeapp_nutraceutical");

            HasKey(x => x.Id);

            Property(x => x.Name).IsRequired().HasMaxLength(250);
            Property(x => x.CommonName).HasMaxLength(250);
            Property(x => x.Pharmacology).IsRequired();
            Property(x => x.ActionMechanism).IsRequired();

            Property(x => x.Indications).IsRequired();
            Property(x => x.AgainstIndications).IsRequired();
            Property(x => x.AdverseReactions).IsRequired();
            Property(x => x.DrugInteractions).IsRequired();
            Property(x => x.DescriptionDosages).IsRequired();
            Property(x => x.RecomendedDosages).IsRequired();
            Property(x => x.NutraceuticalReferences).IsRequired();
            Property(x => x.Unity).IsRequired().HasMaxLength(20);
            Property(x => x.NutraceuticalType).IsRequired();
            Property(x => x.MedicalOnly).IsRequired();

            Property(x => x.Verified);
            Property(x => x.Active);
            Property(x => x.LastUpdate);

            HasMany(x => x.PrescriptionDetails)
                .WithRequired(x => x.Nutraceutical)
                .HasForeignKey(x => x.NutraceuticalId);

        }
    }
}

using Biosite.Domain.Substance.Enums;
using System;

namespace Biosite.Domain.Substance.Commands.SubstanceCommands
{
    public class UpdateNutraceuticalCommand
    {
        public UpdateNutraceuticalCommand(Guid id, string name, string pharmacology, string actionMechanism, string indications, string againstIndications, string adverseReactions, string drugInteractions,
            string descriptionDosages, string recomendedDosages, string nutraceuticalReferences, NutraceuticalType nutraceuticalType, int minDosage, int maxDosage, string unity, bool medicalonly, string commonName)
        {
            Id = id;
            Name = name;
            CommonName = commonName;
            Pharmacology = pharmacology;
            ActionMechanism = actionMechanism;
            Indications = indications;
            AgainstIndications = againstIndications;
            AdverseReactions = adverseReactions;
            DrugInteractions = drugInteractions;
            DescriptionDosages = descriptionDosages;
            RecomendedDosages = recomendedDosages;
            NutraceuticalReferences = nutraceuticalReferences;
            NutraceuticalType = nutraceuticalType;
            MinDosage = minDosage;
            MaxDosage = maxDosage;
            Unity = unity;
            MedicalOnly = medicalonly;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string CommonName { get; private set; }
        public string Pharmacology { get; private set; }
        public string ActionMechanism { get; private set; }
        public string Indications { get; private set; }
        public string AgainstIndications { get; private set; }
        public string AdverseReactions { get; private set; }
        public string DrugInteractions { get; private set; }
        public string DescriptionDosages { get; private set; }
        public string RecomendedDosages { get; private set; }
        public string NutraceuticalReferences { get; private set; }
        public NutraceuticalType NutraceuticalType { get; private set; }
        public int MinDosage { get; set; }
        public int MaxDosage { get; set; }
        public string Unity { get; set; }
        public bool MedicalOnly { get; set; }
    }
}
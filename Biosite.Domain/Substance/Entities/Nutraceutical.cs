using Biosite.Domain.Formulation.Entities;
using Biosite.Domain.Substance.Enums;
using System;
using System.Collections.Generic;
using Biosite.SharedKernel.Library;
using System.ComponentModel.DataAnnotations.Schema;

namespace Biosite.Domain.Substance.Entities
{
    public class Nutraceutical
    {

        public Nutraceutical()
        {
            this.PrescriptionDetails = new List<PrescriptionDetail>();
        }

        public Nutraceutical(string name, string pharmacology, string actionMechanism, string indications, string againstIndications, string adverseReactions, string drugInteractions, 
            string descriptionDosages, string recomendedDosages, string nutraceuticalReferences, NutraceuticalType nutraceuticalType, int minDosage, int maxDosage, string unity, bool medicalonly, string commonName)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.CommonName = (string.IsNullOrEmpty(commonName) ? name : commonName);
            this.Pharmacology = pharmacology;
            this.ActionMechanism = actionMechanism;
            this.Indications = indications;
            this.AgainstIndications = againstIndications;
            this.AdverseReactions = adverseReactions;
            this.DrugInteractions = drugInteractions;
            this.DescriptionDosages = descriptionDosages;
            this.RecomendedDosages = recomendedDosages;
            this.NutraceuticalReferences = nutraceuticalReferences;
            this.NutraceuticalType = nutraceuticalType;
            this.MinDosage = minDosage;
            this.MaxDosage = maxDosage;
            this.Unity = unity;
            this.MedicalOnly = medicalonly;

            this.Active = true;
            this.Verified = true;

            this.LastUpdate = DateTime.Now;

        }

        public Nutraceutical(Guid id, string name, string pharmacology, string actionMechanism, string indications, string againstIndications, string adverseReactions, string drugInteractions,
            string descriptionDosages, string recomendedDosages, string nutraceuticalReferences, NutraceuticalType nutraceuticalType, int minDosage, int maxDosage, string unity, bool medicalonly, string commonName)
        {
            this.Id = id;
            this.Name = name;
            this.CommonName = (string.IsNullOrEmpty(commonName) ? name : commonName);
            this.Pharmacology = pharmacology;
            this.ActionMechanism = actionMechanism;
            this.Indications = indications;
            this.AgainstIndications = againstIndications;
            this.AdverseReactions = adverseReactions;
            this.DrugInteractions = drugInteractions;
            this.DescriptionDosages = descriptionDosages;
            this.RecomendedDosages = recomendedDosages;
            this.NutraceuticalReferences = nutraceuticalReferences;
            this.NutraceuticalType = nutraceuticalType;
            this.MinDosage = minDosage;
            this.MaxDosage = maxDosage;
            this.Unity = unity;
            this.MedicalOnly = medicalonly;


            this.Active = true;
            this.Verified = true;

            this.LastUpdate = DateTime.Now;

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
        public int MinDosage { get; set; }
        public int MaxDosage { get; set; }
        public string Unity { get; set; } //mg /mcg
        public string NutraceuticalReferences { get; private set; }
        public bool MedicalOnly { get; private set; }
        public NutraceuticalType NutraceuticalType { get; private set; }
        public bool Verified { get; private set; }
        public bool Active { get; private set; }
        public DateTime LastUpdate { get; private set; }

        [NotMapped]
        public string NutraceuticalDescriptionType
        {
            get
            {
                return SharedFunctions.GetEnumDescription(this.NutraceuticalType);
            }
        }

        [NotMapped]
        public string HasOk
        {
            get
            {
                if (!string.IsNullOrEmpty(this.Pharmacology.Trim()) && !string.IsNullOrEmpty(this.NutraceuticalReferences.Trim()) 
                    && !string.IsNullOrEmpty(this.Indications.Trim()) && !string.IsNullOrEmpty(this.Unity.Trim()) && this.MinDosage > 0 && this.MaxDosage > 0)
                    return "Concluído";
                else
                    return "Incompleto";
            }
        }

        public virtual ICollection<PrescriptionDetail> PrescriptionDetails { get; private set; }
    }
}

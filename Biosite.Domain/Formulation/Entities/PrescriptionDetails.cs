using Biosite.Domain.Problem.Entities;
using Biosite.Domain.Substance.Entities;
using System;
using System.Collections.Generic;

namespace Biosite.Domain.Formulation.Entities
{
    public class PrescriptionDetail
    {

        public PrescriptionDetail()
        {

        }

        public PrescriptionDetail(string dosage, int group, string posology, string information, string note, Guid prescriptionId, Guid nutraceuticalId)
        {
            this.Id = Guid.NewGuid();
            this.Dosage = dosage;
            this.Group = group;
            this.Posology = posology;
            this.Information = information;
            this.Note = note;

            this.Active = true;
            this.Verified = true;

            this.LastUpdate = DateTime.Now;

            this.PrescriptionId = prescriptionId;
            this.NutraceuticalId = nutraceuticalId;
        }

        public PrescriptionDetail(Guid id, string dosage, int group, string posology, string information, string note, Guid prescriptionId, Guid nutraceuticalId)
        {
            this.Id = id;
            this.Dosage = dosage;
            this.Group = group;
            this.Posology = posology;
            this.Information = information;
            this.Note = note;

            this.Active = false;
            this.Verified = false;

            this.LastUpdate = DateTime.Now;

            this.PrescriptionId = prescriptionId;
            this.NutraceuticalId = nutraceuticalId;
        }

        public Guid Id { get; private set; }
        public string Dosage { get; private set; }
        public int Group { get; private set; }
        public string Posology { get; private set; }
        public string Information { get; private set; }
        public string Note { get; private set; }
        public bool Verified { get; private set; }
        public bool Active { get; private set; }
        public DateTime LastUpdate { get; private set; }

        public Guid PrescriptionId { get; private set; }
        public virtual Prescription Prescription { get; private set; }

        public Guid NutraceuticalId { get; private set; }
        public virtual Nutraceutical Nutraceutical { get; private set; }
    }
}

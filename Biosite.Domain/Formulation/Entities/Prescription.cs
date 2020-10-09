using Biosite.Domain.Problem.Entities;
using Biosite.Domain.Substance.Entities;
using System;
using System.Collections.Generic;

namespace Biosite.Domain.Formulation.Entities
{
    public class Prescription
    {

        public Prescription()
        {
            this.PrescriptionDetails = new List<PrescriptionDetail>();
            this.DiseasePrescription = new List<DiseasePrescription>();
        }

        public Prescription(string name, string description)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.Description = description;

            this.Active = true;
            this.Verified = true;
            this.LastUpdate = DateTime.Now;
        }

        public Prescription(Guid id, string name, string description)
        {
            this.Id = id;
            this.Name = name;
            this.Description = description;

            this.Active = true;
            this.Verified = true;
            this.LastUpdate = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public bool Verified { get; private set; }
        public bool Active { get; private set; }
        public DateTime LastUpdate { get; private set; }

        public virtual ICollection<PrescriptionDetail> PrescriptionDetails { get; private set; }

        //APAGAR SE DER ERRO
        public virtual ICollection<DiseasePrescription> DiseasePrescription { get; private set; }
    }
}

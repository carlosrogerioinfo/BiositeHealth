using Biosite.Domain.Formulation.Entities;
using System;
using System.Collections.Generic;

namespace Biosite.Domain.Problem.Entities
{
    public class DiseasePrescription
    {

        public DiseasePrescription()
        {
            
        }

        public DiseasePrescription(Guid diseaseId, Guid prescriptionId)
        {
            this.Id = Guid.NewGuid();
            this.DiseaseId = diseaseId;
            this.PrescriptionId = prescriptionId;
        }

        public DiseasePrescription(Guid id, Guid diseaseId, Guid prescriptionId)
        {
            this.Id = id;
            this.DiseaseId = diseaseId;
            this.PrescriptionId = prescriptionId;
        }

        public Guid Id { get; private set; }


        public Guid DiseaseId { get; private set; }
        public virtual Disease Disease { get; private set; }

        public Guid PrescriptionId { get; private set; }
        public virtual Prescription Prescription { get; private set; }

    }
}

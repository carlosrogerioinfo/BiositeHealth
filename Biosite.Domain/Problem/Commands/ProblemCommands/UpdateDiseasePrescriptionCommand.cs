using System;

namespace Biosite.Domain.Problem.Commands.ProblemCommands
{
    public class UpdateDiseasePrescriptionCommand
    {
        public UpdateDiseasePrescriptionCommand(Guid id, Guid diseaseId, Guid prescriptionId)
        {
            this.Id = id;
            this.DiseaseId = diseaseId;
            this.PrescriptionId = prescriptionId;
        }

        public Guid Id { get; private set; }
        public Guid DiseaseId { get; private set; }
        public Guid PrescriptionId { get; private set; }

    }
}

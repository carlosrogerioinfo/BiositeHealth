using System;

namespace Biosite.Domain.Problem.Commands.ProblemCommands
{
    public class RegisterDiseasePrescriptionCommand
    {
        public RegisterDiseasePrescriptionCommand(Guid diseaseId, Guid prescriptionId)
        {
            this.DiseaseId = diseaseId;
            this.PrescriptionId = prescriptionId;
        }

        public Guid DiseaseId { get; private set; }
        public Guid PrescriptionId { get; private set; }

    }
}

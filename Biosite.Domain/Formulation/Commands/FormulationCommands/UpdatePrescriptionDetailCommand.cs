using System;

namespace Biosite.Domain.Formulation.Commands.FormulationCommands
{
    public class UpdatePrescriptionDetailCommand
    {
        public UpdatePrescriptionDetailCommand(Guid id, string dosage, int group, string posology, string information, string note, Guid prescriptionId, Guid nutraceuticalId)
        {
            Id = id;
            Dosage = dosage;
            Group = group;
            Posology = posology;
            Information = information;
            Note = note;
            PrescriptionId = prescriptionId;
            NutraceuticalId = nutraceuticalId;
        }

        public Guid Id { get; set; }
        public string Dosage { get; private set; }
        public string Posology { get; private set; }
        public string Information { get; private set; }
        public string Note { get; private set; }
        public int Group { get; private set; }
        public Guid PrescriptionId { get; private set; }
        public Guid NutraceuticalId { get; private set; }
    }
}

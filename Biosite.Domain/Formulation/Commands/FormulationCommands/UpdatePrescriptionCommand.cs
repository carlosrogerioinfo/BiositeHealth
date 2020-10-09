using System;

namespace Biosite.Domain.Formulation.Commands.FormulationCommands
{
    public class UpdatePrescriptionCommand
    {
        public UpdatePrescriptionCommand(Guid id, string name, string description)
        {
            Id = id;
            Name = name;
            Description = description;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
    }
}

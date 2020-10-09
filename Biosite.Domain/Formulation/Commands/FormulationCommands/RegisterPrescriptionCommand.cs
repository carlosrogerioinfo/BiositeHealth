using System;

namespace Biosite.Domain.Formulation.Commands.FormulationCommands
{
    public class RegisterPrescriptionCommand
    {
        public RegisterPrescriptionCommand(string name, string description)
        {
            Name = name;
            Description = description;
        }

        public string Name { get; private set; }
        public string Description { get; private set; }

    }
}

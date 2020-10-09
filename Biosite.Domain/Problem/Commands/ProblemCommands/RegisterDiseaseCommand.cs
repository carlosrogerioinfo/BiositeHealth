using System;

namespace Biosite.Domain.Problem.Commands.ProblemCommands
{
    public class RegisterDiseaseCommand
    {
        public RegisterDiseaseCommand(string name, string cid, string description)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.CID = cid;
            this.Description = description;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string CID { get; private set; }

    }
}

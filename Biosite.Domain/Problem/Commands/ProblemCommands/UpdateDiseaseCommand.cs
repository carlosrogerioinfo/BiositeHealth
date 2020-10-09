using System;

namespace Biosite.Domain.Problem.Commands.ProblemCommands
{
    public class UpdateDiseaseCommand
    {
        public UpdateDiseaseCommand(Guid id, string name, string cid, string description)
        {
            this.Id = id;
            this.Name = name.Trim();
            this.CID = cid.Trim();
            this.Description = description;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string CID { get; private set; }

    }
}

using Biosite.Domain.Formulation.Entities;
using System;
using System.Collections.Generic;

namespace Biosite.Domain.Problem.Entities
{
    public class Disease
    {

        public Disease()
        {
            this.DiseasePrescription = new List<DiseasePrescription>();
        }

        public Disease(string name, string cid, string description)
        {
            this.Id = Guid.NewGuid();
            this.Name = name;
            this.CID = (!string.IsNullOrEmpty(cid.Trim()) ? cid.Trim().ToUpper() : string.Concat("CID", Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(1, 5)).ToUpper());
            this.Description = description;

            this.Active = true;
            this.Verified = true;
            this.LastUpdate = DateTime.Now;
        }

        public Disease(Guid id, string name, string cid, string description)
        {
            this.Id = id;
            this.Name = name;
            this.CID = (!string.IsNullOrEmpty(cid.Trim()) ? cid.Trim().ToUpper() : string.Concat("CID", Guid.NewGuid().ToString().Replace("-", string.Empty).Substring(1, 5)).ToUpper());
            this.Description = description;

            this.Active = true;
            this.Verified = true;
            this.LastUpdate = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public string Name { get; private set; }
        public string Description { get; private set; }
        public string CID { get; private set; }
        public bool Verified { get; private set; }
        public bool Active { get; private set; }
        public DateTime LastUpdate { get; private set; }

        //Relationship
        public virtual ICollection<DiseasePrescription> DiseasePrescription { get; private set; }

    }
}

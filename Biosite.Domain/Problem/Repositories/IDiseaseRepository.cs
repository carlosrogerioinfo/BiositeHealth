using Biosite.Domain.Problem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosite.Domain.Problem.Repositories
{
    public interface IDiseaseRepository
    {
        void Save(Disease disease);
        void SaveDiseasePrescription(DiseasePrescription disease);
        void Update(Disease disease);
        void UpdateDiseasePrescription(DiseasePrescription diseasePrescription);
        Disease GetById(Guid id);
        Disease GetByCID(string cid);
        Disease GetByName(string name);
        ICollection<Disease> GetAll();
        ICollection<DiseasePrescription> GetAllDiseasePrescription();
        DiseasePrescription GetDiseasePrescriptionById(Guid id);
    }
}

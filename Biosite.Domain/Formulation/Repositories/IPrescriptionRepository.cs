using Biosite.Domain.Formulation.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosite.Domain.Formulation.Repositories
{
    public interface IPrescriptionRepository
    {
        void Save(Prescription prescription);
        void Update(Prescription prescription);
        Prescription GetById(Guid id);
        Prescription GetByDescription(string description);
        ICollection<Prescription> GetAll();
        ICollection<PrescriptionDetail> GetAllPrescriptionDetails();
        //PrescriptionDetail GetPrescriptionDetailById(Guid id);
        ICollection<PrescriptionDetail> GetPrescriptionDetailById(Guid id);
        void SavePrescriptionDetail(PrescriptionDetail prescriptionDetail);
        void UpdatePrescriptionDetail(PrescriptionDetail prescriptionDetail);

    }
}

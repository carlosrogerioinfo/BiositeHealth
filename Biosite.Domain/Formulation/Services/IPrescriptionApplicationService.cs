using Biosite.Domain.Formulation.Entities;
using Biosite.Domain.Formulation.Commands.FormulationCommands;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosite.Domain.Formulation.Services
{
    public interface IPrescriptionApplicationService
    {
        Prescription Register(RegisterPrescriptionCommand command);
        Prescription Update(UpdatePrescriptionCommand command);
        Prescription GetPrescriptionById(Guid id);
        Prescription GetPrescriptionByDescription(string description);
        ICollection<Prescription> GetAllPrescriptions();
        ICollection<PrescriptionDetail> GetAllPrescriptionDetails();
        ICollection<PrescriptionDetail> GetPrescriptionDetailById(Guid id);
        PrescriptionDetail RegisterPrescriptionDetail(RegisterPrescriptionDetailCommand command);
        PrescriptionDetail UpdatePrescriptionDetail(UpdatePrescriptionDetailCommand command);

    }
}

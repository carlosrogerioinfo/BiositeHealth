using Biosite.Domain.Problem.Commands.ProblemCommands;
using Biosite.Domain.Problem.Entities;
using System;
using System.Collections.Generic;

namespace Biosite.Domain.Problem.Services
{
    public interface IDiseaseApplicationService
    {
        Disease Register(RegisterDiseaseCommand command);
        Disease Update(UpdateDiseaseCommand command);
        Disease GetDiseaseById(Guid id);
        Disease GetDiseaseByCID(string cid);
        ICollection<Disease> GetAllDiseases();
        ICollection<DiseasePrescription> GetAllDiseasePrescription();

        DiseasePrescription GetDiseasePrescriptionById(Guid id);
        DiseasePrescription RegisterDiseasePrescription(RegisterDiseasePrescriptionCommand command);
        DiseasePrescription UpdateDiseasePrescription(UpdateDiseasePrescriptionCommand command);
    }
}

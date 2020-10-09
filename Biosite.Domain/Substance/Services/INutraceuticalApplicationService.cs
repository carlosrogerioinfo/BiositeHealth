using Biosite.Domain.Substance.Commands.SubstanceCommands;
using Biosite.Domain.Substance.Entities;
using Biosite.Domain.Substance.Enums;
using System;
using System.Collections.Generic;

namespace Biosite.Domain.Substance.Services
{
    public interface INutraceuticalApplicationService
    {
        Nutraceutical Register(RegisterNutraceuticalCommand command);
        Nutraceutical Update (UpdateNutraceuticalCommand command);
        Nutraceutical GetNutraceuticalById(Guid id);
        Nutraceutical GetNutraceuticalByName(string name);
        ICollection<Nutraceutical> GetAllNutraceuticals();
        ICollection<Nutraceutical> GetNutraceuticalByNutraceuticalType(NutraceuticalType nutraceuticalType);
        ICollection<Nutraceutical> GetTenMostRecentsNutraceuticals();
    }
}
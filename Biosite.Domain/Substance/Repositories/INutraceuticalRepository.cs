using Biosite.Domain.Substance.Entities;
using Biosite.Domain.Substance.Enums;
using System;
using System.Collections.Generic;

namespace Biosite.Domain.Substance.Repositories
{
    public interface INutraceuticalRepository
    {
        void Save(Nutraceutical nutraceutical);
        void Update(Nutraceutical nutraceutical);
        Nutraceutical GetById(Guid id);
        Nutraceutical GetByName(string name);
        ICollection<Nutraceutical> GetAll();
        ICollection<Nutraceutical> GetByNutraceuticalType (NutraceuticalType nutraceuticalType);
        ICollection<Nutraceutical> GetTenMostRecentsNutraceuticals();
    }
}

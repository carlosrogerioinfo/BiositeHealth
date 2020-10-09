using Biosite.Domain.Substance.Entities;
using Biosite.Domain.Substance.Enums;
using System;
using System.Linq.Expressions;

namespace Biosite.Domain.Formulation.Specs
{
    public static class NutraceuticalSpecs
    {
        public static Expression<Func<Nutraceutical, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }

        public static Expression<Func<Nutraceutical, bool>> GetByName(string name)
        {
            return x => x.Name == name;
        }

        public static Expression<Func<Nutraceutical, bool>> GetByNutraceuticalType(NutraceuticalType nutraceuticalType)
        {
            return x => x.NutraceuticalType == nutraceuticalType;
        }

    }
}

using Biosite.Domain.Problem.Entities;
using System;
using System.Linq.Expressions;

namespace Biosite.Domain.Problem.Specs
{
    public static class DiseaseSpecs
    {
        public static Expression<Func<Disease, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }

        public static Expression<Func<Disease, bool>> GetByName(string name)
        {
            return x => x.Name == name;
        }

        public static Expression<Func<Disease, bool>> GetByCID(string cid)
        {
            return x => x.CID == cid;
        }
        public static Expression<Func<DiseasePrescription, bool>> GetDiseasePrescriptionById(Guid id)
        {
            return x => x.Id == id;
        }
    }
}

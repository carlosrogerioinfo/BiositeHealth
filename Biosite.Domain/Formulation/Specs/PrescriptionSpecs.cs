using Biosite.Domain.Account.Entities;
using Biosite.Domain.Formulation.Entities;
using System;
using System.Linq.Expressions;

namespace Biosite.Domain.Formulation.Specs
{
    public static class PrescriptionSpecs
    {
        public static Expression<Func<Prescription, bool>> GetById(Guid id)
        {
            return x => x.Id == id;
        }

        public static Expression<Func<Prescription, bool>> GetByDescription(string description)
        {
            return x => x.Description == description;
        }

        public static Expression<Func<Prescription, bool>> GetByName(string name)
        {
            return x => x.Name == name;
        }
        public static Expression<Func<PrescriptionDetail, bool>> GetPrescriptionDetailById(Guid id)
        {
            return x => x.PrescriptionId == id;
        }
    }
}

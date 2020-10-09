using Biosite.Domain.Formulation.Entities;
using Biosite.Domain.Formulation.Specs;
using Biosite.Domain.Substance.Entities;
using Biosite.Domain.Substance.Enums;
using Biosite.Domain.Substance.Repositories;
using Biosite.Infra.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Biosite.Infra.Repositories.Substance
{
    public class NutraceuticalRepository : INutraceuticalRepository
    {
        private readonly BiositeDataContext _context;

        public NutraceuticalRepository(BiositeDataContext context)
        {
            _context = context;
        }

        public void Save(Nutraceutical obj)
        {
            _context.Nutraceuticals.Add(obj);
        }

        public void Update(Nutraceutical obj)
        {
            //_context.Entry<Nutraceutical>(obj).State = System.Data.Entity.EntityState.Modified;
            _context.Set<Nutraceutical>().AddOrUpdate(obj);
        }

        public ICollection<Nutraceutical> GetAll()
        {
            return _context.Nutraceuticals.ToList();
        }

        public Nutraceutical GetById(Guid id)
        {
            return _context
                .Nutraceuticals
                .Where(NutraceuticalSpecs.GetById(id))
                .FirstOrDefault();
        }

        public Nutraceutical GetByName(string name)
        {
            return _context
                .Nutraceuticals
                .Where(NutraceuticalSpecs.GetByName(name))
                .FirstOrDefault();
        }

        public ICollection<Nutraceutical> GetByNutraceuticalType(NutraceuticalType nutraceuticalType)
        {
            return _context
                .Nutraceuticals
                .Where(NutraceuticalSpecs.GetByNutraceuticalType(nutraceuticalType)).ToList();
        }

        public ICollection<Nutraceutical> GetTenMostRecentsNutraceuticals()
        {
            return _context.Nutraceuticals
                .OrderByDescending(x => x.LastUpdate)
                .Take(10).ToList();
        }


    }
}

using Biosite.Domain.Formulation.Entities;
using Biosite.Domain.Formulation.Repositories;
using Biosite.Domain.Formulation.Specs;
using Biosite.Domain.Problem.Entities;
using Biosite.Domain.Problem.Repositories;
using Biosite.Domain.Problem.Specs;
using Biosite.Infra.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Biosite.Infra.Repositories.Problem
{
    public class DiseaseRepository : IDiseaseRepository
    {
        private readonly BiositeDataContext _context;

        public DiseaseRepository(BiositeDataContext context)
        {
            _context = context;
        }

        public void Save(Disease obj)
        {
            _context.Diseases.Add(obj);
        }

        public void SaveDiseasePrescription(DiseasePrescription obj)
        {
            _context.DiseasePrescriptions.Add(obj);
        }

        public void Update(Disease obj)
        {
            //_context.Entry<Disease>(obj).State = System.Data.Entity.EntityState.Modified;
            _context.Set<Disease>().AddOrUpdate(obj);
        }

        public void UpdateDiseasePrescription(DiseasePrescription obj)
        {
            //_context.Entry<Disease>(obj).State = System.Data.Entity.EntityState.Modified;
            _context.Set<DiseasePrescription>().AddOrUpdate(obj);
        }

        public ICollection<Disease> GetAll()
        {
            return _context.Diseases.ToList();
        }

        public Disease GetById(Guid id)
        {
            return _context
                .Diseases
                .Where(DiseaseSpecs.GetById(id))
                .FirstOrDefault();
        }

        public Disease GetByCID(string cid)
        {
            return _context
                .Diseases
                .Where(DiseaseSpecs.GetByCID(cid))
                .FirstOrDefault();
        }

        public Disease GetByName(string name)
        {
            return _context
                .Diseases
                .Where(DiseaseSpecs.GetByName(name))
                .FirstOrDefault();
        }

        public ICollection<DiseasePrescription> GetAllDiseasePrescription()
        {
            return _context.DiseasePrescriptions
                .Include("Disease")
                .Include("Prescription").ToList();
        }

        public DiseasePrescription GetDiseasePrescriptionById(Guid id)
        {
            return _context
                .DiseasePrescriptions
                .Where(DiseaseSpecs.GetDiseasePrescriptionById(id))
                .FirstOrDefault();
        }

    }
}

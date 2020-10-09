using Biosite.Domain.Formulation.Entities;
using Biosite.Domain.Formulation.Repositories;
using Biosite.Domain.Formulation.Specs;
using Biosite.Infra.Persistence.Contexts;
using System;
using System.Collections.Generic;
using System.Data.Entity.Migrations;
using System.Linq;

namespace Biosite.Infra.Repositories.Formulation
{
    public class PrescriptionRepository : IPrescriptionRepository
    {
        private readonly BiositeDataContext _context;

        public PrescriptionRepository(BiositeDataContext context)
        {
            _context = context;
        }

        public void Save(Prescription obj)
        {
            _context.Prescriptions.Add(obj);
        }

        public void Update(Prescription obj)
        {
            //_context.Entry<Prescription>(obj).State = System.Data.Entity.EntityState.Modified;
            _context.Set<Prescription>().AddOrUpdate(obj);
        }

        public ICollection<Prescription> GetAll()
        {
            return _context.Prescriptions.ToList();
        }

        public ICollection<PrescriptionDetail> GetAllPrescriptionDetails()
        {
            return _context.PrescriptionDetails.ToList();
        }

        public Prescription GetById(Guid id)
        {
            return _context
                .Prescriptions
                    .Include("PrescriptionDetails")
                    .Include("PrescriptionDetails.Nutraceutical")
                .Where(PrescriptionSpecs.GetById(id))
                .FirstOrDefault();

        }

        public ICollection<PrescriptionDetail> GetPrescriptionDetailById(Guid id)
        {
            return _context
                .PrescriptionDetails
                .Where(PrescriptionSpecs.GetPrescriptionDetailById(id))
                .ToList();

        }
        
        //#todo Ajustar
        public ICollection<Prescription> GetByDiseaseId(Guid diseaseId)
        {
            return _context
                .Prescriptions
                .Where(PrescriptionSpecs.GetById(diseaseId))
                .ToList();
        }

        public Prescription GetByDescription(string description)
        {
            return _context
                .Prescriptions
                .Where(PrescriptionSpecs.GetByDescription(description))
                .FirstOrDefault();
        }


        public void SavePrescriptionDetail(PrescriptionDetail obj)
        {
            _context.PrescriptionDetails.Add(obj);
        }

        public void UpdatePrescriptionDetail(PrescriptionDetail obj)
        {
            //_context.Entry<Prescription>(obj).State = System.Data.Entity.EntityState.Modified;
            _context.Set<PrescriptionDetail>().AddOrUpdate(obj);
        }


    }
}

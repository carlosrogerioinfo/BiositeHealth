using Biosite.Domain.Account.Entities;
using Biosite.Domain.ExamName.Entities;
using Biosite.Domain.Formulation.Entities;
using Biosite.Domain.Problem.Entities;
using Biosite.Domain.Substance.Entities;
using Biosite.Infra.Persistence.Mappings;
using System.Data.Entity;

namespace Biosite.Infra.Persistence.Contexts
{
    public class BiositeDataContext : DbContext
    {
        public BiositeDataContext() 
            : base("i7digital")
        {
            Configuration.LazyLoadingEnabled = false;
            Configuration.ProxyCreationEnabled = false;
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Prescription> Prescriptions { get; set; }
        public DbSet<PrescriptionDetail> PrescriptionDetails { get; set; }
        public DbSet<Disease> Diseases { get; set; }
        public DbSet<DiseasePrescription> DiseasePrescriptions { get; set; }
        public DbSet<Exam> Exams { get; set; }
        public DbSet<Nutraceutical> Nutraceuticals { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new UserMapping());

            modelBuilder.Configurations.Add(new PrescriptionMapping());
            modelBuilder.Configurations.Add(new PrescriptionDetailMapping());

            modelBuilder.Configurations.Add(new DiseaseMapping());
            modelBuilder.Configurations.Add(new DiseasePrescriptionMapping());

            modelBuilder.Configurations.Add(new NutraceuticalMapping());
        }
    }
}

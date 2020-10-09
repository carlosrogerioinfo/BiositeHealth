using Biosite.Domain.Formulation.Entities;
using Biosite.Domain.Problem.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace BiositeDashBoardWeb.ViewModel
{
    public class DiseasePrescriptionViewModel
    {
        public ICollection<Disease> Diseases { get; set; }
        public ICollection<Prescription> Prescriptions { get; set; }
    }
}
using Biosite.Domain.Account.Commands.UserCommands;
using Biosite.Domain.Account.Services;
using Biosite.Domain.Formulation.Services;
using Biosite.Domain.Formulation.Commands.FormulationCommands;
using Biosite.Domain.Problem.Commands.ProblemCommands;
using Biosite.Domain.Problem.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;
using Biosite.Domain.Substance.Services;
using Biosite.Domain.Substance.Enums;

namespace BiositeDashBoardWeb.Controllers
{
    public class DashboardController : BaseController
    {
        private readonly IUserApplicationService _serviceUser;
        private readonly IDiseaseApplicationService _serviceDisease;
        private readonly IPrescriptionApplicationService _servicePrescription;
        private readonly INutraceuticalApplicationService _serviceNutraceutical;

        public DashboardController(IUserApplicationService serviceUser, IDiseaseApplicationService serviceDisease, 
            IPrescriptionApplicationService servicePrescription, INutraceuticalApplicationService serviceNutraceutical)
            :base(serviceDisease, serviceNutraceutical, servicePrescription)
        {
            _serviceUser = serviceUser;
            _serviceDisease = serviceDisease;
            _servicePrescription = servicePrescription;
            _serviceNutraceutical = serviceNutraceutical;
        }

        //[Authorize]
        public ViewResult Index()
        {
            return View();

        }

    }
}
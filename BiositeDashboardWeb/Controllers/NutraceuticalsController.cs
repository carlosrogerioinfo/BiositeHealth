using Biosite.Domain.Account.Services;
using Biosite.Domain.Formulation.Services;
using Biosite.Domain.Problem.Services;
using Biosite.Domain.Substance.Commands.SubstanceCommands;
using Biosite.Domain.Substance.Entities;
using Biosite.Domain.Substance.Enums;
using Biosite.Domain.Substance.Services;
using System;
using System.Web;
using System.Web.Mvc;
using System.Linq;

namespace BiositeDashBoardWeb.Controllers
{
    public class NutraceuticalsController : BaseController
    {
        private readonly IDiseaseApplicationService _serviceDisease;
        private readonly INutraceuticalApplicationService _serviceNutraceutical;
        private readonly IPrescriptionApplicationService _servicePrescription;

        public NutraceuticalsController(IDiseaseApplicationService serviceDisease, INutraceuticalApplicationService serviceNutraceutical, 
            IPrescriptionApplicationService servicePrescription)
            :base(serviceDisease, serviceNutraceutical, servicePrescription)
        {
            _serviceNutraceutical = serviceNutraceutical;
            _serviceDisease = serviceDisease;
        }

        public ActionResult Information(string id)
        {
            var information = _serviceNutraceutical.GetNutraceuticalById(Guid.Parse(id));
            return View(information);
        }

        public ActionResult Index()
        {
            var listNutraceuticals =_serviceNutraceutical.GetAllNutraceuticals().OrderBy(x => x.Name).ToList();

            return View(listNutraceuticals);
        }

        public ActionResult Edit(string id)
        {
            var nutraceutical = _serviceNutraceutical.GetNutraceuticalById(Guid.Parse(id)); 
            return View(nutraceutical);
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormCollection collection)
        {
            try
            {
                NutraceuticalType nutraceuticalType;
                Enum.TryParse(collection["NutraceuticalType"], out nutraceuticalType);

                bool medicalOnly = Convert.ToBoolean(collection["MedicalOnly"].Split(',')[0]);

                var nutraceutical = new UpdateNutraceuticalCommand(Guid.Parse(collection["Id"]), collection["Name"], collection["Pharmacology"], collection["ActionMechanism"], 
                    collection["Indications"], collection["AgainstIndications"], collection["AdverseReactions"], collection["DrugInteractions"], collection["DescriptionDosages"], 
                    collection["RecomendedDosages"], collection["NutraceuticalReferences"], nutraceuticalType, Convert.ToInt16(collection["MinDosage"]), 
                    Convert.ToInt16(collection["MaxDosage"]), collection["Unity"], medicalOnly, collection["CommonName"]);

                _serviceNutraceutical.Update(nutraceutical);

                return RedirectToAction("Index");
            }
            catch (Exception msg)
            {
                var mensagemError = msg.Message;
                return View();
            }
        }

        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                NutraceuticalType nutraceuticalType;
                Enum.TryParse(collection["NutraceuticalType"], out nutraceuticalType);

                bool medicalOnly = Convert.ToBoolean(collection["MedicalOnly"].Split(',')[0]);

                var nutraceutical = new RegisterNutraceuticalCommand(collection["Name"], collection["Pharmacology"], collection["ActionMechanism"], collection["Indications"],
                    collection["AgainstIndications"], collection["AdverseReactions"], collection["DrugInteractions"], collection["DescriptionDosages"], collection["RecomendedDosages"],
                    collection["NutraceuticalReferences"], nutraceuticalType,
                    (!string.IsNullOrEmpty(collection["MinDosage"]) ? Convert.ToInt16(collection["MinDosage"]) : Convert.ToInt16("0")),
                    (!string.IsNullOrEmpty(collection["MaxDosage"]) ? Convert.ToInt16(collection["MaxDosage"]) : Convert.ToInt16("0")), 
                    collection["Unity"], medicalOnly, collection["CommonName"]);

                _serviceNutraceutical.Register(nutraceutical);

                return RedirectToAction("Index");
            }
            catch (Exception msg)
            {
                var mensagemError = msg.Message;
                return View();
            }
        }

    }
}
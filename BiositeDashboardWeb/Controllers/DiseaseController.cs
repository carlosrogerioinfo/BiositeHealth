using Biosite.Domain.Account.Services;
using Biosite.Domain.Formulation.Services;
using Biosite.Domain.Problem.Commands.ProblemCommands;
using Biosite.Domain.Problem.Services;
using Biosite.Domain.Substance.Commands.SubstanceCommands;
using Biosite.Domain.Substance.Entities;
using Biosite.Domain.Substance.Enums;
using Biosite.Domain.Substance.Services;
using BiositeDashBoardWeb.ViewModel;
using System;
using System.Web;
using System.Web.Mvc;

namespace BiositeDashBoardWeb.Controllers
{
    public class DiseaseController : BaseController
    {
        private readonly IDiseaseApplicationService _serviceDisease;
        private readonly INutraceuticalApplicationService _serviceNutraceutical;
        private readonly IPrescriptionApplicationService _servicePrescription;

        public DiseaseController(IDiseaseApplicationService serviceDisease, INutraceuticalApplicationService serviceNutraceutical, 
            IPrescriptionApplicationService servicePrescription)
            :base(serviceDisease, serviceNutraceutical, servicePrescription)
        {
            _serviceNutraceutical = serviceNutraceutical;
            _serviceDisease = serviceDisease;
            _servicePrescription = servicePrescription;
        }

        public ActionResult Index()
        {
            var listData =_serviceDisease.GetAllDiseases();

            return View(listData);
        }

        public ActionResult Edit(string id)
        {
            var data = _serviceDisease.GetDiseaseById(Guid.Parse(id)); 
            return View(data);
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormCollection collection)
        {
            try
            {
                var data = new UpdateDiseaseCommand(Guid.Parse(collection["Id"]), collection["Name"], collection["Cid"], collection["Description"]);

                _serviceDisease.Update(data);

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
                var data = new RegisterDiseaseCommand(collection["Name"], collection["Cid"], collection["Description"]);

                _serviceDisease.Register(data);

                return RedirectToAction("Index");
            }
            catch (Exception msg)
            {
                var mensagemError = msg.Message;
                return View();
            }
        }

        public ActionResult DiseasePrescriptionShow()
        {
            var listData = _serviceDisease.GetAllDiseasePrescription();

            return View(listData);
        }

        public ActionResult CreateDiseasePrescription()
        {
            var listDiseases = _serviceDisease.GetAllDiseases();
            var listPrescriptions = _servicePrescription.GetAllPrescriptions();

            ViewBag.Diseases = listDiseases;
            ViewBag.Prescriptions = listPrescriptions;

            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult CreateDiseasePrescription(FormCollection collection)
        {
            try
            {
                var data = new RegisterDiseasePrescriptionCommand(Guid.Parse(collection["DiseaseId"]), Guid.Parse(collection["PrescriptionId"]));

                _serviceDisease.RegisterDiseasePrescription(data);

                return RedirectToAction("DiseasePrescriptionShow");
            }
            catch (Exception msg)
            {
                var mensagemError = msg.Message;
                return View();
            }
        }

        public ActionResult EditDiseasePrescription(string id)
        {
            var listDiseases = _serviceDisease.GetAllDiseases();
            var listPrescriptions = _servicePrescription.GetAllPrescriptions();

            ViewBag.Diseases = listDiseases;
            ViewBag.Prescriptions = listPrescriptions;

            var data = _serviceDisease.GetDiseasePrescriptionById(Guid.Parse(id));
            return View(data);
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditDiseasePrescription(FormCollection collection)
        {
            try
            {
                var data = new UpdateDiseasePrescriptionCommand(Guid.Parse(collection["Id"]), Guid.Parse(collection["DiseaseId"]), Guid.Parse(collection["PrescriptionId"]));

                _serviceDisease.UpdateDiseasePrescription(data);

                return RedirectToAction("DiseasePrescriptionShow");
            }
            catch (Exception msg)
            {
                var mensagemError = msg.Message;
                return View();
            }
        }



    }
}
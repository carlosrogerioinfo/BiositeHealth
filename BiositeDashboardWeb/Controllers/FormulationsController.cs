using Biosite.Domain.Account.Services;
using Biosite.Domain.Formulation.Commands.FormulationCommands;
using Biosite.Domain.Formulation.Entities;
using Biosite.Domain.Formulation.Services;
using Biosite.Domain.Problem.Services;
using Biosite.Domain.Substance.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;

namespace BiositeDashBoardWeb.Controllers
{
    public class FormulationsController : BaseController
    {
        private readonly IUserApplicationService _serviceUser;
        private readonly IDiseaseApplicationService _serviceDisease;
        private readonly IPrescriptionApplicationService _servicePrescription;
        private readonly INutraceuticalApplicationService _serviceNutraceutical;

        public FormulationsController(IUserApplicationService serviceUser, IDiseaseApplicationService serviceDisease, 
            IPrescriptionApplicationService servicePrescription, INutraceuticalApplicationService serviceNutraceutical)
            :base(serviceDisease, serviceNutraceutical, servicePrescription)
        {
            _serviceUser = serviceUser;
            _serviceDisease = serviceDisease;
            _servicePrescription = servicePrescription;
            _serviceNutraceutical = serviceNutraceutical;
        }

        public ActionResult Index()
        {
            var listData = _servicePrescription.GetAllPrescriptions();

            return View(listData);
        }

        public ActionResult Edit(string id)
        {
            var data = _servicePrescription.GetPrescriptionById(Guid.Parse(id));
            return View(data);
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(FormCollection collection)
        {
            try
            {
                var data = new UpdatePrescriptionCommand(Guid.Parse(collection["Id"]), collection["Name"], collection["Description"]);

                _servicePrescription.Update(data);

                return RedirectToAction("Index");
            }
            catch (Exception msg)
            {
                var mensagemError = msg.Message;
                return View();
            }
        }

        public ActionResult Prescription(string id)
        {

            var prescriptionData = _servicePrescription.GetPrescriptionById(Guid.Parse(id));

            return View(prescriptionData);
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
                var prescription = new RegisterPrescriptionCommand(collection["Name"], collection["Description"]);
                _servicePrescription.Register(prescription);

                return RedirectToAction("Index");
            }
            catch (Exception msg)
            {
                var mensagemError = msg.Message;
                return View();
            }
        }


        /* Detalhes */
        public ActionResult PrescriptionDetail(string id)
        {

            var prescriptionData = _servicePrescription.GetPrescriptionDetailById(Guid.Parse(id)).OrderBy(x => x.Nutraceutical.Name).ToList();
            ViewBag.PrescriptionId = Guid.Parse(id);

            return View(prescriptionData);
        }
        public ActionResult CreatePrescriptionDetail(string id)
        {
            var listNutraceuticals = _serviceNutraceutical.GetAllNutraceuticals();
            ViewBag.Nutraceuticals = listNutraceuticals;
            ViewBag.PrescriptionId = id;

            return View();
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult CreatePrescriptionDetail(FormCollection collection)
        {
            try
            {
                var listNutraceuticals = _serviceNutraceutical.GetAllNutraceuticals();
                ViewBag.Nutraceuticals = listNutraceuticals;

                var prescription = new RegisterPrescriptionDetailCommand(collection["Dosage"], Convert.ToInt16(collection["Group"]), collection["Posology"], 
                    collection["Information"], collection["Note"], Guid.Parse(collection["PrescriptionId"]), Guid.Parse(collection["NutraceuticalId"]));

                _servicePrescription.RegisterPrescriptionDetail(prescription);

                return RedirectToAction("CreatePrescriptionDetail/" + collection["PrescriptionId"]);
            }
            catch (Exception msg)
            {
                var mensagemError = msg.Message;
                return View();
            }
        }

        public ActionResult EditPrescriptionDetail(string id)
        {
            var listNutraceuticals = _serviceNutraceutical.GetAllNutraceuticals();
            ViewBag.Nutraceuticals = listNutraceuticals;
            ViewBag.PrescriptionId = id;

            var data = _servicePrescription.GetPrescriptionDetailById(Guid.Parse(id));

            return View(data);
        }

        [HttpPost]
        [ValidateInput(false)]
        [ValidateAntiForgeryToken]
        public ActionResult EditPrescriptionDetail(FormCollection collection)
        {
            try
            {
                var listNutraceuticals = _serviceNutraceutical.GetAllNutraceuticals();
                ViewBag.Nutraceuticals = listNutraceuticals;

                var data = new UpdatePrescriptionDetailCommand(Guid.Parse(collection["Id"]), collection["Dosage"], Convert.ToInt16(collection["Group"]), collection["Posology"],
                    collection["Information"], collection["Note"], Guid.Parse(collection["PrescriptionId"]), Guid.Parse(collection["NutraceuticalId"]));

                _servicePrescription.UpdatePrescriptionDetail(data);

                return RedirectToAction("PrescriptionDetail/" + collection["PrescriptionId"]);
            }
            catch (Exception msg)
            {
                var mensagemError = msg.Message;
                return View();
            }
        }


    }
}
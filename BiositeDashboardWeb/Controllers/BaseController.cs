using Biosite.Domain.Formulation.Services;
using Biosite.Domain.Formulation.Specs;
using Biosite.Domain.Problem.Services;
using Biosite.Domain.Substance.Enums;
using Biosite.Domain.Substance.Services;
using System.Linq;
using System.Web.Mvc;

namespace BiositeDashBoardWeb.Controllers
{
    public class BaseController : Controller
    {
        private readonly INutraceuticalApplicationService _serviceNutraceutical;
        private readonly IDiseaseApplicationService _serviceDisease;
        private readonly IPrescriptionApplicationService _servicePrescription;

        public BaseController(IDiseaseApplicationService serviceDisease, INutraceuticalApplicationService serviceNutraceutical, IPrescriptionApplicationService servicePrescription)
        {
            _serviceNutraceutical = serviceNutraceutical;
            _serviceDisease = serviceDisease;
            _servicePrescription = servicePrescription;


            ViewBag.Header = "EGL-CRONUS-T2020";
            @ViewBag.MetaContent = "EGL-CRONUS-T2020";

            SumPrescriptions();
            PrepareMenu();
        }

        private void SumPrescriptions()
        {
            const int total = 1000;
            int sumPrescription = _servicePrescription.GetAllPrescriptionDetails()
                .Select(x => x.PrescriptionId).Distinct().ToList().Count;

            double percentDone = sumPrescription * 100;
            percentDone = percentDone / total;

            ViewBag.SumPrescription = sumPrescription;
            ViewBag.PrescriptionPercentDone = percentDone;
        }

        private void PrepareMenu()
        {
            const int total = 1000; //ENFERMIDADES
            ViewBag.DiseasesPrescriptionMenu = _serviceDisease.GetAllDiseasePrescription();

            //NUTRACEUTICOS
            ViewBag.AminoAcidMenu = _serviceNutraceutical.GetNutraceuticalByNutraceuticalType(NutraceuticalType.AminoAcids).OrderBy(x => x.Name).ToList();
            ViewBag.MineralsMenu = _serviceNutraceutical.GetNutraceuticalByNutraceuticalType(NutraceuticalType.Minerals).OrderBy(x => x.Name).ToList();;
            ViewBag.NutraceuticsMenu = _serviceNutraceutical.GetNutraceuticalByNutraceuticalType(NutraceuticalType.Nutraceutics).OrderBy(x => x.Name).ToList(); ;
            ViewBag.NutriCosmeticsMenu = _serviceNutraceutical.GetNutraceuticalByNutraceuticalType(NutraceuticalType.NutriCosmetics).OrderBy(x => x.Name).ToList(); ;
            ViewBag.PhytotherapiesMenu = _serviceNutraceutical.GetNutraceuticalByNutraceuticalType(NutraceuticalType.Phytotherapies).OrderBy(x => x.Name).ToList(); ;
            ViewBag.VitaminsMenu = _serviceNutraceutical.GetNutraceuticalByNutraceuticalType(NutraceuticalType.Vitamins).OrderBy(x => x.Name).ToList(); ;
            ViewBag.FattyAcidsMenu = _serviceNutraceutical.GetNutraceuticalByNutraceuticalType(NutraceuticalType.FattyAcids).OrderBy(x => x.Name).ToList(); ;
            ViewBag.ProbioticsMenu = _serviceNutraceutical.GetNutraceuticalByNutraceuticalType(NutraceuticalType.Probiotics).OrderBy(x => x.Name).ToList(); ;

            double percentDone = (_serviceNutraceutical.GetAllNutraceuticals().Count * 100) / total;
            ViewBag.NutraceuticalsPercentDone = percentDone;
        }

    }
}
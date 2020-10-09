using Biosite.SharedKernel.Library;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosite.Domain
{
    public class Draft
    {

        public Draft()
        {

        }

        public Draft(int examCode, string examName, string examUnit, decimal biologicalValue, decimal referenceMinValue, decimal referenceMaxValue, decimal patientResult, bool useQuartil = false)
        {
            this.Id = Guid.NewGuid();
            this.ExamCode = examCode;
            this.ExamName = examName;
            this.ExamUnit = ExamUnit;
            this.BiologicalValue = biologicalValue;
            this.ReferenceMinValue = ReferenceMinValue;
            this.ReferenceMaxValue = referenceMaxValue;
            this.PatientResult = patientResult;
            this.UseQuartil = useQuartil;
            this.LastUpdate = DateTime.Now;
        }

        public Guid Id { get; private set; }
        public int ExamCode { get; private set; }
        public string ExamName { get; private set; }
        public string ExamUnit { get; private set; }
        public decimal BiologicalValue { get; private set; }
        public decimal ReferenceMinValue { get; private set; }
        public decimal ReferenceMaxValue { get; private set; }
        public decimal PatientResult { get; private set; }
        public bool UseQuartil { get; private set; }
        public DateTime LastUpdate { get; private set; }

        public ICollection<decimal[]> Quartils
        {
            get
            {
                return SharedFunctions.SetQuartil(this.ReferenceMinValue, this.ReferenceMaxValue);
            }
        }
        public int QuartilResult
        {
            get
            {
                return SharedFunctions.GetQuartil(PatientResult, Quartils);
            }
        }


    }
}

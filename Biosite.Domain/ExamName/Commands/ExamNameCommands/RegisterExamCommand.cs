using System;

namespace Biosite.Domain.ExamName.Commands.ExamNameCommands
{
    public class RegisterExamCommand
    {
        public RegisterExamCommand(int examCode, string examName, string examUnit, decimal biologicalValue, decimal referenceMinValue, decimal referenceMaxValue, bool useQuartil)
        {
            ExamCode = examCode;
            ExamName = examName;
            ExamUnit = ExamUnit;
            BiologicalValue = biologicalValue;
            ReferenceMinValue = ReferenceMinValue;
            ReferenceMaxValue = referenceMaxValue;
            UseQuartil = useQuartil;
        }

        public int ExamCode { get; private set; }
        public string ExamName { get; private set; }
        public string ExamUnit { get; private set; }
        public decimal BiologicalValue { get; private set; }
        public decimal ReferenceMinValue { get; private set; }
        public decimal ReferenceMaxValue { get; private set; }
        public bool UseQuartil { get; private set; }

    }
}

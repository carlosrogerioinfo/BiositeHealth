using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Biosite.Domain;
using Biosite.SharedKernel.Library;


namespace ConsoleApplicationTest
{
    public class Program
    {
        static void Main(string[] args)
        {
            Draft draft = new Draft();

            var x = SharedFunctions.SetQuartil(10, 100);

            ///SharedFunctions.CheckRange(Convert.ToInt16(draft.Quartils), 50, draft.ReferenceMinValue, draft.ReferenceMaxValue);


            var quart = SharedFunctions.GetQuartil(50, x);

            Console.WriteLine(draft.Quartils.ToList()[1][0] + " " + draft.Quartils.ToList()[1][1]);
            Console.ReadKey();

        }



    }
}

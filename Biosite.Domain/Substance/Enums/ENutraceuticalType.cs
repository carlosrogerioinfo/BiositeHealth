using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Biosite.Domain.Substance.Enums
{
    public enum NutraceuticalType
    {
        [Description("Não definido")]
        Undefined = 0,

        [Description("Aminoácidos")]
        AminoAcids = 1,

        [Description("Vitaminas")]
        Vitamins = 2,

        [Description("Minerais")]
        Minerals = 3,

        [Description("Fitoterapicos")]
        Phytotherapies = 4,

        [Description("Nutricosméticos")]
        NutriCosmetics = 5,

        [Description("Nutracéuticos")]
        Nutraceutics = 6,

        [Description("Ácidos Graxos")]
        FattyAcids = 7,

        [Description("Probióticos")]
        Probiotics = 8,

        [Description("Nootrópicos")]
        Nootropics = 9
    }

}
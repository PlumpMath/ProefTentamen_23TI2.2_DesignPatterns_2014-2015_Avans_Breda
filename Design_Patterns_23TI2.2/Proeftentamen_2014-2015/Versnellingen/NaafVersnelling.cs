using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeftentamen_2014_2015.Versnellingen
{
    public class NaafVersnelling : Versnelling
    {
        private static readonly int aantalVersnellingenInNaaf = 3;
        public NaafVersnelling()
            : base(aantalVersnellingenInNaaf)
        {
            huidigeVersnelling = 2;
        }
        public override void Op()
        {
            base.Op();
            Console.WriteLine("NaafVersnelling: schakel op --> versnelling {0}", huidigeVersnelling);
        }
        public override void Neer()
        {
            base.Neer();
            Console.WriteLine("NaafVersnelling: schakel neer --> versnelling {0}", huidigeVersnelling);
        }
    }
}

using Proeftentamen_2014_2015.Fietsen;
using Proeftentamen_2014_2015.Versnellingen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeftentamen_2014_2015.Fietsenmakers
{
    public class TestFietsenmaker
    {
        public static void TestFietsenmakers()
        {
            Console.WriteLine("\n--- Test FijnKlijn vouwfietsenbouwers ---");
            Fiets vouwfiets = FijnKlijnFietsenmaker.Fietsenmaker.BouwFiets();
            TestAllVersnellingen(vouwfiets.Versnelling);

            Console.WriteLine("\n--- Test SuperStoer all terrain bike bouwers ---");
            Fiets atb = SuperStoerFietsenmaker.Fietsenmaker.BouwFiets();
            TestAllVersnellingen(atb.Versnelling);
        }
        private static void TestAllVersnellingen(IVersnelling versnelling)
        {
            while (!versnelling.IsHoogsteVersnelling()) { versnelling.Op(); }
            while (!versnelling.IsLaagsteVersnelling()) { versnelling.Neer(); }
        }
    }
}

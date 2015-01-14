using Proeftentamen_2014_2015.Fietsen;
using Proeftentamen_2014_2015.Versnellingen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeftentamen_2014_2015.Fietsenmakers
{
    public class FijnKlijnFietsenmaker : Fietsenmaker
    {
        private static FijnKlijnFietsenmaker fm = null;
        public static Fietsenmaker Fietsenmaker
        {
            get
            {
                if (fm == null)
                { fm = new FijnKlijnFietsenmaker(); }
                return fm;
            }
        }
        private FijnKlijnFietsenmaker() { }
        protected override Fiets BouwFietsFrame()
        {
            Console.WriteLine("FijnKlijn: bouw een vouwfiets");
            Fiets fiets = new VouwFiets();
            return fiets;
        }
        protected override int SelecteerWielmaat()
        {
            return 16;
        }
        public override IVersnelling SelecteerVersnelling()
        {
            NaafVersnelling naafversnelling = new NaafVersnelling();
            Console.WriteLine("FijnKlijn: selecteer een naafversnelling met {0} versnellingen", naafversnelling.AantalVersnellingen);
            return naafversnelling;
        }
    }
}

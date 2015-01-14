using Proeftentamen_2014_2015.Fietsen;
using Proeftentamen_2014_2015.Versnellingen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeftentamen_2014_2015.Fietsenmakers
{
    public class HetStalenStadsrosFietsenmaker : Fietsenmaker
    {
        private static HetStalenStadsrosFietsenmaker fm = null;
        public static HetStalenStadsrosFietsenmaker Fietsenmaker
        {
            get
            {
                if (fm == null)
                { fm = new HetStalenStadsrosFietsenmaker(); }
                return fm;
            }
        }
        private HetStalenStadsrosFietsenmaker() { }
        protected override Fiets BouwFietsFrame()
        {
            Fiets fiets = new Fiets();
            Console.WriteLine("Het Stalen Stadsrod: bouw een stadsfiets");
            return fiets;
        }
        protected override int SelecteerWielmaat()
        {
            return 24;
        }
        public override IVersnelling SelecteerVersnelling()
        {
            GeenVersnelling versnelling = new GeenVersnelling();
            Console.WriteLine("Het Stalen Stadsrod: selecteer een geen versnelling met {0} versnelling" + (versnelling.AantalVersnellingen > 1 ? "en" : ""), versnelling.AantalVersnellingen);
            return versnelling;
        }
    }
}

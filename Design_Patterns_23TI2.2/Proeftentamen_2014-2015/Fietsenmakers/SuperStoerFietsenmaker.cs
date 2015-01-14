using Proeftentamen_2014_2015.Fietsen;
using Proeftentamen_2014_2015.Versnellingen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeftentamen_2014_2015.Fietsenmakers
{
    public class SuperStoerFietsenmaker : Fietsenmaker
    {
        private static SuperStoerFietsenmaker fm = null;
        public static Fietsenmaker Fietsenmaker
        {
            get
            {
                if (fm == null)
                { fm = new SuperStoerFietsenmaker(); }
                return fm;
            }
        }
        private SuperStoerFietsenmaker() { }
        protected override Fietsen.Fiets BouwFietsFrame()
        {
            Fiets fiets = new AllTerrainBike();
            Console.WriteLine("SuperStoer: bouw een all terrain bike frame");
            return fiets;
        }
        public override Versnellingen.IVersnelling SelecteerVersnelling()
        {
            Versnelling derailleur = new Derailler(21);
            Console.WriteLine("SuperStoer: selecteer een derailleur met {0} versnellingen", derailleur.AantalVersnellingen);
            return derailleur;
        }
    }
}

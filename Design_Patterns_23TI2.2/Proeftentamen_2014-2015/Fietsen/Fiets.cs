using Proeftentamen_2014_2015.Versnellingen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeftentamen_2014_2015.Fietsen
{
    public class Fiets
    {
        private IVersnelling versnelling;
        private int wielmaat;
        public IVersnelling Versnelling { get { return versnelling; } }
        public void MonteerWielen(int wielmaat)
        {
            this.wielmaat = wielmaat;
            Console.WriteLine("Fiets: monteer wielen van {0} inch", wielmaat);
        }
        public void MonteerVersnelling(IVersnelling versnelling)
        {
            this.versnelling = versnelling;
            Console.WriteLine("Fiets: monteer versnelling");
        }
    }
}

using Proeftentamen_2014_2015.Fietsen;
using Proeftentamen_2014_2015.Versnellingen;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeftentamen_2014_2015.Fietsenmakers
{
    public abstract class Fietsenmaker
    {
        public Fiets BouwFiets()
        {
            Fiets fiets = BouwFietsFrame();
            fiets.MonteerWielen(SelecteerWielmaat());
            fiets.MonteerVersnelling(SelecteerVersnelling());
            return fiets;
        }
        protected abstract Fiets BouwFietsFrame();
        protected virtual int SelecteerWielmaat() { return 26; }
        public abstract IVersnelling SelecteerVersnelling();
    }
}

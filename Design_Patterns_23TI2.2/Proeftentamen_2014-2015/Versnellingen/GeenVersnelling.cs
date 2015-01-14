using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeftentamen_2014_2015.Versnellingen
{
    public class GeenVersnelling : Versnelling
    {
        public GeenVersnelling():base(1)
        {
            huidigeVersnelling = 1;
        }
        public override void Op()
        {
            base.Op();
            Console.WriteLine("Geen Versnelling: schakel op --> versnelling {0}", huidigeVersnelling);
        }
        public override void Neer()
        {
            base.Neer();
            Console.WriteLine("Geen Versnelling: schakel op --> versnelling {0}", huidigeVersnelling);
        }
    }
}

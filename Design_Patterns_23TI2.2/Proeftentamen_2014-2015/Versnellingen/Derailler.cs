using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeftentamen_2014_2015.Versnellingen
{
    public class Derailler : Versnelling
    {
        public Derailler(int aantalVersnellingen)
            : base(aantalVersnellingen)
        {
            this.huidigeVersnelling = aantalVersnellingen / 2;
            if (this.huidigeVersnelling < 1)
            { this.huidigeVersnelling = 1; }
        }
        public override void Op()
        {
            base.Op();
            Console.WriteLine("Derailler: schakel op --> versnelling {0}", huidigeVersnelling);
        }
        public override void Neer()
        {
            base.Neer();
            Console.WriteLine("Derailer: schakel neer --> versnelling {0}", huidigeVersnelling);
        }
    }
}

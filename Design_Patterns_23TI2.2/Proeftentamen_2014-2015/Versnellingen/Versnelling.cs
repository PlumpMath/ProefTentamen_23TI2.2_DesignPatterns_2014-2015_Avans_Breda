using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeftentamen_2014_2015.Versnellingen
{
    public abstract class Versnelling : IVersnelling
    {
        protected readonly int aantalVersnellingen;
        protected int huidigeVersnelling;
        public Versnelling(int aantalVersnellingen)
        {
            this.aantalVersnellingen = aantalVersnellingen;
            this.huidigeVersnelling = 1;
        }
        public int AantalVersnellingen
        {
            get { return aantalVersnellingen; }
        }
        public int HuidigeVersnelling
        {
            get { return huidigeVersnelling; }
        }
        public bool IsHoogsteVersnelling()
        {
            return huidigeVersnelling == aantalVersnellingen;
        }
        public bool IsLaagsteVersnelling()
        {
            return huidigeVersnelling == 1;
        }
        public virtual void Op()
        {
            if (huidigeVersnelling < aantalVersnellingen)
            { huidigeVersnelling += 1; }
        }
        public virtual void Neer()
        {
            if (huidigeVersnelling > 1)
            { huidigeVersnelling -= 1; }
        }
    }
}

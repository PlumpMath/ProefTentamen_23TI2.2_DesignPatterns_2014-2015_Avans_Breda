﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proeftentamen_2014_2015.Versnellingen
{
    public interface IVersnelling
    {
        void Op();
        void Neer();
        int HuidigeVersnelling { get; }
        bool IsHoogsteVersnelling();
        bool IsLaagsteVersnelling();
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTi_Beaujean_AllumerLampePoo
{
    internal class Interrupteur
    {
        private int _code;
        private Lampe _lampeLier;

        public int Code { get => _code; }
        public Lampe LampeLier { get => _lampeLier; set => _lampeLier = value; }

        public Interrupteur(int code, Lampe lampeLier)
        {
            _code = code;
            _lampeLier = lampeLier;
        }
    }
}

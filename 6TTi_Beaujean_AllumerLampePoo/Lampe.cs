using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTi_Beaujean_AllumerLampePoo
{
    internal class Lampe
    {
        private int _code;
        private string _couleur;
        private bool _etat;

        public int Code { get => _code; }
        public string Couleur { get => _couleur; }
        public bool Etat { get => _etat; set => _etat = value; }

        public Lampe(int code, string couleur, bool etat)
        {
            _code = code;
            _couleur = couleur;
            _etat = etat;
        }

        public string EtatLampe()
        { return ("La lampe a le code " + _code + "La couleur est " + _couleur + " et son état est " + _etat);}
    }
}

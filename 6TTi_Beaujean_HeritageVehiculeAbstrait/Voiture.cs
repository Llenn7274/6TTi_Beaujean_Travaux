using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTi_Beaujean_HeritageVehicule
{
    internal class Voiture : Vehicule
    {
        private string _motorisation;

        private bool _gps;

        public Voiture(string modele, string marque, string couleur, decimal prix, string motorisation, bool gps) : base(modele, marque, couleur, prix)
        {
            _motorisation = motorisation;
            _gps = gps;
        }

        public override string Afficher()
        {
            return base.Afficher() + " Motorisation : " + _motorisation + " GPS : " + _gps;
        }
    }
}

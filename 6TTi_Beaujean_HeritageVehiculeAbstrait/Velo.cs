using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTi_Beaujean_HeritageVehicule
{
    internal class Velo: Vehicule
    {
        private string _type;

        private bool _estElectrique;

        public Velo(string modele, string marque, string couleur, decimal prix, string type, bool estElectrique) : base(modele, marque, couleur, prix)
        {
            _type = type;
            _estElectrique = estElectrique;
        }

        public override string Afficher()
        {
            return base.Afficher() + " Type : " + _type + " Est électrique : " + _estElectrique;
        }
    }
}

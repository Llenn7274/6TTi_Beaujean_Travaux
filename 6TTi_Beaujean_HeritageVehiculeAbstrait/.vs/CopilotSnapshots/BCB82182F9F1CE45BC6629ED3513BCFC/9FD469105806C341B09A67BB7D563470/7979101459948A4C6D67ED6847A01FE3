using System;
using System.Collections.Generic;
using System.Text;

namespace _6TTi_Beaujean_HeritageVehicule
{
    internal class Vehicule
    {
        protected string _modele;
        protected string _marque;
        protected string _couleur;
        protected decimal _prix;

        protected string Model { get => _modele; }
        protected string Marque { get => _marque; }
        protected string Couleur { get => _couleur; set => _couleur = value; }
        protected decimal Prix { get => _prix; set => _prix = value; }


        public Vehicule(string modele, string marque, string couleur, decimal prix)
        {
            _modele = modele;
            _marque = marque;
            _couleur = couleur;
            _prix = prix;
        }
        public virtual string Afficher()
        {
            return "Modèle : " + _modele + " Marque : " +_marque + " Couleur : " +_couleur +" Prix : " + _prix;
        }
    }
}

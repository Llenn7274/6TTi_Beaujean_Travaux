using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace GestionChien_BeaujeanNathan_6TTi
{
    public class Chien
    {
        private string _nom;
        private int _age;
        private string _race;
        private int _poids;

        public Chien(string nom, int age, string race, int poids)
        {
            _nom = nom;
            _age = age;
            _race = race;
            _poids = poids;
        }

        public void AfficheCaracteristiques()
        {
            Console.WriteLine("nom : " + _nom + "\n"+"age : " + _age  + "\n" + "race : " + _race + "\n" + "poids : " + _poids);
        }
    }
}

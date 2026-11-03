namespace exerciceFacileVehicule_Beaujean_6TTi
{
    internal class Vehicule
    {
        private string _plaque;
        private string _marque;
        private string _modele;
        private int _capaciteMaximumReservoir;
        private int _niveauJaugeCarburant;

        public Vehicule(string plaque, string marque, string modele, int capaciteMaximumReservoir, int niveauJaugeCarburant)
        {
            _plaque = plaque;
            _marque = marque;
            _modele = modele;
            _capaciteMaximumReservoir = capaciteMaximumReservoir;
            _niveauJaugeCarburant = niveauJaugeCarburant;
        }

        public string Plaque
        {
            get { return _plaque; }
            set { _plaque = value; }
        }

        public string Marque
        {
            get { return _marque; }
        }

        public string Modele
        {
            get { return _modele; }
        }

        public int CapaciteMaximumReservoir
        {
            get { return _capaciteMaximumReservoir; }
        }

        public int NiveauJaugeCarburant
        {
            get { return _niveauJaugeCarburant; }
        }

        public string TypeVehicule()
        {
            return _marque + " " + _modele;
        }

        public void AjouterCarburant(double nbrCarburant)
        {
            _niveauJaugeCarburant += (int)nbrCarburant;

            if (_niveauJaugeCarburant > _capaciteMaximumReservoir)
            {
                _niveauJaugeCarburant = _capaciteMaximumReservoir;
            }
        }

        public void FaireLePlein()
        {
            _niveauJaugeCarburant = _capaciteMaximumReservoir;
        }

        public void ConsommerCarburant(int nbrCarburant)
        {
            _niveauJaugeCarburant -= nbrCarburant;

            if (_niveauJaugeCarburant < 0)
            {
                _niveauJaugeCarburant = 0;
            }
        }
    }
}

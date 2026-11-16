namespace _6TTi_Beaujean_HeritageVehicule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Vehicule vehicule = new Vehicule("Ferdinand", "porsche", "gris", 1000000);
            Velo velo = new Velo("VTT", "Specialized", "rouge", 10000, "VTT", false);
            Voiture voiture = new Voiture("Niva", "Lada", "pourpre", 15000, "Diesel", true);

            Console.WriteLine(vehicule.Afficher());
            Console.WriteLine(velo.Afficher());
            Console.WriteLine(voiture.Afficher());
        }
    }
}

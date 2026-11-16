namespace _6TTi_Beaujean_HeritageVehicule
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");


            Velo velo = new Velo("VTT", "Specialized", "rouge", 10000, "VTT", false);
            Voiture voiture = new Voiture("Niva", "Lada", "pourpre", 15000, "Diesel", true);


            Console.WriteLine(velo.Afficher());
            Console.WriteLine(voiture.Afficher());
        }
    }
}

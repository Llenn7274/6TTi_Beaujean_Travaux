namespace _6TTi_Beaujean_AllumerLampePoo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bienvenue");

            string couleur;
            Lampe lampeliee;
            int code;
            bool etat;

            lampeliee = new Lampe(1, "bleu", false);

            Interrupteur interrupteur = new Interrupteur(1, lampeliee);

            Console.WriteLine(lampeliee.EtatLampe());
        }
    }
}

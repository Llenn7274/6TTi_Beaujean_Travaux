namespace GestionChien_BeaujeanNathan_6TTi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int ChiensTot;
            string nom;
            int age;
            string race;
            int poids;

            Console.WriteLine("Bonjour");
            ChiensTot = LireEntier("Entrez le nombre de chiens que vous voulez créer :");


            for (int iChien = 0; iChien < ChiensTot; iChien++)
            {
                Console.WriteLine("Entrez le nom du chien :");
                nom = Console.ReadLine();

                age = LireEntier("Entrez l'âge du chien :");

                Console.WriteLine("Entrez la race du chien  :");
                race = Console.ReadLine();

                poids = LireEntier("Entrez le poids du chien :");

                Chien chien = new Chien(nom, age, race, poids);

                chien.AfficheCaracteristiques();

            }
            static int LireEntier(string message)
            {
                int entier;
                do
                {
                    Console.WriteLine(message);
                } while (!int.TryParse(Console.ReadLine(), out entier));

                return entier;
            }
        }
    }
}

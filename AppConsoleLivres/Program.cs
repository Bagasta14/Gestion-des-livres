using System;
using System.Collections.Generic;

namespace AppConsoleLivres
{
    class Program
    {
        static void Main(string[] args)
        {
            Revue revue1 = new Revue("Le Mans 24 Heures", "Michel Vaillant", 120, 45, 2022);
            Revue revue2 = new Revue("Légendes du Nürburgring", "Hans Müller", 80, 12, 2021);
            Revue revue3 = new Revue("Le Mans Classique", "Jacques Durand", 100, 67, 2023);

            Roman roman1 = new Roman("La course des géants", "Jean-Pierre Gauthier", 350, "Sport Automobile");
            Roman roman2 = new Roman("Les Rois du Nürburgring", "Klaus Schmidt", 400, "Histoire du Nürburgring");
            Roman roman3 = new Roman("Le Mans : Une légende", "Antoine Dupuis", 450, "Chronique de Le Mans");

            revue1.AfficherDetails();
            revue2.AfficherDetails();
            revue3.AfficherDetails();

            roman1.AfficherDetails();
            roman2.AfficherDetails();
            roman3.AfficherDetails();

            List<Livre> listeLivres = new List<Livre> { revue1, revue2, revue3, roman1, roman2, roman3 };

            Console.WriteLine("\nAffichage de la liste des livres:");
            foreach (var livre in listeLivres)
            {
                livre.AfficherDetails();
            }
        }
    }
}

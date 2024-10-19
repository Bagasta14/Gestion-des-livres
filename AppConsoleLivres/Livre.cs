using System;

namespace AppConsoleLivres
{
    public class Livre
    {
        public string Titre { get; set; }
        public string Auteur { get; set; }
        public int NbrPages { get; set; }

        public Livre(string titre, string auteur, int nbrPages)
        {
            Titre = titre;
            Auteur = auteur;
            NbrPages = nbrPages;
        }

        public virtual void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Nombre de pages: {NbrPages}");
        }
    }
}

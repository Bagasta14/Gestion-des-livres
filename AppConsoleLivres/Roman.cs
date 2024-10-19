namespace AppConsoleLivres
{
    public class Roman : Livre
    {
        public string Genre { get; set; }

        public Roman(string titre, string auteur, int nbrPages, string genre)
            : base(titre, auteur, nbrPages)
        {
            Genre = genre;
        }

        public override void AfficherDetails()
        {
            Console.WriteLine($"Titre: {Titre}, Auteur: {Auteur}, Nombre de pages: {NbrPages}, Genre: {Genre}");
        }
    }

}
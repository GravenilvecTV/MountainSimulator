namespace Simulator {

    public class Montagne {

        // propriétés
        public string Nom { get; set; }
        public double Hauteur { get; set; }
        public string Pays { get; set; }
        public bool TempNeigeux { get; set; }

        public int CompteurAvalanches { get; set; }

        // constructeur
        public Montagne(string nom, double hauteur, string pays) {
            Nom = nom;
            Hauteur = hauteur;
            Pays = pays;
            TempNeigeux = false;
            CompteurAvalanches = 0;
        }

        // méthodes

        public void DeclencherAvalanche() {
            CompteurAvalanches++;
            Console.WriteLine("Attention à l'avalanche !!!");
        }

        public void ChangerMeteoNeige() {
            if (TempNeigeux) {
                TempNeigeux = false;
                Console.WriteLine("Il ne neige plus au sommet");
            } else {
                TempNeigeux = true;
                Console.WriteLine("Il neige au sommet");
            }
        }

    }

}
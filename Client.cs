using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atelier1C
{
    internal class Client
    {
        private string nom;
        private string prenom;
        private string adresse;

        public Client(string n, string p, string a)
        {
            this.nom = n;
            this.prenom = p;
            this.prenom = a;
        }
        public override string tostring()
        {
            string s = this.adresse + this.nom + this.prenom;
            return s;

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace atelier1C
{
    internal class Compte
    {
		protected readonly numCompte;
		protected static int incr=0;
		protected Client proprietaire;
		protected Devise solde;
		protected devise plafond;

		public Compte()
			{
			this.numCompte = incr++;
			this.proprietaire = 0;
			this.solde = 0;
			this.plafond = 0;
			}
		public Compte(Client prop, Devise sol, Devise p)
		{
			
			this.numCompte = incr++;
			this.proprietaire = prop;
			this.solde = sol;
			this.plafond = p;

		}
		public override string tostring()
		{
			string s = this.numCompte + this.proprietaire.tostring() + this.solde.tostring();
			return s;
		}
		public bool crediter(devise s)
        {
			if (s >= 0)
            {
				this.solde = this.solde + s;
				return true;

            }
			return false;
        }
		public bool debiter(solde s)
        {
			if(this.solde >= s && s<= this.plafond)
            {
				this.solde = this.solde - s;
				return true;
            }
			return false;
        }
		public bool reverse(Compte c, devise s)
        {
			if(this.debiter(s))
            {
				this.debiter(s);
				c.crediter(s);
				return true;

            }
			return false;

        }
	}
}

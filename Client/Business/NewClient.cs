using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Client.Business
{
    class NewClient
    {
        public string nom { get; set; }
        public string prenom { get; set; }
        public string entreprise { get; set; }

        public NewClient(string nom, string prenom, string entreprise)
        {
            this.nom = nom;
            this.prenom = prenom;
            this.entreprise = entreprise;
        }

        public NewClient Validate()
        {
            if (true)
            {
                return this;
            }
            else
            {
                return null;
            }
        }
    }
}

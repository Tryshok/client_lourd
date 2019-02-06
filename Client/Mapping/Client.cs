using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;


namespace Client.Mapping
{
   public class Client : INotifyPropertyChanged
    {
        /*public string nom { get; set; }
        public string prenom { get; set; }
        public string entreprise { get; set; } */

        private int s_ID;
        private string s_nom;
        private string s_prenom;
        private string s_entreprise;

        public Client() { }


        public Client(string nom, string prenom, string entreprise)
        {
            this.s_ID = -1;
            this.s_nom = nom;
            this.s_prenom = prenom;
            this.s_entreprise = entreprise;
        }

        public int id { get { return s_ID; } set { s_ID = value; NotifyPropertyChanged("id"); } }
        public string  lastName { get { return s_nom; } set { s_nom = value; NotifyPropertyChanged("lastName"); } }
        public string firstName { get { return s_prenom; } set { s_prenom = value; NotifyPropertyChanged("firstName"); } }
        public string company { get { return s_entreprise; } set { s_entreprise = value; NotifyPropertyChanged("company"); } }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(string p)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(p));
        }


        //Implémenter différentes vérifications syntaxiques
        public Mapping.Client Validate()
        {
            //check for special symbols and stuff like that
            Regex maregex = new Regex(@"^(?=[A-Za-z])(?!.*[._()\[\]-]{2})[A-Za-z._()\[\]-]{3,15}$");
            
            if (!maregex.IsMatch(this.firstName))
            {
                return null;
            }
            else if (!maregex.IsMatch(this.lastName))
            {
                return null;

            }
            else if (!maregex.IsMatch(this.company))
            {
                return null;
            }
            else
            {
                return this;
            }
        }
    }
}

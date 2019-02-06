using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.DirectoryServices;
using System.Security.Principal;
using System.Net;
using System.DirectoryServices.Protocols;

namespace Client.Mapping
{
    class User
    {
        public string username { get; set; }
        public string password { get; set; }

        public User(string login, string password)
        {
            this.username = login;
            this.password = password;
        }

        //check for good login
        public bool CheckLogin()
        {
            if (this.username != null && this.username != "")
            {
                
                try
                {
                    LdapConnection lcon = new LdapConnection(new LdapDirectoryIdentifier("ALPHAPAR.LAN", false, false));
                    NetworkCredential nc = new NetworkCredential(this.username, this.password);
                    lcon.Credential = nc;

                    //Console.WriteLine("Domaine de l'utilisateur: " + nc.Domain);

                    lcon.AuthType = AuthType.Negotiate;
                    lcon.Bind(nc); // user has authenticated at this point, as the credentials were used to login to the dc.
                    //Console.WriteLine("Authentification SUCCESSFULL!!!");
                }
                catch (LdapException ex)
                {
                    Console.WriteLine("Authentification FAILED!!!");
                    Console.WriteLine(ex.Message);
                    return false;
                }
                return true;
            }
            else
            {
                return false;
            }
        }
    }

    public class Token
    {
        public string token { get; set; }
    }
}

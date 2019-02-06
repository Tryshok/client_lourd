using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Client.Mapping
{
    class Employee
    {
        public int id { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string phone { get; set; }
        public string service { get; set; }

        public Employee Validate()
        {
            this.id = -1;
            // check for special symbols and stuff like that
 
             Regex RegexName = new Regex(@"^(?=[A-Za-z])(?!.*[._()\[\]-]{2})[A-Za-z._()\[\]-]{3,15}$");
            Regex RegexPhone = new Regex(@"^(?=[0-9])(?!.*[._()\[\]-]{2})[0-9._()\[\]-]{10}$");


            if (!RegexName.IsMatch(this.firstName))
            {
                return null;
            }
            else if (!RegexName.IsMatch(this.lastName))
            {
                return null;

            }
            else if (!RegexName.IsMatch(this.service))
            {
                return null;
            }
            else if (!RegexPhone.IsMatch(this.phone))
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

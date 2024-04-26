using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace mohammadjada210209305child
{
    internal class child
    {
        public string name { get; set; }
        public string lastName { get; set; }
        public int dobDay { get; set; }
        public int dobMonth { get; set; }
        public int dobYear { get; set; }
        public string gender { get; set; }
        public string football { get; set; }
        public string sail { get; set; }

        public child(string name, string lastName, int dobDay, int dobMonth, int dobYear ,string gender, string football, string sail)
        {
            this.name = name;
            this.lastName = lastName;
            this.dobDay = dobDay;
            this.dobMonth = dobMonth;
            this.dobYear = dobYear;
            this.gender = gender;
            this.football = football;
            this.sail = sail;
        }
    }
}

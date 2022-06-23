using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    internal class Private: contact
    {
        public string LastName { get; set; }
        public Private(string name, string lastName, string number, string adress) : base(name, number, adress)
        {
            LastName = lastName;
        }

        public override bool isContentHasValue(string SerchPrahes)
        {
            if (base.isContentHasValue(SerchPrahes) || SerchPrahes == LastName)
                return true;
            return false;
        }
        public override string displaycontactdeatails()
        {
            string str = base.displaycontactdeatails();

            return str + LastName;
        }
    }
}

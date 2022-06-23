using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    class contact
    {

        public contact(string name, string number, string adress)
        {
            Name = name;
            Number = number;
            //LastName = lastname;
            Adress = adress;
        }

        public string Name { get; set; }
        public string Number { get; set; }

        //public string LastName { get; set; }
        public string Adress { get; set; }

        public virtual bool isContentHasValue(string SerchPrahes)
        {
            if (SerchPrahes == Name || SerchPrahes == Number || SerchPrahes == Adress)
                return true;
            return false;
        }

        public virtual string displaycontactdeatails()
        {
            return $"contact: {Name} {Number} {Adress}";
        }
    }
}

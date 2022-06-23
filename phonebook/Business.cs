using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace phonebook
{
    internal class Business:contact
    {
        public string HP { get; set; }
        public Business(string name, string hp, string number, string adress) :base(name, number , adress)
        {
            HP = hp;    

        }

        public override bool isContentHasValue(string SerchPrahes)
        {
            if (base.isContentHasValue(SerchPrahes) || SerchPrahes == HP)
                return true;
            return false;
           

        }

        public override string displaycontactdeatails()
        {
            string str = base.displaycontactdeatails();

            return str + HP ;


        }
    }

}

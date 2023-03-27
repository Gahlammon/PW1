using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project1
{
    public class Hero
    {
        public string name;
        public string nationality;
        public string role;

        public Hero()
        {

        }
        public Hero(string heroName, string heroNationality, string heroRole)
        {
            name = heroName;
            nationality = heroNationality;
            role = heroRole;
        }
    }
}

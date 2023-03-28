using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Project1
{
    [XmlType("Hero")]
    [Serializable]
    public class Hero
    {
        [XmlElement("Name")]
        public string name { get; set; }
        [XmlElement("Nationality")]
        public string nationality { get; set; }
        [XmlElement("Role")]
        public string role { get; set; }

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

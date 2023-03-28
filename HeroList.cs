using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace Project1
{
    [Serializable]
    public class HeroList
    {
        [XmlElement("HeroList")]
        public List<Hero> heroes;

        public HeroList()
        {
            heroes = new List<Hero>();
        }
    }
}

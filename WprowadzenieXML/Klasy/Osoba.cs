using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


namespace WprowadzenieXML.Klasy
{
    [Serializable]
    public class Osoba
    {
        [XmlAttribute("lp")]
        public int Lp { get; set; }

        [XmlAttribute("nazwisko")]
        public string Nazwisko { get; set; }

        [XmlAttribute("imię")]
        public string Imie { get; set; }

        [XmlAttribute("rok")]
        public int Rok { get; set; }

        [XmlAttribute("kierunek")]
        public string Kierunek { get; set; }

        [XmlAttribute("stypendium")]
        public string Stypendium { get; set; }

        [XmlAttribute("dojazd")]
        public string Dojazd { get; set; }

        [XmlElement("przedmiot")]
        public List<Przedmiot> Przedmioty { get; set; }
    }
}

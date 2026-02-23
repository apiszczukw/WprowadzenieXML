using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace WprowadzenieXML.Helpers
{
    public static class XmlManager
    {
        public static T DeserializujXML<T>(string sciezka)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(T));

            using(XmlReader reader = XmlReader.Create(sciezka))
            {
                return (T)serializer.Deserialize(reader);
            }
        }
    }
}

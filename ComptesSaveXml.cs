using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace SpotifyBot
{
    internal class ComptesSaveXml
    {
        public string Setting1 { get; set; }
        public List<string> Setting2 { get; set; }

        public void Save(string filename)
        {
            using (StreamWriter sw = new StreamWriter(filename))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(ComptesSaveXml));
                xmls.Serialize(sw, this);
            }
        }
        public ComptesSaveXml Read(string filename)
        {
            using (StreamReader sw = new StreamReader(filename))
            {
                XmlSerializer xmls = new XmlSerializer(typeof(ComptesSaveXml));
                return xmls.Deserialize(sw) as ComptesSaveXml;
            }
        }
     
    }
}

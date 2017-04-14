using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serializer.Distributions;
using System.IO;


namespace Serializer {
    public static class XmlSerializer {
        private static System.Xml.Serialization.XmlSerializer xmlFormat = new System.Xml.Serialization.XmlSerializer(
                                                        typeof(List<dynamic>), new Type[] { typeof(Debian), typeof(Ubuntu),
                                                        typeof(LinuxMintDebianEdition), typeof(SolusOS), typeof(LinuxMint),
                                                        typeof(ElementaryOS), typeof(CommodoreOS)});


        public static void Serialize(List<dynamic> list, string pathToFile) {            
            using (FileStream fStream = new FileStream(pathToFile, FileMode.Create, FileAccess.Write)) {
                xmlFormat.Serialize(fStream, list);
            }
        }

        public static List<dynamic> Deserialize(string pathToFile) {
            using (FileStream fStream = new FileStream(pathToFile, FileMode.Open, FileAccess.Read)) {
                return (List<dynamic>) xmlFormat.Deserialize(fStream);
            }
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializer.Distributions {
    [XmlRoot]
    public class SolusOS : LinuxMintDebianEdition{

        public string installer { get; set; }
        public SolusOS() {
        }

        public SolusOS(string systemName, string systemVersion, string coreVersion, string fileManager, string installer) :
               base(systemName, systemVersion, coreVersion, fileManager) {
            this.installer = installer;
        }
    }
}

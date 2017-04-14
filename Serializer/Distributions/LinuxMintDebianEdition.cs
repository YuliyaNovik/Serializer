using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializer.Distributions {
    [XmlRoot]
    public class LinuxMintDebianEdition : Debian{
        public string fileManager { get; set; }
        public LinuxMintDebianEdition() { }

        public LinuxMintDebianEdition(string systemName, string systemVersion, string coreVersion, string fileManager) :
               base(systemName, systemVersion, coreVersion) {
            this.fileManager = fileManager;
        }
        
    }
}

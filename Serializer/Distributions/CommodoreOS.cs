using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializer.Distributions {
    [Serializable]
    public class CommodoreOS : LinuxMint {
        public string specialDesign { get; set; }
        public CommodoreOS() {
        }

        public CommodoreOS(string systemName, string systemVersion, string coreVersion, string imageName, string namingRules, string fileManager, string specialDesign) :
               base(systemName, systemVersion, coreVersion, imageName, namingRules, fileManager) {
            this.specialDesign = specialDesign;
        }
    }
}

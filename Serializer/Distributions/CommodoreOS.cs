using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializer.Distributions {
    [XmlRoot]
    public class CommodoreOS : LinuxMint {
        public CommodoreOS() {
        }

        public CommodoreOS(string version) : base(version) {
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializer.Distributions {
    [XmlRoot]
    public class LinuxMint : Ubuntu {
        public LinuxMint() {
        }

        public LinuxMint(string version) : base (version) {
        }
    }
}

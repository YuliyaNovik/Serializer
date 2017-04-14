using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializer.Distributions {
    [XmlRoot]
    public class Debian {
        [XmlElement]
        public string systemVersion { get; set; }
        public string coreVersion { get; set; }
        public string systemName { get; set; } 

        public Debian (){}

        public Debian (string systemName, string systemVersion, string coreVersion) {
            this.systemName = systemName;
            this.systemVersion = systemVersion;
            this.coreVersion = coreVersion;
        }

    }
}

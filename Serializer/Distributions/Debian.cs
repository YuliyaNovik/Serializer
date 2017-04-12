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
        public string version { get; set; }

        public Debian (){}

        public Debian (string version) {
            this.version = version;
        }

    }
}

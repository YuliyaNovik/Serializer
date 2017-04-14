using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializer.Distributions {
    [XmlRoot]
    public class Ubuntu : Debian {
        public string imageName { get; set; }
        public string namingRules { get; set; }

        public Ubuntu() {}

        public Ubuntu(string systemName, string systemVersion, string coreVersion, string imageName, string namingRules) : 
               base(systemName, systemVersion, coreVersion) {
            this.imageName = imageName;
            this.namingRules = namingRules;
        }
    }
    
}

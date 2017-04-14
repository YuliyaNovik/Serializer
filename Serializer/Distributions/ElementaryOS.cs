using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializer.Distributions {
    public class ElementaryOS : Ubuntu {
        public string installer { get; set; }
        public ElementaryOS() {
        }

        public ElementaryOS(string systemName, string systemVersion, string coreVersion, string imageName, string namingRules, string installer) :
               base(systemName, systemVersion, coreVersion, imageName, namingRules) {
            this.installer = installer;
        }
    }
}

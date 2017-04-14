using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Serializer.Distributions {
    [Serializable]
    public class LinuxMint : Ubuntu {
        public string fileManager { get; set; }
        public LinuxMint() {
        }

        public LinuxMint(string systemName, string systemVersion, string coreVersion, string imageName, string namingRules, string fileManager) :
               base(systemName, systemVersion, coreVersion, imageName, namingRules) {
            this.fileManager = fileManager;
        }
    }
}

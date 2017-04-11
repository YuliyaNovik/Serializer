using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer.Distributions {
    public class SolusOS : LinuxMintDebianEdition{
        public SolusOS() {
        }

        public SolusOS(string version) : base (version) {
        }
    }
}

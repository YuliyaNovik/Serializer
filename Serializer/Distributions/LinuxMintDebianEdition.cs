using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer.Distributions {
    public class LinuxMintDebianEdition : Debian{
        public LinuxMintDebianEdition() { }

        public LinuxMintDebianEdition(string version) : base (version) {
        }
        
    }
}

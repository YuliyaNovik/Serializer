using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer.Distributions {
    public class ElementaryOS : Ubuntu {
        public ElementaryOS() {
        }

        public ElementaryOS(string version) : base (version) {
        }
    }
}

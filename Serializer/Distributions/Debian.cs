using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serializer.Distributions {
    class Debian {

        public string version { get; set; }

        public Debian (){}

        public Debian (string version) {
            this.version = version;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace System { // mudar o namespace para system para extender a classe na system
    public static class StringExtension {
        public static string FirstToUpper(this String str) {
            string primeira = str.Substring(0, 1);
            string segunda = str.Substring(1);
            return primeira.ToUpper() + segunda;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura
{
    public class NormalizeClasseCusto
    {
        public static byte Run(string classeCusto)
        {
            if (classeCusto == "onera") return 1;
            if (classeCusto == "desonera") return 2;

            return 0;
        }
    }
}

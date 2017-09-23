using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estrutura
{
    public class NormalizaUnidade
    {
        public static string Run(string anormal)
        {
            string comp = anormal.ToLower();

            if (comp == "cx" || comp == "caixa") return "cx";
            if (comp == "rl" || comp == "rolo") return "rl";
            if (comp == "kg" || comp == "kilo") return "kg";
            if (comp == "milheiro") return "mh";
            if (comp == "un" || comp == "unitário" || comp == "peça" || comp == "pç" || comp == "pc") return "pc";
            if (comp == "lt" || comp == "l" || comp == "litro") return "lt";
            if (comp == "ct" || comp == "cartela") return "ct";
            if (comp == "m" || comp == "mt" || comp == "metro") return "mt";

            return "--";
        }
    }
}

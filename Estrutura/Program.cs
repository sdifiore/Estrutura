using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Estrutura
{
    class Program
    {
        static void Main(string[] args)
        {
            var excel = new ExcelDb();

            //Console.WriteLine("Insumo");
            //excel.Insumo();
            //Console.WriteLine("Produto");
            //excel.Produto();
            Console.WriteLine("Estutura");
            excel.Estrutura();
        }
    }
}

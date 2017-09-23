using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excel = Microsoft.Office.Interop.Excel;

namespace Estrutura
{
    public class ExcelDb
    {


        public void Produto()
        {
            var context = new DataContext();

            for (int tab = 2; tab <= 3; tab++)
            {
                Excel.Application xlApp = new Excel.Application();
                Excel.Workbook workbook = xlApp.Workbooks.Open(Files.CustoEstrutura);
                Excel._Worksheet worksheet = workbook.Sheets[tab];
                Excel.Range range = worksheet.UsedRange;

                try
                {
                    for (int i = 2; i <= range.Rows.Count; i++)
                    {
                        var codigo = (range.Cells[i, 1] != null && range.Cells[i, 1].Value2 != null) ? range.Cells[i, 1].Value2.ToString() : "0000000000";
                        var descricao = (range.Cells[i, 2] != null && range.Cells[i, 2].Value2 != null) ? range.Cells[i, 2].Value2.ToString() : "--";
                        var tipo = (range.Cells[i, 4] != null && range.Cells[i, 4].Value2 != null) ? range.Cells[i, 4].Value2.ToString() : "x";
                        var classeCusto = (range.Cells[i, 5] != null && range.Cells[i, 5].Value2 != null) ? range.Cells[i, 5].Value2.ToString() : "00";
                        var categoria = (range.Cells[i, 6] != null && range.Cells[i, 6].Value2 != null) ? range.Cells[i, 6].Value2.ToString() : "00";
                        var familia = (range.Cells[i, 7] != null && range.Cells[i, 7].Value2 != null) ? range.Cells[i, 7].Value2.ToString() : "000";
                        var linha = (range.Cells[i, 8] != null && range.Cells[i, 8].Value2 != null) ? range.Cells[i, 8].Value2.ToString() : "0000";

                        var data = new Product
                        {
                            Codigo = codigo,
                            Descricao = descricao,
                            Unidade = NormalizaUnidade.Run(range.Cells[i, 3].Value2.ToString()),
                            Tipo = tipo.Substring(0, 1),
                            ClasseCusto = classeCusto.Substring(0, 2),
                            Categoria = categoria.Substring(0, 2),
                            Familia = familia.Substring(0, 3),
                            Linha = linha.Substring(0, 4)
                        };

                        context.Produtos.Add(data);
                        context.SaveChanges();
                    }
                }
                catch (Exception ex)
                {
                    DbLogger.Log(Reason.Error, $"Loop Produto: {ex}");
                }
                finally
                {
                    xlApp.Quit();
                    workbook = null;
                    worksheet = null;
                    xlApp = null;
                } 
            }
        }

        public void Estrutura()
        {
            var context = new DataContext();

            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook workbook = xlApp.Workbooks.Open(Files.Estrutura);
            Excel._Worksheet worksheet = workbook.Sheets[1];
            Excel.Range range = worksheet.UsedRange;

            try
            {
                var i = 2;
                var comp = range.Cells[i, 1].Value2.ToString();

                while (i++ < range.Rows.Count)
                {
                    if (comp == range.Cells[i, 1].Value2.ToString())
                    {
                        var productTree = new ProductTree
                        {
                            Codigo = range.Cells[i, 1].Value2.ToString(),
                            ProdutoId = range.Cells[i, 6].Value2.ToString(),
                            Unidade = range.Cells[i, 3].Value2.ToString(),
                            Sequencia = range.Cells[i, 5].Value2.ToString(),
                            Custo = float.Parse(range.Cells[i, 9].Value2.ToString()),
                            ClasseCusto = NormalizeClasseCusto.Run(range.Cells[i, 10].Value2.ToString())
                        };

                        context.ProductsTree.Add(productTree);
                        context.SaveChanges();
                    }
                    else
                    {
                        comp = range.Cells[i, 1].Value2.ToString();
                    }
                }
            }
            catch (Exception ex)
            {
                DbLogger.Log(Reason.Error, $"Loop Estrutura: {ex.Message}");
            }
            finally
            {
                xlApp.Quit();
                workbook = null;
                worksheet = null;
                xlApp = null;
            }
        }
    }
}

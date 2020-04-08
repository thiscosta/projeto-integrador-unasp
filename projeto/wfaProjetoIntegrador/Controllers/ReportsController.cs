using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaProjetoIntegrador.Models;

namespace wfaProjetoIntegrador.Controllers
{
    class ReportsController
    {
        public static void List(DataGridView objetoResposta)
        {
            int dd = 1;
            List<Product> product = new List<Product>();
            for (int i = 0; i < 5; i++)
            {
                
                product.Add(new Product
                {
                    id = dd,
                    name = "teste",
                    sellPrice = 10,
                    company = "TESTE",
                    quantity = 10,
                    category = "teste",
                    buyprice = 20
                });
                dd++;
            }
            objetoResposta.DataSource = product;

        }

        internal static DataTable List(object dataSource)
        {
            throw new NotImplementedException();
        }
    }
}

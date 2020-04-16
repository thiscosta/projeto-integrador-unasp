using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wfaProjetoIntegrador.Models;
using wfaProjetoIntegrador.Repository;

namespace wfaProjetoIntegrador.Controllers
{
    class SalesUserController 
    {
        private static SaleRepository repo = new SaleRepository();

        public static void list(DataGridView objetoResposta)
        {
            List<Sale> list = repo.getAll();
            objetoResposta.DataSource = list;
        }
        public static List<Sale> listAll()
        {
            return repo.getAll();
        }

        public static Sale find(int id)
        {
            return repo.find(id);
        }

        public static void insert(Sale sale)
        {
            repo.create(sale);
        }

        public static void update(Sale sale)
        {
            repo.update(sale.id, sale);
        }

        public static void delete(Sale sale)
        {
            repo.delete(sale.id);
        }
    }
}

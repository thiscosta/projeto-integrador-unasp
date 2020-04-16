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
    class ProductsUserController
    {
        private static ProductRepository repo = new ProductRepository();

        public static void list(DataGridView objetoResposta)
        {
            List<Product> list = repo.getAll();
            objetoResposta.DataSource = list;
        }
        public static List<Product> listAll()
        {
            return repo.getAll();
        }

        public static void insert(Product prod)
        {
            repo.create(prod);
        }

        public static Product find(int id)
        {
            return repo.find(id);
        }

        public static void update(Product prod)
        {
            repo.update(prod.id, prod);
        }

        public static void delete(Product prod)
        {
            repo.delete(prod.id);
        }
    }
}

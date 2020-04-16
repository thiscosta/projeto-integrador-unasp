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
    public class CustomerUserController
    {
        private static CustomerRepository repo = new CustomerRepository();

        public static void list(DataGridView objetoResposta)
        {
            List<Customer> list = repo.getAll();
            objetoResposta.DataSource = list;
        }
        public static List<Customer> listAll()
        {
            return repo.getAll();
        }

        public static Customer find(int id)
        {
            return repo.find(id);
        }

        public static void insert(Customer customer)
        {
            repo.create(customer);
        }

        public static void update(Customer customer)
        {
            repo.update(customer.id, customer);
        }

        public static void delete(Customer customer)
        {
            repo.delete(customer.id);
        }
    }
}

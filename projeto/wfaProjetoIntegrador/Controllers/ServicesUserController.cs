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
    class ServicesUserController 
    {
        private static ServiceRepository repo = new ServiceRepository();

        public static void list(DataGridView objetoResposta)
        {
            List<Service> list = repo.getAll();
            objetoResposta.DataSource = list;
        }
        public static List<Service> listAll()
        {
            return repo.getAll();
        }

        public static Service find(int id)
        {
            return repo.find(id);
        }

        public static void insert(Service service)
        {
            repo.create(service);
        }

        public static void update(Service service)
        {
            repo.update(service.id, service);
        }

        public static void delete(Service service)
        {
            repo.delete(service.id);
        }

        public static List<Service> findBy(string fieldName, dynamic value)
        {
            return repo.findBy(fieldName, value);
        }
    }
}

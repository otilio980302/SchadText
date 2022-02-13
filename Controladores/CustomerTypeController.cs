using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class CustomerTypeController
    {
        public IEnumerable<Modelos.Customers.CustomerTypeViewModel> Getlist()
        {
            using (Modelos.EF.Test_InvoiceEntities db = new Modelos.EF.Test_InvoiceEntities())
            {
                IEnumerable<Modelos.Customers.CustomerTypeViewModel> lst = (from d in db.CustomerTypes
                                                          select new Modelos.Customers.CustomerTypeViewModel
                                                          {
                                                              Id = d.Id,
                                                              Description = d.Description
                                                          }).ToList();
                return lst;
            }
        }

        public void SendData(Modelos.EF.CustomerTypes CustomerData)
        {
            using (Modelos.EF.Test_InvoiceEntities db = new Modelos.EF.Test_InvoiceEntities())
            {
                db.CustomerTypes.Add(CustomerData);
                db.SaveChanges();

            }
        }
    }
}

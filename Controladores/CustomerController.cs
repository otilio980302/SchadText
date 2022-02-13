using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class CustomerController
    {
        public IEnumerable<Modelos.Customers.CustomerViewModel> Getlist()
        {
            using (Modelos.EF.Test_InvoiceEntities db = new Modelos.EF.Test_InvoiceEntities())
            {
                IEnumerable<Modelos.Customers.CustomerViewModel> lst = (from d in db.Customers
                                                                        select new Modelos.Customers.CustomerViewModel
                                                                        {
                                                                            Id = d.Id,
                                                                            CustName = d.CustName,
                                                                            Adress = d.Adress,
                                                                            Status = d.Status,
                                                                            CustomerType = d.CustomerTypeId
                                                                        }).ToList();
                return lst;
            }
        }

        public void SendData(Modelos.EF.Customers CustomerData)
        {
            using (Modelos.EF.Test_InvoiceEntities db = new Modelos.EF.Test_InvoiceEntities())
            {
                db.Customers.Add(CustomerData);
                db.SaveChanges();
            }
        }
    }
}

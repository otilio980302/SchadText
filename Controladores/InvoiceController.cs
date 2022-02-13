using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class InvoiceController
    {
        public IEnumerable<Modelos.Invoice.InvoiceViewModel> Getlist()
        {
            using (Modelos.EF.Test_InvoiceEntities db = new Modelos.EF.Test_InvoiceEntities())
            {
                IEnumerable<Modelos.Invoice.InvoiceViewModel> lst = (from d in db.Invoice
                                                                            select new Modelos.Invoice.InvoiceViewModel
                                                                            {
                                                                                Id = d.Id,
                                                                                CustomerId = d.CustomerId,
                                                                                TotalItbis = d.TotalItbis,
                                                                                SubTotal = d.SubTotal,
                                                                                Total = d.Total
                                                                            }).ToList();
                return lst;
            }
        }

        public int SendData(Modelos.EF.Invoice Invoice)
        {
            int Id = 0;
            using (Modelos.EF.Test_InvoiceEntities db = new Modelos.EF.Test_InvoiceEntities())
            {
                db.Invoice.Add(Invoice);
                db.SaveChanges();

                Id = Invoice.Id;
            }
            return Id;
        }
    }
}

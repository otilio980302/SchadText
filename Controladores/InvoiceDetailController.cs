using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Controladores
{
    public class InvoiceDetailController
    {
        public IEnumerable<Modelos.Invoice.InvoiceDetailViewModel> Getlist()
        {
            using (Modelos.EF.Test_InvoiceEntities db = new Modelos.EF.Test_InvoiceEntities())
            {
                IEnumerable<Modelos.Invoice.InvoiceDetailViewModel> lst = (from d in db.InvoiceDetail
                                                                     select new Modelos.Invoice.InvoiceDetailViewModel
                                                                     {
                                                                         Id = d.Id,
                                                                         CustomerId = d.CustomerId,
                                                                         Qty = d.Qty,
                                                                         Price = d.Price,
                                                                         TotalItbis = d.TotalItbis,
                                                                         SubTotal = d.SubTotal,
                                                                         Total = d.Total
                                                                     }).ToList();
                return lst;
            }
        }

        public void SendData(Modelos.EF.InvoiceDetail InvoiceDetail)
        {
            using (Modelos.EF.Test_InvoiceEntities db = new Modelos.EF.Test_InvoiceEntities())
            {
                db.InvoiceDetail.Add(InvoiceDetail);
                db.SaveChanges();
            }
        }
    }
}

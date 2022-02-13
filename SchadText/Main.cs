using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;

namespace SchadText
{
    public partial class Main : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public Main()
        {
            InitializeComponent();
        }

        private void barButtonCustomer_ItemClick(object sender, ItemClickEventArgs e) {
            CustomerView customerView = new CustomerView();
            customerView.MdiParent = this;
            customerView.Show();
        }
        private void barButtonCustomerType_ItemClick(object sender, ItemClickEventArgs e)
        {
            CustomerTypeView customerTypeView = new CustomerTypeView();
            customerTypeView.MdiParent = this;
            customerTypeView.Show();
        }

        private void barButtonInvoice_ItemClick(object sender, ItemClickEventArgs e) => new Invoice.InvoiceView().Show();
    }
}
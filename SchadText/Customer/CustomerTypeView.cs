using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace SchadText
{
    public partial class CustomerTypeView : DevExpress.XtraEditors.XtraForm
    {
        Controladores.CustomerTypeController oCustomerTypeController = new Controladores.CustomerTypeController();
        public CustomerTypeView()
        {
            InitializeComponent();
            dgvCustomer.DataSource = oCustomerTypeController.Getlist();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (Customer.CustomerTypeAddView customer = new Customer.CustomerTypeAddView())
            {
                if (customer.ShowDialog() == DialogResult.OK)
                {

                }
                else
                {
                    dgvCustomer.DataSource = oCustomerTypeController.Getlist();
                }
            }
        }
    }
}
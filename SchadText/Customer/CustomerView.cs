using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace SchadText
{

    public partial class CustomerView : DevExpress.XtraEditors.XtraForm
    {
        Controladores.CustomerController oMainController = new Controladores.CustomerController();
        public CustomerView()
        {
            InitializeComponent();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            dgvCustomer.DataSource = oMainController.Getlist();
        }

        private void BtnAgregar_Click(object sender, EventArgs e)
        {
            using (Customer.CustomerAddView customer = new Customer.CustomerAddView())
            {
                if (customer.ShowDialog() == DialogResult.OK)
                {

                }
                else
                {
                    dgvCustomer.DataSource = oMainController.Getlist();
                }
            }

        }
    }
}

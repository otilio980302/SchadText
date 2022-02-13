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

namespace SchadText.Customer
{
    public partial class CustomerTypeAddView : DevExpress.XtraEditors.XtraForm
    {
        Controladores.CustomerTypeController oCustomerController = new Controladores.CustomerTypeController();
        Controladores.CustomerTypeController oCustomerTypeController = new Controladores.CustomerTypeController();
        public CustomerTypeAddView()
        {
            InitializeComponent();
        }

        private void BtnCompletarTrabajador_Click(object sender, EventArgs e)
        {
            if (tbCustTypeName.Text != "")
            {

                Modelos.EF.CustomerTypes data = new Modelos.EF.CustomerTypes();
                data.Description = tbCustTypeName.Text;

                oCustomerController.SendData(data);
                this.Close();
            }
            else
            {
                MessageBox.Show("Rellene todos los campos");
            }
        }
    }
}
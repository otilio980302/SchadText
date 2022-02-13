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
    public partial class CustomerAddView : DevExpress.XtraEditors.XtraForm
    {
        Controladores.CustomerController oCustomerController = new Controladores.CustomerController();
        Controladores.CustomerTypeController oCustomerTypeController = new Controladores.CustomerTypeController();
        public CustomerAddView()
        {
            InitializeComponent();
            //Dictionary<int,string> comboSource = new Dictionary<int, string>();

            //foreach (var item in oCustomerTypeController.Getlist())
            //{
            //    comboSource.Add(item.Id, item.Description);
            //}

            //cbCustomerType.DataSource = new BindingSource(comboSource, null);

            DataTable dt = new DataTable();
            dt.Columns.Add("A1", typeof(int));
            dt.Columns.Add("A2");
            foreach (var item in oCustomerTypeController.Getlist())
            {
                dt.Rows.Add(item.Id,item.Description );
            }



            cbCustomerType.DataSource = dt;
            cbCustomerType.DisplayMember = "A2";
            cbCustomerType.ValueMember = "A1";

        }

        private void BtnCompletarTrabajador_Click(object sender, EventArgs e)
        {
            try
            {
                if (tbCustName.Text != "" && tbAdress.Text != "")
                {
                    Modelos.EF.Customers data = new Modelos.EF.Customers();
                    data.CustName = tbCustName.Text;
                    data.Adress = tbAdress.Text;
                    data.Status = cStatus.Checked ? true : false;
                    data.CustomerTypeId = Convert.ToInt32(cbCustomerType.SelectedValue);

                    oCustomerController.SendData(data);
                    this.Close();
                }
                else
                {
                    DataRowView row = (DataRowView)cbCustomerType.SelectedValue;
                    MessageBox.Show("Rellene todos los campos" + row[0]);

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("error "+ ex.Message);
            }
      
    
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
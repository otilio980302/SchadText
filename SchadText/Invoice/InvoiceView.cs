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
using DevExpress.XtraReports.UI;

namespace SchadText.Invoice
{

    public partial class InvoiceView : DevExpress.XtraEditors.XtraForm
    {
        Controladores.InvoiceController oInvoiceController = new Controladores.InvoiceController();
        Controladores.InvoiceDetailController invoiceDetailController = new Controladores.InvoiceDetailController();
        Controladores.CustomerController customerController = new Controladores.CustomerController();
        public InvoiceView()
        {
            InitializeComponent();

            DataTable dt = new DataTable();
            dt.Columns.Add("A1", typeof(int));
            dt.Columns.Add("A2");
            foreach (var item in customerController.Getlist())
            {
                dt.Rows.Add(item.Id, item.CustName);
            }

            cbCustomer.DataSource = dt;
            cbCustomer.DisplayMember = "A2";
            cbCustomer.ValueMember = "A1";
        }

        private void BtnInvoiceMadeIt_Click(object sender, EventArgs e)
        {
            //try
            //{
                if (tbPrice.Text != "" && tbQua.Text !="" && tbTotal.Text !="")
                {


                //Invoice

                Modelos.EF.Invoice dataInvoice = new Modelos.EF.Invoice();
                dataInvoice.CustomerId = Convert.ToInt32(cbCustomer.SelectedValue);
                dataInvoice.SubTotal = Convert.ToDecimal(tbSubTotal.Text);
                dataInvoice.TotalItbis = Convert.ToDecimal(tbTotalItbis.Text);
                dataInvoice.Total = Convert.ToDecimal(tbTotal.Text);
                int InvoiceId = oInvoiceController.SendData(dataInvoice);

                //InvoiceDetail

                Modelos.EF.InvoiceDetail dataDetail = new Modelos.EF.InvoiceDetail();
                dataDetail.CustomerId = InvoiceId;
                    dataDetail.Price = Convert.ToDecimal(tbPrice.Text);
                    dataDetail.Qty = Convert.ToInt32(tbQua.Text);
                    dataDetail.SubTotal = Convert.ToDecimal(tbSubTotal.Text);
                    dataDetail.TotalItbis = Convert.ToDecimal(tbTotalItbis.Text);
                    dataDetail.Total = Convert.ToDecimal(tbTotal.Text);

                    invoiceDetailController.SendData(dataDetail);

                    this.Close();
                }
                else
                {
                    MessageBox.Show("Rellene todos los campos");
                }
            //}
            //catch (Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    //throw;
            //}
        }

        private void InvoiceView_Load(object sender, EventArgs e)
        {

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            decimal itbis = new decimal(0.18);
            decimal SubTotal = Convert.ToDecimal(tbPrice.Text) * Convert.ToDecimal(tbQua.Text);
            decimal TotalItbis = SubTotal * itbis;
            decimal Total = TotalItbis + SubTotal;

            tbSubTotal.Text = SubTotal.ToString();
            tbTotalItbis.Text = TotalItbis.ToString();
            tbTotal.Text = Total.ToString();
        }

        private void simpleButton5_Click(object sender, EventArgs e)
        {
            XtraReport xtraReport = new Reports.RptInvoicee();
            xtraReport.ShowRibbonPreviewDialog();
        }
    }
}
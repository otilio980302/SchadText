namespace SchadText.Invoice
{
    partial class InvoiceView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.BtnInvoiceMadeIt = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.cbCustomer = new System.Windows.Forms.ComboBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.tbPrice = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.tbQua = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.dgvCustomer = new System.Windows.Forms.DataGridView();
            this.tbTotalItbis = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.tbSubTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tbTotal = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.BtnProcess = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQua.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotalItbis.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubTotal.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.BtnInvoiceMadeIt);
            this.panelControl2.Controls.Add(this.simpleButton5);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 458);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(770, 40);
            this.panelControl2.TabIndex = 100;
            // 
            // BtnInvoiceMadeIt
            // 
            this.BtnInvoiceMadeIt.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnInvoiceMadeIt.Location = new System.Drawing.Point(582, 2);
            this.BtnInvoiceMadeIt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnInvoiceMadeIt.Name = "BtnInvoiceMadeIt";
            this.BtnInvoiceMadeIt.Size = new System.Drawing.Size(88, 36);
            this.BtnInvoiceMadeIt.TabIndex = 4;
            this.BtnInvoiceMadeIt.Text = "Post Invoice";
            this.BtnInvoiceMadeIt.Click += new System.EventHandler(this.BtnInvoiceMadeIt_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton5.Location = new System.Drawing.Point(670, 2);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(98, 36);
            this.simpleButton5.TabIndex = 301;
            this.simpleButton5.Text = "Reports";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // cbCustomer
            // 
            this.cbCustomer.FormattingEnabled = true;
            this.cbCustomer.Location = new System.Drawing.Point(108, 45);
            this.cbCustomer.Name = "cbCustomer";
            this.cbCustomer.Size = new System.Drawing.Size(146, 21);
            this.cbCustomer.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(43, 48);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(50, 13);
            this.labelControl1.TabIndex = 52;
            this.labelControl1.Text = "Customer:";
            // 
            // tbPrice
            // 
            this.tbPrice.EditValue = "5000";
            this.tbPrice.EnterMoveNextControl = true;
            this.tbPrice.Location = new System.Drawing.Point(500, 46);
            this.tbPrice.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbPrice.Name = "tbPrice";
            this.tbPrice.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbPrice.Properties.MaxLength = 50;
            this.tbPrice.Size = new System.Drawing.Size(146, 20);
            this.tbPrice.TabIndex = 3;
            this.tbPrice.Tag = "5000";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(469, 49);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(27, 13);
            this.labelControl2.TabIndex = 55;
            this.labelControl2.Text = "Price:";
            // 
            // tbQua
            // 
            this.tbQua.EnterMoveNextControl = true;
            this.tbQua.Location = new System.Drawing.Point(311, 45);
            this.tbQua.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbQua.Name = "tbQua";
            this.tbQua.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbQua.Properties.MaxLength = 50;
            this.tbQua.Size = new System.Drawing.Size(146, 20);
            this.tbQua.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(264, 48);
            this.labelControl3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(46, 13);
            this.labelControl3.TabIndex = 57;
            this.labelControl3.Text = "Quantity:";
            // 
            // dgvCustomer
            // 
            this.dgvCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCustomer.Location = new System.Drawing.Point(44, 94);
            this.dgvCustomer.Name = "dgvCustomer";
            this.dgvCustomer.Size = new System.Drawing.Size(679, 272);
            this.dgvCustomer.TabIndex = 58;
            // 
            // tbTotalItbis
            // 
            this.tbTotalItbis.EditValue = "";
            this.tbTotalItbis.Enabled = false;
            this.tbTotalItbis.EnterMoveNextControl = true;
            this.tbTotalItbis.Location = new System.Drawing.Point(350, 393);
            this.tbTotalItbis.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotalItbis.Name = "tbTotalItbis";
            this.tbTotalItbis.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTotalItbis.Properties.MaxLength = 50;
            this.tbTotalItbis.Size = new System.Drawing.Size(146, 20);
            this.tbTotalItbis.TabIndex = 59;
            this.tbTotalItbis.Tag = "5000";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(295, 396);
            this.labelControl4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 60;
            this.labelControl4.Text = "TotalItbis:";
            // 
            // tbSubTotal
            // 
            this.tbSubTotal.EditValue = "";
            this.tbSubTotal.Enabled = false;
            this.tbSubTotal.EnterMoveNextControl = true;
            this.tbSubTotal.Location = new System.Drawing.Point(108, 393);
            this.tbSubTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbSubTotal.Name = "tbSubTotal";
            this.tbSubTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbSubTotal.Properties.MaxLength = 50;
            this.tbSubTotal.Size = new System.Drawing.Size(146, 20);
            this.tbSubTotal.TabIndex = 61;
            this.tbSubTotal.Tag = "5000";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(61, 396);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(46, 13);
            this.labelControl5.TabIndex = 62;
            this.labelControl5.Text = "SubTotal:";
            // 
            // tbTotal
            // 
            this.tbTotal.EditValue = "";
            this.tbTotal.Enabled = false;
            this.tbTotal.EnterMoveNextControl = true;
            this.tbTotal.Location = new System.Drawing.Point(577, 393);
            this.tbTotal.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbTotal.Name = "tbTotal";
            this.tbTotal.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbTotal.Properties.MaxLength = 50;
            this.tbTotal.Size = new System.Drawing.Size(146, 20);
            this.tbTotal.TabIndex = 63;
            this.tbTotal.Tag = "5000";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(544, 396);
            this.labelControl6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(28, 13);
            this.labelControl6.TabIndex = 64;
            this.labelControl6.Text = "Total:";
            // 
            // BtnProcess
            // 
            this.BtnProcess.Location = new System.Drawing.Point(652, 48);
            this.BtnProcess.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnProcess.Name = "BtnProcess";
            this.BtnProcess.Size = new System.Drawing.Size(88, 36);
            this.BtnProcess.TabIndex = 3;
            this.BtnProcess.Text = "Process";
            this.BtnProcess.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // InvoiceView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 498);
            this.Controls.Add(this.BtnProcess);
            this.Controls.Add(this.tbTotal);
            this.Controls.Add(this.labelControl6);
            this.Controls.Add(this.tbSubTotal);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.tbTotalItbis);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.dgvCustomer);
            this.Controls.Add(this.tbQua);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.tbPrice);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.cbCustomer);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.panelControl2);
            this.Name = "InvoiceView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "InvoiceView";
            this.Load += new System.EventHandler(this.InvoiceView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbQua.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCustomer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotalItbis.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbSubTotal.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbTotal.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnInvoiceMadeIt;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private System.Windows.Forms.ComboBox cbCustomer;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit tbPrice;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit tbQua;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.DataGridView dgvCustomer;
        private DevExpress.XtraEditors.TextEdit tbTotalItbis;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit tbSubTotal;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tbTotal;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.SimpleButton BtnProcess;
    }
}
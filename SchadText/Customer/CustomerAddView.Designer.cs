namespace SchadText.Customer
{
    partial class CustomerAddView
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
            this.components = new System.ComponentModel.Container();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.BtnCompletarTrabajador = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tbAdress = new DevExpress.XtraEditors.TextEdit();
            this.tbCustName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.cStatus = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbCustomerType = new System.Windows.Forms.ComboBox();
            this.dxErrorProvider1 = new DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tbAdress.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cStatus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.BtnCompletarTrabajador);
            this.panelControl2.Controls.Add(this.simpleButton5);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 171);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(353, 40);
            this.panelControl2.TabIndex = 34;
            // 
            // simpleButton5
            // 
            this.simpleButton5.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton5.Location = new System.Drawing.Point(253, 2);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(98, 36);
            this.simpleButton5.TabIndex = 301;
            this.simpleButton5.Text = "Cancelar";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // BtnCompletarTrabajador
            // 
            this.BtnCompletarTrabajador.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCompletarTrabajador.Location = new System.Drawing.Point(165, 2);
            this.BtnCompletarTrabajador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCompletarTrabajador.Name = "BtnCompletarTrabajador";
            this.BtnCompletarTrabajador.Size = new System.Drawing.Size(88, 36);
            this.BtnCompletarTrabajador.TabIndex = 300;
            this.BtnCompletarTrabajador.Text = "Aceptar";
            this.BtnCompletarTrabajador.Click += new System.EventHandler(this.BtnCompletarTrabajador_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(34, 38);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(80, 13);
            this.labelControl5.TabIndex = 43;
            this.labelControl5.Text = "Customer Name:";
            // 
            // tbAdress
            // 
            this.tbAdress.EnterMoveNextControl = true;
            this.tbAdress.Location = new System.Drawing.Point(124, 61);
            this.tbAdress.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbAdress.Name = "tbAdress";
            this.tbAdress.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbAdress.Properties.MaxLength = 50;
            this.tbAdress.Size = new System.Drawing.Size(146, 20);
            this.tbAdress.TabIndex = 2;
            // 
            // tbCustName
            // 
            this.tbCustName.EnterMoveNextControl = true;
            this.tbCustName.Location = new System.Drawing.Point(124, 35);
            this.tbCustName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustName.Name = "tbCustName";
            this.tbCustName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCustName.Properties.MaxLength = 50;
            this.tbCustName.Size = new System.Drawing.Size(146, 20);
            this.tbCustName.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(77, 64);
            this.labelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(37, 13);
            this.labelControl2.TabIndex = 44;
            this.labelControl2.Text = "Adress:";
            // 
            // cStatus
            // 
            this.cStatus.Location = new System.Drawing.Point(124, 87);
            this.cStatus.Name = "cStatus";
            this.cStatus.Properties.Caption = "Status";
            this.cStatus.Size = new System.Drawing.Size(75, 19);
            this.cStatus.TabIndex = 3;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(37, 116);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(77, 13);
            this.labelControl1.TabIndex = 50;
            this.labelControl1.Text = "Customer Type:";
            // 
            // cbCustomerType
            // 
            this.cbCustomerType.FormattingEnabled = true;
            this.cbCustomerType.Location = new System.Drawing.Point(124, 113);
            this.cbCustomerType.Name = "cbCustomerType";
            this.cbCustomerType.Size = new System.Drawing.Size(146, 21);
            this.cbCustomerType.TabIndex = 4;
            // 
            // dxErrorProvider1
            // 
            this.dxErrorProvider1.ContainerControl = this;
            // 
            // CustomerAddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 211);
            this.Controls.Add(this.cbCustomerType);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cStatus);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.tbAdress);
            this.Controls.Add(this.tbCustName);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.panelControl2);
            this.MaximumSize = new System.Drawing.Size(369, 250);
            this.MinimumSize = new System.Drawing.Size(369, 250);
            this.Name = "CustomerAddView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Add View";
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tbAdress.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cStatus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxErrorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnCompletarTrabajador;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tbAdress;
        private DevExpress.XtraEditors.TextEdit tbCustName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.CheckEdit cStatus;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.ComboBox cbCustomerType;
        private DevExpress.XtraEditors.DXErrorProvider.DXErrorProvider dxErrorProvider1;
    }
}
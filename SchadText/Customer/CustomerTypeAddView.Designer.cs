namespace SchadText.Customer
{
    partial class CustomerTypeAddView
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
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.tbCustTypeName = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.BtnCompletarTrabajador = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.tbCustTypeName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(68, 28);
            this.labelControl5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(75, 13);
            this.labelControl5.TabIndex = 45;
            this.labelControl5.Text = "Customer type:";
            // 
            // tbCustTypeName
            // 
            this.tbCustTypeName.EnterMoveNextControl = true;
            this.tbCustTypeName.Location = new System.Drawing.Point(158, 25);
            this.tbCustTypeName.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbCustTypeName.Name = "tbCustTypeName";
            this.tbCustTypeName.Properties.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.tbCustTypeName.Properties.MaxLength = 50;
            this.tbCustTypeName.Size = new System.Drawing.Size(146, 20);
            this.tbCustTypeName.TabIndex = 44;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.BtnCompletarTrabajador);
            this.panelControl2.Controls.Add(this.simpleButton5);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl2.Location = new System.Drawing.Point(0, 99);
            this.panelControl2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(391, 40);
            this.panelControl2.TabIndex = 46;
            // 
            // BtnCompletarTrabajador
            // 
            this.BtnCompletarTrabajador.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnCompletarTrabajador.Location = new System.Drawing.Point(203, 2);
            this.BtnCompletarTrabajador.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BtnCompletarTrabajador.Name = "BtnCompletarTrabajador";
            this.BtnCompletarTrabajador.Size = new System.Drawing.Size(88, 36);
            this.BtnCompletarTrabajador.TabIndex = 300;
            this.BtnCompletarTrabajador.Text = "Aceptar";
            this.BtnCompletarTrabajador.Click += new System.EventHandler(this.BtnCompletarTrabajador_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.Dock = System.Windows.Forms.DockStyle.Right;
            this.simpleButton5.Location = new System.Drawing.Point(291, 2);
            this.simpleButton5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(98, 36);
            this.simpleButton5.TabIndex = 301;
            this.simpleButton5.Text = "Cancelar";
            // 
            // CustomerTypeAddView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(391, 139);
            this.Controls.Add(this.panelControl2);
            this.Controls.Add(this.labelControl5);
            this.Controls.Add(this.tbCustTypeName);
            this.Name = "CustomerTypeAddView";
            this.Text = "Customer Type Add View";
            ((System.ComponentModel.ISupportInitialize)(this.tbCustTypeName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit tbCustTypeName;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.SimpleButton BtnCompletarTrabajador;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
    }
}
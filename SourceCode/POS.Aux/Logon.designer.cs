namespace POS.Aux
{
    partial class Logon
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
            this.UserText = new DevExpress.XtraEditors.TextEdit();
            this.OKbt = new DevExpress.XtraEditors.SimpleButton();
            this.PwdText = new DevExpress.XtraEditors.TextEdit();
            ((System.ComponentModel.ISupportInitialize)(this.UserText.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PwdText.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // UserText
            // 
            this.UserText.Location = new System.Drawing.Point(68, 111);
            this.UserText.Name = "UserText";
            this.UserText.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.UserText.Properties.Appearance.Options.UseBackColor = true;
            this.UserText.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.UserText.Size = new System.Drawing.Size(253, 18);
            this.UserText.TabIndex = 0;
            // 
            // OKbt
            // 
            this.OKbt.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.OKbt.Appearance.Options.UseBackColor = true;
            this.OKbt.ButtonStyle = DevExpress.XtraEditors.Controls.BorderStyles.UltraFlat;
            this.OKbt.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.OKbt.ImageOptions.Image = global::POS.Aux.Properties.Resources.login_form_ui_BTN;
            this.OKbt.Location = new System.Drawing.Point(27, 219);
            this.OKbt.Name = "OKbt";
            this.OKbt.Size = new System.Drawing.Size(303, 74);
            this.OKbt.TabIndex = 2;
            this.OKbt.Text = "simpleButton1";
            this.OKbt.Click += new System.EventHandler(this.OKbt_Click);
            // 
            // PwdText
            // 
            this.PwdText.Location = new System.Drawing.Point(68, 171);
            this.PwdText.Name = "PwdText";
            this.PwdText.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.PwdText.Properties.Appearance.Options.UseBackColor = true;
            this.PwdText.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.PwdText.Properties.PasswordChar = '*';
            this.PwdText.Size = new System.Drawing.Size(237, 18);
            this.PwdText.TabIndex = 1;
            // 
            // Logon
            // 
            this.AcceptButton = this.OKbt;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::POS.Aux.Properties.Resources.login_form_ui01;
            this.ClientSize = new System.Drawing.Size(356, 361);
            this.Controls.Add(this.PwdText);
            this.Controls.Add(this.OKbt);
            this.Controls.Add(this.UserText);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Logon";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Logon";
            ((System.ComponentModel.ISupportInitialize)(this.UserText.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PwdText.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit UserText;
        private DevExpress.XtraEditors.SimpleButton OKbt;
        private DevExpress.XtraEditors.TextEdit PwdText;

    }
}
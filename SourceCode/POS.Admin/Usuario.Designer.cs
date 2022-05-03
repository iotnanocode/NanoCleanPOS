
namespace POS.Admin
{
    partial class Usuario
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Usuario));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SaveBt = new DevExpress.XtraBars.BarButtonItem();
            this.DeleteBt = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.NombreTx = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.UsuarioTx = new DevExpress.XtraEditors.TextEdit();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.PwdTx = new DevExpress.XtraEditors.TextEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.TiendaLu = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NombreTx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioTx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PwdTx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaLu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.SaveBt,
            this.DeleteBt});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 3;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(635, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // SaveBt
            // 
            this.SaveBt.Caption = "Guardar";
            this.SaveBt.Id = 1;
            this.SaveBt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("SaveBt.ImageOptions.SvgImage")));
            this.SaveBt.Name = "SaveBt";
            this.SaveBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.SaveBt_ItemClick);
            // 
            // DeleteBt
            // 
            this.DeleteBt.Caption = "Eliminar";
            this.DeleteBt.Id = 2;
            this.DeleteBt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("DeleteBt.ImageOptions.SvgImage")));
            this.DeleteBt.Name = "DeleteBt";
            this.DeleteBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.DeleteBt_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Usuario";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.SaveBt);
            this.ribbonPageGroup1.ItemLinks.Add(this.DeleteBt);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 272);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(635, 24);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.groupControl4, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(635, 114);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // tableLayoutPanel2
            // 
            this.tableLayoutPanel2.ColumnCount = 3;
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel2.Controls.Add(this.groupControl1, 0, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl2, 1, 0);
            this.tableLayoutPanel2.Controls.Add(this.groupControl3, 2, 0);
            this.tableLayoutPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel2.Location = new System.Drawing.Point(3, 3);
            this.tableLayoutPanel2.Name = "tableLayoutPanel2";
            this.tableLayoutPanel2.RowCount = 1;
            this.tableLayoutPanel2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel2.Size = new System.Drawing.Size(629, 51);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.NombreTx);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(203, 45);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Nombre";
            // 
            // NombreTx
            // 
            this.NombreTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.NombreTx.Location = new System.Drawing.Point(2, 23);
            this.NombreTx.MenuManager = this.ribbon;
            this.NombreTx.Name = "NombreTx";
            this.NombreTx.Properties.AccessibleName = "Nombre";
            this.NombreTx.Size = new System.Drawing.Size(199, 20);
            this.NombreTx.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.UsuarioTx);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(212, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(203, 45);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Usuario";
            // 
            // UsuarioTx
            // 
            this.UsuarioTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuarioTx.Location = new System.Drawing.Point(2, 23);
            this.UsuarioTx.MenuManager = this.ribbon;
            this.UsuarioTx.Name = "UsuarioTx";
            this.UsuarioTx.Properties.AccessibleName = "Usuario";
            this.UsuarioTx.Size = new System.Drawing.Size(199, 20);
            this.UsuarioTx.TabIndex = 0;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.PwdTx);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(421, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(205, 45);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Contraseña";
            // 
            // PwdTx
            // 
            this.PwdTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PwdTx.EditValue = "";
            this.PwdTx.Location = new System.Drawing.Point(2, 23);
            this.PwdTx.MenuManager = this.ribbon;
            this.PwdTx.Name = "PwdTx";
            this.PwdTx.Properties.AccessibleName = "Contraseña";
            this.PwdTx.Properties.PasswordChar = '*';
            this.PwdTx.Size = new System.Drawing.Size(201, 20);
            this.PwdTx.TabIndex = 0;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.TiendaLu);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(3, 60);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(629, 51);
            this.groupControl4.TabIndex = 1;
            this.groupControl4.Text = "Tienda";
            // 
            // TiendaLu
            // 
            this.TiendaLu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TiendaLu.Location = new System.Drawing.Point(2, 23);
            this.TiendaLu.MenuManager = this.ribbon;
            this.TiendaLu.Name = "TiendaLu";
            this.TiendaLu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TiendaLu.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ID", "ID", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.None, DevExpress.Utils.DefaultBoolean.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Nombre", "Nombre")});
            this.TiendaLu.Properties.DisplayMember = "Nombre";
            this.TiendaLu.Properties.ValueMember = "ID";
            this.TiendaLu.Size = new System.Drawing.Size(625, 20);
            this.TiendaLu.TabIndex = 0;
            // 
            // Usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 296);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Usuario";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Usuario";
            this.Load += new System.EventHandler(this.Usuario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NombreTx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UsuarioTx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PwdTx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TiendaLu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem SaveBt;
        private DevExpress.XtraBars.BarButtonItem DeleteBt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit NombreTx;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit UsuarioTx;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.TextEdit PwdTx;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LookUpEdit TiendaLu;
    }
}
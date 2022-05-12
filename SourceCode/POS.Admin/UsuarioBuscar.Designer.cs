
namespace POS.Admin
{
    partial class UsuarioBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UsuarioBuscar));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BuscarBt = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.UsuariosGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Usuario = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Pwd = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FK_Tienda = new DevExpress.XtraGrid.Columns.GridColumn();
            this.TiendaLu = new DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit();
            this.repositoryItemSearchLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FK_Licencia = new DevExpress.XtraGrid.Columns.GridColumn();
            this.NombreT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ActivaT = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Activa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.isAdmin = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaLu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.BuscarBt});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(442, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            // 
            // BuscarBt
            // 
            this.BuscarBt.Caption = "Buscar";
            this.BuscarBt.Id = 1;
            this.BuscarBt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BuscarBt.ImageOptions.SvgImage")));
            this.BuscarBt.Name = "BuscarBt";
            this.BuscarBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BuscarBt_ItemClick);
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Buscar Usuario";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BuscarBt);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Buscar Usuario";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 24);
            // 
            // UsuariosGrid
            // 
            this.UsuariosGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UsuariosGrid.Location = new System.Drawing.Point(0, 158);
            this.UsuariosGrid.MainView = this.gridView1;
            this.UsuariosGrid.MenuManager = this.ribbon;
            this.UsuariosGrid.Name = "UsuariosGrid";
            this.UsuariosGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.TiendaLu});
            this.UsuariosGrid.Size = new System.Drawing.Size(442, 267);
            this.UsuariosGrid.TabIndex = 2;
            this.UsuariosGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.Nombre,
            this.Usuario,
            this.Pwd,
            this.FK_Tienda,
            this.Activa,
            this.isAdmin});
            this.gridView1.GridControl = this.UsuariosGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            this.gridView1.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.gridView1_RowClick);
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Nombre";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 0;
            // 
            // Usuario
            // 
            this.Usuario.Caption = "Usuario";
            this.Usuario.FieldName = "Usuario";
            this.Usuario.Name = "Usuario";
            this.Usuario.Visible = true;
            this.Usuario.VisibleIndex = 1;
            // 
            // Pwd
            // 
            this.Pwd.Caption = "Pwd";
            this.Pwd.FieldName = "Pwd";
            this.Pwd.Name = "Pwd";
            // 
            // FK_Tienda
            // 
            this.FK_Tienda.Caption = "Tienda";
            this.FK_Tienda.ColumnEdit = this.TiendaLu;
            this.FK_Tienda.FieldName = "FK_Tienda";
            this.FK_Tienda.Name = "FK_Tienda";
            this.FK_Tienda.Visible = true;
            this.FK_Tienda.VisibleIndex = 2;
            // 
            // TiendaLu
            // 
            this.TiendaLu.AutoHeight = false;
            this.TiendaLu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TiendaLu.DisplayMember = "Nombre";
            this.TiendaLu.Name = "TiendaLu";
            this.TiendaLu.PopupView = this.repositoryItemSearchLookUpEdit1View;
            this.TiendaLu.ValueMember = "ID";
            // 
            // repositoryItemSearchLookUpEdit1View
            // 
            this.repositoryItemSearchLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDT,
            this.FK_Licencia,
            this.NombreT,
            this.ActivaT});
            this.repositoryItemSearchLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.repositoryItemSearchLookUpEdit1View.Name = "repositoryItemSearchLookUpEdit1View";
            this.repositoryItemSearchLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.repositoryItemSearchLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // IDT
            // 
            this.IDT.Caption = "ID";
            this.IDT.FieldName = "ID";
            this.IDT.Name = "IDT";
            this.IDT.Visible = true;
            this.IDT.VisibleIndex = 0;
            // 
            // FK_Licencia
            // 
            this.FK_Licencia.Caption = "FK_Licencia";
            this.FK_Licencia.FieldName = "FK_Licencia";
            this.FK_Licencia.Name = "FK_Licencia";
            this.FK_Licencia.Visible = true;
            this.FK_Licencia.VisibleIndex = 1;
            // 
            // NombreT
            // 
            this.NombreT.Caption = "Nombre";
            this.NombreT.FieldName = "Nombre";
            this.NombreT.Name = "NombreT";
            this.NombreT.Visible = true;
            this.NombreT.VisibleIndex = 2;
            // 
            // ActivaT
            // 
            this.ActivaT.Caption = "Activa";
            this.ActivaT.FieldName = "Activa";
            this.ActivaT.Name = "ActivaT";
            this.ActivaT.Visible = true;
            this.ActivaT.VisibleIndex = 3;
            // 
            // Activa
            // 
            this.Activa.Caption = "Activa";
            this.Activa.FieldName = "Activa";
            this.Activa.Name = "Activa";
            this.Activa.Visible = true;
            this.Activa.VisibleIndex = 3;
            // 
            // isAdmin
            // 
            this.isAdmin.Caption = "Administrador";
            this.isAdmin.FieldName = "isAdmin";
            this.isAdmin.Name = "isAdmin";
            // 
            // UsuarioBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.UsuariosGrid);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "UsuarioBuscar";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "UsuarioBuscar";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UsuariosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaLu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemSearchLookUpEdit1View)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BuscarBt;
        private DevExpress.XtraGrid.GridControl UsuariosGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn Usuario;
        private DevExpress.XtraGrid.Columns.GridColumn Pwd;
        private DevExpress.XtraGrid.Columns.GridColumn FK_Tienda;
        private DevExpress.XtraEditors.Repository.RepositoryItemSearchLookUpEdit TiendaLu;
        private DevExpress.XtraGrid.Views.Grid.GridView repositoryItemSearchLookUpEdit1View;
        private DevExpress.XtraGrid.Columns.GridColumn Activa;
        private DevExpress.XtraGrid.Columns.GridColumn isAdmin;
        private DevExpress.XtraGrid.Columns.GridColumn IDT;
        private DevExpress.XtraGrid.Columns.GridColumn FK_Licencia;
        private DevExpress.XtraGrid.Columns.GridColumn NombreT;
        private DevExpress.XtraGrid.Columns.GridColumn ActivaT;
    }
}
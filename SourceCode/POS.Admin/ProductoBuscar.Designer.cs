
namespace POS.Admin
{
    partial class ProductoBuscar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ProductoBuscar));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.BuscarBt = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.ProductosGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FK_Categoria = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CatLu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UPC = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Descripcion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Presentacion = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Costo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Precio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FK_Envase = new DevExpress.XtraGrid.Columns.GridColumn();
            this.EnvaseLu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.FK_Unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnidadLu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatLu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvaseLu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadLu)).BeginInit();
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
            this.ribbonPage1.Text = "Buscar Producto";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BuscarBt);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Buscar Producto";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 24);
            // 
            // ProductosGrid
            // 
            this.ProductosGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductosGrid.Location = new System.Drawing.Point(0, 158);
            this.ProductosGrid.MainView = this.gridView1;
            this.ProductosGrid.MenuManager = this.ribbon;
            this.ProductosGrid.Name = "ProductosGrid";
            this.ProductosGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.CatLu,
            this.EnvaseLu,
            this.UnidadLu});
            this.ProductosGrid.Size = new System.Drawing.Size(442, 267);
            this.ProductosGrid.TabIndex = 2;
            this.ProductosGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.FK_Categoria,
            this.UPC,
            this.Descripcion,
            this.Presentacion,
            this.Costo,
            this.Precio,
            this.FK_Envase,
            this.FK_Unidad});
            this.gridView1.GridControl = this.ProductosGrid;
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
            // FK_Categoria
            // 
            this.FK_Categoria.Caption = "Categoria";
            this.FK_Categoria.ColumnEdit = this.CatLu;
            this.FK_Categoria.FieldName = "FK_Categoria";
            this.FK_Categoria.Name = "FK_Categoria";
            this.FK_Categoria.Visible = true;
            this.FK_Categoria.VisibleIndex = 0;
            this.FK_Categoria.Width = 142;
            // 
            // CatLu
            // 
            this.CatLu.AutoHeight = false;
            this.CatLu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CatLu.DisplayMember = "Descripcion";
            this.CatLu.Name = "CatLu";
            this.CatLu.ValueMember = "ID";
            // 
            // UPC
            // 
            this.UPC.Caption = "UPC";
            this.UPC.FieldName = "UPC";
            this.UPC.Name = "UPC";
            this.UPC.Visible = true;
            this.UPC.VisibleIndex = 1;
            this.UPC.Width = 114;
            // 
            // Descripcion
            // 
            this.Descripcion.Caption = "Descripcion";
            this.Descripcion.FieldName = "Descripcion";
            this.Descripcion.Name = "Descripcion";
            this.Descripcion.Visible = true;
            this.Descripcion.VisibleIndex = 2;
            this.Descripcion.Width = 650;
            // 
            // Presentacion
            // 
            this.Presentacion.Caption = "Presentacion";
            this.Presentacion.FieldName = "Presentacion";
            this.Presentacion.Name = "Presentacion";
            this.Presentacion.Visible = true;
            this.Presentacion.VisibleIndex = 5;
            this.Presentacion.Width = 138;
            // 
            // Costo
            // 
            this.Costo.Caption = "Costo";
            this.Costo.DisplayFormat.FormatString = "C2";
            this.Costo.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Costo.FieldName = "Costo";
            this.Costo.Name = "Costo";
            this.Costo.Visible = true;
            this.Costo.VisibleIndex = 6;
            this.Costo.Width = 138;
            // 
            // Precio
            // 
            this.Precio.Caption = "Precio";
            this.Precio.DisplayFormat.FormatString = "C2";
            this.Precio.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.Precio.FieldName = "Precio";
            this.Precio.Name = "Precio";
            this.Precio.Visible = true;
            this.Precio.VisibleIndex = 7;
            this.Precio.Width = 157;
            // 
            // FK_Envase
            // 
            this.FK_Envase.Caption = "Envase";
            this.FK_Envase.ColumnEdit = this.EnvaseLu;
            this.FK_Envase.FieldName = "FK_Envase";
            this.FK_Envase.Name = "FK_Envase";
            this.FK_Envase.Visible = true;
            this.FK_Envase.VisibleIndex = 4;
            this.FK_Envase.Width = 138;
            // 
            // EnvaseLu
            // 
            this.EnvaseLu.AutoHeight = false;
            this.EnvaseLu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EnvaseLu.DisplayMember = "Descripcion";
            this.EnvaseLu.Name = "EnvaseLu";
            this.EnvaseLu.ValueMember = "ID";
            // 
            // FK_Unidad
            // 
            this.FK_Unidad.Caption = "Unidad";
            this.FK_Unidad.ColumnEdit = this.UnidadLu;
            this.FK_Unidad.FieldName = "FK_Unidad";
            this.FK_Unidad.Name = "FK_Unidad";
            this.FK_Unidad.Visible = true;
            this.FK_Unidad.VisibleIndex = 3;
            this.FK_Unidad.Width = 138;
            // 
            // UnidadLu
            // 
            this.UnidadLu.AutoHeight = false;
            this.UnidadLu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.UnidadLu.DisplayMember = "Descripcion";
            this.UnidadLu.Name = "UnidadLu";
            this.UnidadLu.ValueMember = "ID";
            // 
            // ProductoBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.ProductosGrid);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "ProductoBuscar";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Buscar Producto";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CatLu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EnvaseLu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadLu)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem BuscarBt;
        private DevExpress.XtraGrid.GridControl ProductosGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn FK_Categoria;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit CatLu;
        private DevExpress.XtraGrid.Columns.GridColumn UPC;
        private DevExpress.XtraGrid.Columns.GridColumn Descripcion;
        private DevExpress.XtraGrid.Columns.GridColumn Presentacion;
        private DevExpress.XtraGrid.Columns.GridColumn Costo;
        private DevExpress.XtraGrid.Columns.GridColumn Precio;
        private DevExpress.XtraGrid.Columns.GridColumn FK_Envase;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit EnvaseLu;
        private DevExpress.XtraGrid.Columns.GridColumn FK_Unidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit UnidadLu;
    }
}
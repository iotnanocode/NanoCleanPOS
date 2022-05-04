
namespace POS.Admin
{
    partial class Existencias
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Existencias));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.BuscarBt = new DevExpress.XtraBars.BarButtonItem();
            this.ExistenciasGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FK_Producto = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FK_Almacen = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Cantidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.FK_Unidad = new DevExpress.XtraGrid.Columns.GridColumn();
            this.CostoPromedio = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Activa = new DevExpress.XtraGrid.Columns.GridColumn();
            this.ProductoLu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.AlmacenLu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.UnidadLu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistenciasGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoLu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenLu)).BeginInit();
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Existencias";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.BuscarBt);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Existencias";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(442, 24);
            // 
            // BuscarBt
            // 
            this.BuscarBt.Caption = "Buscar";
            this.BuscarBt.Id = 1;
            this.BuscarBt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BuscarBt.ImageOptions.SvgImage")));
            this.BuscarBt.Name = "BuscarBt";
            this.BuscarBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BuscarBt_ItemClick);
            // 
            // ExistenciasGrid
            // 
            this.ExistenciasGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ExistenciasGrid.Location = new System.Drawing.Point(0, 158);
            this.ExistenciasGrid.MainView = this.gridView1;
            this.ExistenciasGrid.MenuManager = this.ribbon;
            this.ExistenciasGrid.Name = "ExistenciasGrid";
            this.ExistenciasGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.ProductoLu,
            this.AlmacenLu,
            this.UnidadLu});
            this.ExistenciasGrid.Size = new System.Drawing.Size(442, 267);
            this.ExistenciasGrid.TabIndex = 2;
            this.ExistenciasGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.FK_Producto,
            this.FK_Almacen,
            this.Cantidad,
            this.FK_Unidad,
            this.CostoPromedio,
            this.Activa});
            this.gridView1.GridControl = this.ExistenciasGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowAutoFilterRow = true;
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // FK_Producto
            // 
            this.FK_Producto.Caption = "Producto";
            this.FK_Producto.ColumnEdit = this.ProductoLu;
            this.FK_Producto.FieldName = "FK_Producto";
            this.FK_Producto.Name = "FK_Producto";
            this.FK_Producto.Visible = true;
            this.FK_Producto.VisibleIndex = 0;
            this.FK_Producto.Width = 657;
            // 
            // FK_Almacen
            // 
            this.FK_Almacen.Caption = "Almacen";
            this.FK_Almacen.ColumnEdit = this.AlmacenLu;
            this.FK_Almacen.FieldName = "FK_Almacen";
            this.FK_Almacen.Name = "FK_Almacen";
            this.FK_Almacen.Visible = true;
            this.FK_Almacen.VisibleIndex = 1;
            this.FK_Almacen.Width = 239;
            // 
            // Cantidad
            // 
            this.Cantidad.Caption = "Cantidad";
            this.Cantidad.FieldName = "Cantidad";
            this.Cantidad.Name = "Cantidad";
            this.Cantidad.Visible = true;
            this.Cantidad.VisibleIndex = 2;
            this.Cantidad.Width = 239;
            // 
            // FK_Unidad
            // 
            this.FK_Unidad.Caption = "Unidad";
            this.FK_Unidad.ColumnEdit = this.UnidadLu;
            this.FK_Unidad.FieldName = "FK_Unidad";
            this.FK_Unidad.Name = "FK_Unidad";
            this.FK_Unidad.Visible = true;
            this.FK_Unidad.VisibleIndex = 3;
            this.FK_Unidad.Width = 239;
            // 
            // CostoPromedio
            // 
            this.CostoPromedio.Caption = "Costo Promedio";
            this.CostoPromedio.FieldName = "CostoPromedio";
            this.CostoPromedio.Name = "CostoPromedio";
            this.CostoPromedio.Visible = true;
            this.CostoPromedio.VisibleIndex = 4;
            this.CostoPromedio.Width = 241;
            // 
            // Activa
            // 
            this.Activa.Caption = "Activa";
            this.Activa.FieldName = "Activa";
            this.Activa.Name = "Activa";
            // 
            // ProductoLu
            // 
            this.ProductoLu.AutoHeight = false;
            this.ProductoLu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ProductoLu.DisplayMember = "Descripcion";
            this.ProductoLu.Name = "ProductoLu";
            this.ProductoLu.ValueMember = "ID";
            // 
            // AlmacenLu
            // 
            this.AlmacenLu.AutoHeight = false;
            this.AlmacenLu.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AlmacenLu.DisplayMember = "Descripcion";
            this.AlmacenLu.Name = "AlmacenLu";
            this.AlmacenLu.ValueMember = "ID";
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
            // Existencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(442, 449);
            this.Controls.Add(this.ExistenciasGrid);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "Existencias";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Existencias";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExistenciasGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ProductoLu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenLu)).EndInit();
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
        private DevExpress.XtraGrid.GridControl ExistenciasGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn FK_Producto;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit ProductoLu;
        private DevExpress.XtraGrid.Columns.GridColumn FK_Almacen;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit AlmacenLu;
        private DevExpress.XtraGrid.Columns.GridColumn Cantidad;
        private DevExpress.XtraGrid.Columns.GridColumn FK_Unidad;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit UnidadLu;
        private DevExpress.XtraGrid.Columns.GridColumn CostoPromedio;
        private DevExpress.XtraGrid.Columns.GridColumn Activa;
    }
}
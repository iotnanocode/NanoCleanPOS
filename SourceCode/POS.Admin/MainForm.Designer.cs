
namespace POS.Admin
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.TiendasBuscarBt = new DevExpress.XtraBars.BarButtonItem();
            this.NewTiendaBt = new DevExpress.XtraBars.BarButtonItem();
            this.StatusLabel = new DevExpress.XtraBars.BarStaticItem();
            this.UserRLabel = new DevExpress.XtraBars.BarStaticItem();
            this.BuscarAlmBt = new DevExpress.XtraBars.BarButtonItem();
            this.NewAlmBt = new DevExpress.XtraBars.BarButtonItem();
            this.BuscarProductoBt = new DevExpress.XtraBars.BarButtonItem();
            this.NewProductBt = new DevExpress.XtraBars.BarButtonItem();
            this.BuscarMovBt = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem4 = new DevExpress.XtraBars.BarButtonItem();
            this.barButtonItem3 = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage2 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup2 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup5 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup6 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPageGroup7 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage3 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup3 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonPage4 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup4 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.barButtonItem5 = new DevExpress.XtraBars.BarButtonItem();
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.barButtonItem1,
            this.barButtonItem2,
            this.TiendasBuscarBt,
            this.NewTiendaBt,
            this.StatusLabel,
            this.UserRLabel,
            this.BuscarAlmBt,
            this.NewAlmBt,
            this.BuscarProductoBt,
            this.NewProductBt,
            this.BuscarMovBt,
            this.barButtonItem4,
            this.barButtonItem3,
            this.barButtonItem5});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 15;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1,
            this.ribbonPage2,
            this.ribbonPage3,
            this.ribbonPage4});
            this.ribbon.Size = new System.Drawing.Size(692, 158);
            this.ribbon.StatusBar = this.ribbonStatusBar;
            this.ribbon.Merge += new DevExpress.XtraBars.Ribbon.RibbonMergeEventHandler(this.ribbon_Merge);
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Buscar";
            this.barButtonItem1.Id = 1;
            this.barButtonItem1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem1.ImageOptions.SvgImage")));
            this.barButtonItem1.Name = "barButtonItem1";
            this.barButtonItem1.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem1_ItemClick);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Nuevo";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem2.ImageOptions.SvgImage")));
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem2_ItemClick);
            // 
            // TiendasBuscarBt
            // 
            this.TiendasBuscarBt.Caption = "Buscar";
            this.TiendasBuscarBt.Id = 3;
            this.TiendasBuscarBt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("TiendasBuscarBt.ImageOptions.SvgImage")));
            this.TiendasBuscarBt.Name = "TiendasBuscarBt";
            this.TiendasBuscarBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.TiendasBuscarBt_ItemClick);
            // 
            // NewTiendaBt
            // 
            this.NewTiendaBt.Caption = "Nueva";
            this.NewTiendaBt.Id = 4;
            this.NewTiendaBt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NewTiendaBt.ImageOptions.SvgImage")));
            this.NewTiendaBt.Name = "NewTiendaBt";
            this.NewTiendaBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewTiendaBt_ItemClick);
            // 
            // StatusLabel
            // 
            this.StatusLabel.Caption = "Version: ";
            this.StatusLabel.Id = 5;
            this.StatusLabel.Name = "StatusLabel";
            // 
            // UserRLabel
            // 
            this.UserRLabel.Caption = "User";
            this.UserRLabel.Id = 6;
            this.UserRLabel.Name = "UserRLabel";
            // 
            // BuscarAlmBt
            // 
            this.BuscarAlmBt.Caption = "Buscar Almacen";
            this.BuscarAlmBt.Id = 7;
            this.BuscarAlmBt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BuscarAlmBt.ImageOptions.SvgImage")));
            this.BuscarAlmBt.Name = "BuscarAlmBt";
            this.BuscarAlmBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BuscarAlmBt_ItemClick);
            // 
            // NewAlmBt
            // 
            this.NewAlmBt.Caption = "Nuevo Almacen";
            this.NewAlmBt.Id = 8;
            this.NewAlmBt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NewAlmBt.ImageOptions.SvgImage")));
            this.NewAlmBt.Name = "NewAlmBt";
            this.NewAlmBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewAlmBt_ItemClick);
            // 
            // BuscarProductoBt
            // 
            this.BuscarProductoBt.Caption = "Buscar Producto";
            this.BuscarProductoBt.Id = 9;
            this.BuscarProductoBt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BuscarProductoBt.ImageOptions.SvgImage")));
            this.BuscarProductoBt.Name = "BuscarProductoBt";
            this.BuscarProductoBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BuscarProductoBt_ItemClick);
            // 
            // NewProductBt
            // 
            this.NewProductBt.Caption = "Nuevo Producto";
            this.NewProductBt.Id = 10;
            this.NewProductBt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("NewProductBt.ImageOptions.SvgImage")));
            this.NewProductBt.Name = "NewProductBt";
            this.NewProductBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.NewProductBt_ItemClick);
            // 
            // BuscarMovBt
            // 
            this.BuscarMovBt.Caption = "Buscar Movimientos";
            this.BuscarMovBt.Id = 11;
            this.BuscarMovBt.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("BuscarMovBt.ImageOptions.SvgImage")));
            this.BuscarMovBt.Name = "BuscarMovBt";
            this.BuscarMovBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.BuscarMovBt_ItemClick);
            // 
            // barButtonItem4
            // 
            this.barButtonItem4.Caption = "Nuevo Movimiento";
            this.barButtonItem4.Id = 12;
            this.barButtonItem4.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem4.ImageOptions.SvgImage")));
            this.barButtonItem4.Name = "barButtonItem4";
            this.barButtonItem4.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem4_ItemClick);
            // 
            // barButtonItem3
            // 
            this.barButtonItem3.Caption = "barButtonItem3";
            this.barButtonItem3.Id = 13;
            this.barButtonItem3.Name = "barButtonItem3";
            // 
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Usuarios";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem1);
            this.ribbonPageGroup1.ItemLinks.Add(this.barButtonItem2);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // ribbonPage2
            // 
            this.ribbonPage2.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup2,
            this.ribbonPageGroup5,
            this.ribbonPageGroup6,
            this.ribbonPageGroup7});
            this.ribbonPage2.Name = "ribbonPage2";
            this.ribbonPage2.Text = "Inventarios";
            // 
            // ribbonPageGroup2
            // 
            this.ribbonPageGroup2.ItemLinks.Add(this.BuscarProductoBt);
            this.ribbonPageGroup2.ItemLinks.Add(this.NewProductBt);
            this.ribbonPageGroup2.Name = "ribbonPageGroup2";
            this.ribbonPageGroup2.Text = "Productos";
            // 
            // ribbonPageGroup5
            // 
            this.ribbonPageGroup5.ItemLinks.Add(this.BuscarAlmBt);
            this.ribbonPageGroup5.ItemLinks.Add(this.NewAlmBt);
            this.ribbonPageGroup5.Name = "ribbonPageGroup5";
            this.ribbonPageGroup5.Text = "Almacenes";
            // 
            // ribbonPageGroup6
            // 
            this.ribbonPageGroup6.ItemLinks.Add(this.barButtonItem5);
            this.ribbonPageGroup6.Name = "ribbonPageGroup6";
            this.ribbonPageGroup6.Text = "Existencias";
            // 
            // ribbonPageGroup7
            // 
            this.ribbonPageGroup7.ItemLinks.Add(this.BuscarMovBt);
            this.ribbonPageGroup7.ItemLinks.Add(this.barButtonItem4);
            this.ribbonPageGroup7.Name = "ribbonPageGroup7";
            this.ribbonPageGroup7.Text = "Movimientos";
            // 
            // ribbonPage3
            // 
            this.ribbonPage3.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup3});
            this.ribbonPage3.Name = "ribbonPage3";
            this.ribbonPage3.Text = "Produccion";
            // 
            // ribbonPageGroup3
            // 
            this.ribbonPageGroup3.Name = "ribbonPageGroup3";
            this.ribbonPageGroup3.Text = "ribbonPageGroup3";
            // 
            // ribbonPage4
            // 
            this.ribbonPage4.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup4});
            this.ribbonPage4.Name = "ribbonPage4";
            this.ribbonPage4.Text = "Tiendas";
            // 
            // ribbonPageGroup4
            // 
            this.ribbonPageGroup4.ItemLinks.Add(this.TiendasBuscarBt);
            this.ribbonPageGroup4.ItemLinks.Add(this.NewTiendaBt);
            this.ribbonPageGroup4.Name = "ribbonPageGroup4";
            this.ribbonPageGroup4.Text = "Acciones";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.ItemLinks.Add(this.StatusLabel);
            this.ribbonStatusBar.ItemLinks.Add(this.UserRLabel);
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 425);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(692, 24);
            // 
            // barButtonItem5
            // 
            this.barButtonItem5.Caption = "Buscar Existencias";
            this.barButtonItem5.Id = 14;
            this.barButtonItem5.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("barButtonItem5.ImageOptions.SvgImage")));
            this.barButtonItem5.Name = "barButtonItem5";
            this.barButtonItem5.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.barButtonItem5_ItemClick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 449);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.IsMdiContainer = true;
            this.Name = "MainForm";
            this.Ribbon = this.ribbon;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "Nanoclean Admin POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage2;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup2;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage3;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup3;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage4;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup4;
        private DevExpress.XtraBars.BarButtonItem TiendasBuscarBt;
        private DevExpress.XtraBars.BarButtonItem NewTiendaBt;
        private DevExpress.XtraBars.BarStaticItem StatusLabel;
        private DevExpress.XtraBars.BarStaticItem UserRLabel;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup5;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup6;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup7;
        private DevExpress.XtraBars.BarButtonItem BuscarAlmBt;
        private DevExpress.XtraBars.BarButtonItem NewAlmBt;
        private DevExpress.XtraBars.BarButtonItem BuscarProductoBt;
        private DevExpress.XtraBars.BarButtonItem NewProductBt;
        private DevExpress.XtraBars.BarButtonItem BuscarMovBt;
        private DevExpress.XtraBars.BarButtonItem barButtonItem4;
        private DevExpress.XtraBars.BarButtonItem barButtonItem3;
        private DevExpress.XtraBars.BarButtonItem barButtonItem5;
    }
}
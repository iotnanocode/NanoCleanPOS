
namespace POS
{
    partial class ConfigForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConfigForm));
            this.ribbon = new DevExpress.XtraBars.Ribbon.RibbonControl();
            this.SaveBt = new DevExpress.XtraBars.BarButtonItem();
            this.ribbonPage1 = new DevExpress.XtraBars.Ribbon.RibbonPage();
            this.ribbonPageGroup1 = new DevExpress.XtraBars.Ribbon.RibbonPageGroup();
            this.ribbonStatusBar = new DevExpress.XtraBars.Ribbon.RibbonStatusBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.tableLayoutPanel2 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.TiendaLu = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit1View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.IDCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Nombre = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.AlmacenLu = new DevExpress.XtraEditors.GridLookUpEdit();
            this.gridLookUpEdit2View = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.ID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.DescripcionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UbicacionCol = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ImpresoraRg = new DevExpress.XtraEditors.RadioGroup();
            this.tableLayoutPanel3 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.TecladoTs = new DevExpress.XtraEditors.ToggleSwitch();
            this.groupControl5 = new DevExpress.XtraEditors.GroupControl();
            this.ProductosTs = new DevExpress.XtraEditors.ToggleSwitch();
            this.groupControl6 = new DevExpress.XtraEditors.GroupControl();
            this.MetodosPagoTs = new DevExpress.XtraEditors.ToggleSwitch();
            this.tableLayoutPanel4 = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl7 = new DevExpress.XtraEditors.GroupControl();
            this.EncabezadoPic = new System.Windows.Forms.PictureBox();
            this.groupControl8 = new DevExpress.XtraEditors.GroupControl();
            this.FondoPic = new System.Windows.Forms.PictureBox();
            this.OFImage = new DevExpress.XtraEditors.XtraOpenFileDialog(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            this.tableLayoutPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TiendaLu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenLu.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ImpresoraRg.Properties)).BeginInit();
            this.tableLayoutPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TecladoTs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).BeginInit();
            this.groupControl5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProductosTs.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).BeginInit();
            this.groupControl6.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.MetodosPagoTs.Properties)).BeginInit();
            this.tableLayoutPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).BeginInit();
            this.groupControl7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).BeginInit();
            this.groupControl8.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FondoPic)).BeginInit();
            this.SuspendLayout();
            // 
            // ribbon
            // 
            this.ribbon.ExpandCollapseItem.Id = 0;
            this.ribbon.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.ribbon.ExpandCollapseItem,
            this.ribbon.SearchEditItem,
            this.SaveBt});
            this.ribbon.Location = new System.Drawing.Point(0, 0);
            this.ribbon.MaxItemId = 2;
            this.ribbon.Name = "ribbon";
            this.ribbon.Pages.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPage[] {
            this.ribbonPage1});
            this.ribbon.Size = new System.Drawing.Size(698, 158);
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
            // ribbonPage1
            // 
            this.ribbonPage1.Groups.AddRange(new DevExpress.XtraBars.Ribbon.RibbonPageGroup[] {
            this.ribbonPageGroup1});
            this.ribbonPage1.Name = "ribbonPage1";
            this.ribbonPage1.Text = "Configuraciones";
            // 
            // ribbonPageGroup1
            // 
            this.ribbonPageGroup1.ItemLinks.Add(this.SaveBt);
            this.ribbonPageGroup1.Name = "ribbonPageGroup1";
            this.ribbonPageGroup1.Text = "Acciones";
            // 
            // ribbonStatusBar
            // 
            this.ribbonStatusBar.Location = new System.Drawing.Point(0, 499);
            this.ribbonStatusBar.Name = "ribbonStatusBar";
            this.ribbonStatusBar.Ribbon = this.ribbon;
            this.ribbonStatusBar.Size = new System.Drawing.Size(698, 24);
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel2, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel3, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.tableLayoutPanel4, 0, 2);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 158);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 65F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(698, 341);
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
            this.tableLayoutPanel2.Size = new System.Drawing.Size(692, 59);
            this.tableLayoutPanel2.TabIndex = 0;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.TiendaLu);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(224, 53);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Tienda";
            // 
            // TiendaLu
            // 
            this.TiendaLu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TiendaLu.Location = new System.Drawing.Point(2, 23);
            this.TiendaLu.MenuManager = this.ribbon;
            this.TiendaLu.Name = "TiendaLu";
            this.TiendaLu.Properties.AccessibleName = "Tienda";
            this.TiendaLu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.TiendaLu.Properties.DisplayMember = "Nombre";
            this.TiendaLu.Properties.PopupView = this.gridLookUpEdit1View;
            this.TiendaLu.Properties.ValueMember = "ID";
            this.TiendaLu.Size = new System.Drawing.Size(220, 20);
            this.TiendaLu.TabIndex = 0;
            // 
            // gridLookUpEdit1View
            // 
            this.gridLookUpEdit1View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.IDCol,
            this.Nombre});
            this.gridLookUpEdit1View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit1View.Name = "gridLookUpEdit1View";
            this.gridLookUpEdit1View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit1View.OptionsView.ShowGroupPanel = false;
            // 
            // IDCol
            // 
            this.IDCol.Caption = "ID";
            this.IDCol.FieldName = "ID";
            this.IDCol.Name = "IDCol";
            // 
            // Nombre
            // 
            this.Nombre.Caption = "Tienda";
            this.Nombre.FieldName = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Visible = true;
            this.Nombre.VisibleIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.AlmacenLu);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(233, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(224, 53);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Almacen";
            // 
            // AlmacenLu
            // 
            this.AlmacenLu.Dock = System.Windows.Forms.DockStyle.Fill;
            this.AlmacenLu.Location = new System.Drawing.Point(2, 23);
            this.AlmacenLu.MenuManager = this.ribbon;
            this.AlmacenLu.Name = "AlmacenLu";
            this.AlmacenLu.Properties.AccessibleName = "Almancen";
            this.AlmacenLu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.AlmacenLu.Properties.DisplayMember = "Descripcion";
            this.AlmacenLu.Properties.PopupView = this.gridLookUpEdit2View;
            this.AlmacenLu.Properties.ValueMember = "ID";
            this.AlmacenLu.Size = new System.Drawing.Size(220, 20);
            this.AlmacenLu.TabIndex = 0;
            // 
            // gridLookUpEdit2View
            // 
            this.gridLookUpEdit2View.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.ID,
            this.DescripcionCol,
            this.UbicacionCol});
            this.gridLookUpEdit2View.FocusRectStyle = DevExpress.XtraGrid.Views.Grid.DrawFocusRectStyle.RowFocus;
            this.gridLookUpEdit2View.Name = "gridLookUpEdit2View";
            this.gridLookUpEdit2View.OptionsSelection.EnableAppearanceFocusedCell = false;
            this.gridLookUpEdit2View.OptionsView.ShowGroupPanel = false;
            // 
            // ID
            // 
            this.ID.Caption = "ID";
            this.ID.FieldName = "ID";
            this.ID.Name = "ID";
            // 
            // DescripcionCol
            // 
            this.DescripcionCol.Caption = "Almacen";
            this.DescripcionCol.FieldName = "Descripcion";
            this.DescripcionCol.Name = "DescripcionCol";
            this.DescripcionCol.Visible = true;
            this.DescripcionCol.VisibleIndex = 0;
            this.DescripcionCol.Width = 521;
            // 
            // UbicacionCol
            // 
            this.UbicacionCol.Caption = "Ubicacion";
            this.UbicacionCol.FieldName = "Ubicacion";
            this.UbicacionCol.Name = "UbicacionCol";
            this.UbicacionCol.Visible = true;
            this.UbicacionCol.VisibleIndex = 1;
            this.UbicacionCol.Width = 1094;
            // 
            // groupControl3
            // 
            this.groupControl3.Controls.Add(this.ImpresoraRg);
            this.groupControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl3.Location = new System.Drawing.Point(463, 3);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(226, 53);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Impresora";
            // 
            // ImpresoraRg
            // 
            this.ImpresoraRg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ImpresoraRg.EditValue = true;
            this.ImpresoraRg.Location = new System.Drawing.Point(2, 23);
            this.ImpresoraRg.MenuManager = this.ribbon;
            this.ImpresoraRg.Name = "ImpresoraRg";
            this.ImpresoraRg.Properties.Columns = 2;
            this.ImpresoraRg.Properties.Items.AddRange(new DevExpress.XtraEditors.Controls.RadioGroupItem[] {
            new DevExpress.XtraEditors.Controls.RadioGroupItem(false, "6mm"),
            new DevExpress.XtraEditors.Controls.RadioGroupItem(true, "8mm")});
            this.ImpresoraRg.Size = new System.Drawing.Size(222, 28);
            this.ImpresoraRg.TabIndex = 0;
            // 
            // tableLayoutPanel3
            // 
            this.tableLayoutPanel3.ColumnCount = 3;
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.tableLayoutPanel3.Controls.Add(this.groupControl4, 0, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupControl5, 1, 0);
            this.tableLayoutPanel3.Controls.Add(this.groupControl6, 2, 0);
            this.tableLayoutPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel3.Location = new System.Drawing.Point(3, 68);
            this.tableLayoutPanel3.Name = "tableLayoutPanel3";
            this.tableLayoutPanel3.RowCount = 1;
            this.tableLayoutPanel3.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel3.Size = new System.Drawing.Size(692, 59);
            this.tableLayoutPanel3.TabIndex = 1;
            // 
            // groupControl4
            // 
            this.groupControl4.Controls.Add(this.TecladoTs);
            this.groupControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl4.Location = new System.Drawing.Point(3, 3);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(224, 53);
            this.groupControl4.TabIndex = 0;
            this.groupControl4.Text = "Permite usar teclado";
            // 
            // TecladoTs
            // 
            this.TecladoTs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.TecladoTs.Location = new System.Drawing.Point(2, 23);
            this.TecladoTs.MenuManager = this.ribbon;
            this.TecladoTs.Name = "TecladoTs";
            this.TecladoTs.Properties.OffText = "Off";
            this.TecladoTs.Properties.OnText = "On";
            this.TecladoTs.Size = new System.Drawing.Size(220, 28);
            this.TecladoTs.TabIndex = 0;
            // 
            // groupControl5
            // 
            this.groupControl5.Controls.Add(this.ProductosTs);
            this.groupControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl5.Location = new System.Drawing.Point(233, 3);
            this.groupControl5.Name = "groupControl5";
            this.groupControl5.Size = new System.Drawing.Size(224, 53);
            this.groupControl5.TabIndex = 1;
            this.groupControl5.Text = "Permite agregar productos";
            // 
            // ProductosTs
            // 
            this.ProductosTs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ProductosTs.Location = new System.Drawing.Point(2, 23);
            this.ProductosTs.MenuManager = this.ribbon;
            this.ProductosTs.Name = "ProductosTs";
            this.ProductosTs.Properties.OffText = "Off";
            this.ProductosTs.Properties.OnText = "On";
            this.ProductosTs.Size = new System.Drawing.Size(220, 28);
            this.ProductosTs.TabIndex = 0;
            // 
            // groupControl6
            // 
            this.groupControl6.Controls.Add(this.MetodosPagoTs);
            this.groupControl6.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl6.Location = new System.Drawing.Point(463, 3);
            this.groupControl6.Name = "groupControl6";
            this.groupControl6.Size = new System.Drawing.Size(226, 53);
            this.groupControl6.TabIndex = 2;
            this.groupControl6.Text = "Permite otros metodos de pago";
            // 
            // MetodosPagoTs
            // 
            this.MetodosPagoTs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MetodosPagoTs.Location = new System.Drawing.Point(2, 23);
            this.MetodosPagoTs.MenuManager = this.ribbon;
            this.MetodosPagoTs.Name = "MetodosPagoTs";
            this.MetodosPagoTs.Properties.OffText = "Off";
            this.MetodosPagoTs.Properties.OnText = "On";
            this.MetodosPagoTs.Size = new System.Drawing.Size(222, 28);
            this.MetodosPagoTs.TabIndex = 0;
            // 
            // tableLayoutPanel4
            // 
            this.tableLayoutPanel4.ColumnCount = 2;
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 70F));
            this.tableLayoutPanel4.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 30F));
            this.tableLayoutPanel4.Controls.Add(this.groupControl7, 0, 0);
            this.tableLayoutPanel4.Controls.Add(this.groupControl8, 1, 0);
            this.tableLayoutPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel4.Location = new System.Drawing.Point(3, 133);
            this.tableLayoutPanel4.Name = "tableLayoutPanel4";
            this.tableLayoutPanel4.RowCount = 1;
            this.tableLayoutPanel4.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tableLayoutPanel4.Size = new System.Drawing.Size(692, 205);
            this.tableLayoutPanel4.TabIndex = 2;
            // 
            // groupControl7
            // 
            this.groupControl7.Controls.Add(this.EncabezadoPic);
            this.groupControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl7.Location = new System.Drawing.Point(3, 3);
            this.groupControl7.Name = "groupControl7";
            this.groupControl7.Size = new System.Drawing.Size(478, 199);
            this.groupControl7.TabIndex = 0;
            this.groupControl7.Text = "Encabezado Tickets";
            // 
            // EncabezadoPic
            // 
            this.EncabezadoPic.BackColor = System.Drawing.Color.White;
            this.EncabezadoPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.EncabezadoPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EncabezadoPic.Image = global::POS.Properties.Resources.nanoTicket;
            this.EncabezadoPic.Location = new System.Drawing.Point(2, 23);
            this.EncabezadoPic.Name = "EncabezadoPic";
            this.EncabezadoPic.Size = new System.Drawing.Size(474, 174);
            this.EncabezadoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.EncabezadoPic.TabIndex = 0;
            this.EncabezadoPic.TabStop = false;
            this.EncabezadoPic.Click += new System.EventHandler(this.EncabezadoPic_Click);
            // 
            // groupControl8
            // 
            this.groupControl8.Controls.Add(this.FondoPic);
            this.groupControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl8.Location = new System.Drawing.Point(487, 3);
            this.groupControl8.Name = "groupControl8";
            this.groupControl8.Size = new System.Drawing.Size(202, 199);
            this.groupControl8.TabIndex = 1;
            this.groupControl8.Text = "Fondo de Pantalla";
            // 
            // FondoPic
            // 
            this.FondoPic.BackColor = System.Drawing.Color.White;
            this.FondoPic.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FondoPic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FondoPic.Image = global::POS.Properties.Resources.nanoBG;
            this.FondoPic.Location = new System.Drawing.Point(2, 23);
            this.FondoPic.Name = "FondoPic";
            this.FondoPic.Size = new System.Drawing.Size(198, 174);
            this.FondoPic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.FondoPic.TabIndex = 0;
            this.FondoPic.TabStop = false;
            this.FondoPic.Click += new System.EventHandler(this.FondoPic_Click);
            // 
            // OFImage
            // 
            this.OFImage.Filter = "Archivos de Imagen|*.jpg;*.png;*.bmp;*.jpeg";
            // 
            // ConfigForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(698, 523);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.ribbonStatusBar);
            this.Controls.Add(this.ribbon);
            this.Name = "ConfigForm";
            this.Ribbon = this.ribbon;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.StatusBar = this.ribbonStatusBar;
            this.Text = "POS Configuraciones";
            ((System.ComponentModel.ISupportInitialize)(this.ribbon)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TiendaLu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit1View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.AlmacenLu.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridLookUpEdit2View)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ImpresoraRg.Properties)).EndInit();
            this.tableLayoutPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TecladoTs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl5)).EndInit();
            this.groupControl5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ProductosTs.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl6)).EndInit();
            this.groupControl6.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.MetodosPagoTs.Properties)).EndInit();
            this.tableLayoutPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl7)).EndInit();
            this.groupControl7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EncabezadoPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl8)).EndInit();
            this.groupControl8.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FondoPic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.Ribbon.RibbonControl ribbon;
        private DevExpress.XtraBars.Ribbon.RibbonPage ribbonPage1;
        private DevExpress.XtraBars.Ribbon.RibbonPageGroup ribbonPageGroup1;
        private DevExpress.XtraBars.Ribbon.RibbonStatusBar ribbonStatusBar;
        private DevExpress.XtraBars.BarButtonItem SaveBt;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GridLookUpEdit TiendaLu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit1View;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GridLookUpEdit AlmacenLu;
        private DevExpress.XtraGrid.Views.Grid.GridView gridLookUpEdit2View;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.RadioGroup ImpresoraRg;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel3;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.ToggleSwitch TecladoTs;
        private DevExpress.XtraEditors.GroupControl groupControl5;
        private DevExpress.XtraEditors.ToggleSwitch ProductosTs;
        private DevExpress.XtraEditors.GroupControl groupControl6;
        private DevExpress.XtraEditors.ToggleSwitch MetodosPagoTs;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel4;
        private DevExpress.XtraEditors.GroupControl groupControl7;
        private System.Windows.Forms.PictureBox EncabezadoPic;
        private DevExpress.XtraEditors.GroupControl groupControl8;
        private System.Windows.Forms.PictureBox FondoPic;
        private DevExpress.XtraGrid.Columns.GridColumn IDCol;
        private DevExpress.XtraGrid.Columns.GridColumn Nombre;
        private DevExpress.XtraGrid.Columns.GridColumn ID;
        private DevExpress.XtraGrid.Columns.GridColumn DescripcionCol;
        private DevExpress.XtraGrid.Columns.GridColumn UbicacionCol;
        private DevExpress.XtraEditors.XtraOpenFileDialog OFImage;
    }
}
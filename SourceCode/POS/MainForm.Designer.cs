
namespace POS
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
            this.components = new System.ComponentModel.Container();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.barButtonItem1 = new DevExpress.XtraBars.BarButtonItem();
            this.ConfigBt = new DevExpress.XtraBars.BarButtonItem();
            this.ReportsBt = new DevExpress.XtraBars.BarButtonItem();
            this.bar3 = new DevExpress.XtraBars.Bar();
            this.StatusLabel = new DevExpress.XtraBars.BarStaticItem();
            this.UserRLabel = new DevExpress.XtraBars.BarStaticItem();
            this.VigLb = new DevExpress.XtraBars.BarStaticItem();
            this.LSynctLb = new DevExpress.XtraBars.BarStaticItem();
            this.LoadingBar = new DevExpress.XtraBars.BarEditItem();
            this.repositoryItemProgressBar1 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barStaticItem4 = new DevExpress.XtraBars.BarStaticItem();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.repositoryItemProgressBar2 = new DevExpress.XtraEditors.Repository.RepositoryItemProgressBar();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.PicturePic = new System.Windows.Forms.PictureBox();
            this.MainLayout = new System.Windows.Forms.TableLayoutPanel();
            this.SalesGrid = new DevExpress.XtraGrid.GridControl();
            this.MainView = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.UnidadLu = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.PagosLayout = new System.Windows.Forms.TableLayoutPanel();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.CancelarBt = new DevExpress.XtraEditors.SimpleButton();
            this.SearchLayout = new System.Windows.Forms.TableLayoutPanel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.UPCTx = new DevExpress.XtraEditors.TextEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.SearchTx = new DevExpress.XtraEditors.TextEdit();
            this.FocusTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).BeginInit();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PicturePic)).BeginInit();
            this.MainLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadLu)).BeginInit();
            this.PagosLayout.SuspendLayout();
            this.SearchLayout.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UPCTx.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.SearchTx.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2,
            this.bar3});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.barButtonItem1,
            this.ConfigBt,
            this.ReportsBt,
            this.UserRLabel,
            this.StatusLabel,
            this.VigLb,
            this.LoadingBar,
            this.barStaticItem4,
            this.LSynctLb});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 11;
            this.barManager1.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemProgressBar1,
            this.repositoryItemTextEdit1,
            this.repositoryItemProgressBar2});
            this.barManager1.StatusBar = this.bar3;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.barButtonItem1),
            new DevExpress.XtraBars.LinkPersistInfo(this.ConfigBt),
            new DevExpress.XtraBars.LinkPersistInfo(this.ReportsBt)});
            this.bar2.OptionsBar.AllowQuickCustomization = false;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // barButtonItem1
            // 
            this.barButtonItem1.Caption = "Salir";
            this.barButtonItem1.Id = 0;
            this.barButtonItem1.Name = "barButtonItem1";
            // 
            // ConfigBt
            // 
            this.ConfigBt.Caption = "Configurar";
            this.ConfigBt.Id = 1;
            this.ConfigBt.Name = "ConfigBt";
            this.ConfigBt.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.ConfigBt_ItemClick);
            // 
            // ReportsBt
            // 
            this.ReportsBt.Caption = "Reportes";
            this.ReportsBt.Id = 2;
            this.ReportsBt.Name = "ReportsBt";
            // 
            // bar3
            // 
            this.bar3.BarName = "Status bar";
            this.bar3.CanDockStyle = DevExpress.XtraBars.BarCanDockStyle.Bottom;
            this.bar3.DockCol = 0;
            this.bar3.DockRow = 0;
            this.bar3.DockStyle = DevExpress.XtraBars.BarDockStyle.Bottom;
            this.bar3.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.StatusLabel),
            new DevExpress.XtraBars.LinkPersistInfo(this.UserRLabel),
            new DevExpress.XtraBars.LinkPersistInfo(this.VigLb),
            new DevExpress.XtraBars.LinkPersistInfo(this.LSynctLb),
            new DevExpress.XtraBars.LinkPersistInfo(this.LoadingBar)});
            this.bar3.OptionsBar.AllowQuickCustomization = false;
            this.bar3.OptionsBar.DrawDragBorder = false;
            this.bar3.OptionsBar.UseWholeRow = true;
            this.bar3.Text = "Status bar";
            // 
            // StatusLabel
            // 
            this.StatusLabel.Caption = "Version: ";
            this.StatusLabel.Id = 4;
            this.StatusLabel.Name = "StatusLabel";
            // 
            // UserRLabel
            // 
            this.UserRLabel.Caption = "Usuario: ";
            this.UserRLabel.Id = 3;
            this.UserRLabel.Name = "UserRLabel";
            // 
            // VigLb
            // 
            this.VigLb.Caption = "Licencia: ";
            this.VigLb.Id = 5;
            this.VigLb.Name = "VigLb";
            // 
            // LSynctLb
            // 
            this.LSynctLb.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.LSynctLb.Caption = "Ultima Sincronizacion: ";
            this.LSynctLb.Id = 8;
            this.LSynctLb.Name = "LSynctLb";
            // 
            // LoadingBar
            // 
            this.LoadingBar.Alignment = DevExpress.XtraBars.BarItemLinkAlignment.Right;
            this.LoadingBar.Caption = "Sincronizacion";
            this.LoadingBar.Edit = this.repositoryItemProgressBar1;
            this.LoadingBar.EditWidth = 200;
            this.LoadingBar.Id = 6;
            this.LoadingBar.Name = "LoadingBar";
            // 
            // repositoryItemProgressBar1
            // 
            this.repositoryItemProgressBar1.Name = "repositoryItemProgressBar1";
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(910, 20);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 478);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(910, 22);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 20);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 458);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(910, 20);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 458);
            // 
            // barStaticItem4
            // 
            this.barStaticItem4.Caption = "Ultima Sincronizacion: ";
            this.barStaticItem4.Id = 7;
            this.barStaticItem4.Name = "barStaticItem4";
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // repositoryItemProgressBar2
            // 
            this.repositoryItemProgressBar2.Name = "repositoryItemProgressBar2";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 65.61086F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 34.38914F));
            this.tableLayoutPanel1.Controls.Add(this.PicturePic, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.MainLayout, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 20);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(910, 458);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // PicturePic
            // 
            this.PicturePic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PicturePic.Location = new System.Drawing.Point(600, 3);
            this.PicturePic.Name = "PicturePic";
            this.PicturePic.Size = new System.Drawing.Size(307, 452);
            this.PicturePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.PicturePic.TabIndex = 0;
            this.PicturePic.TabStop = false;
            // 
            // MainLayout
            // 
            this.MainLayout.ColumnCount = 1;
            this.MainLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.MainLayout.Controls.Add(this.SalesGrid, 0, 0);
            this.MainLayout.Controls.Add(this.PagosLayout, 0, 2);
            this.MainLayout.Controls.Add(this.SearchLayout, 0, 1);
            this.MainLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.MainLayout.Location = new System.Drawing.Point(3, 3);
            this.MainLayout.Name = "MainLayout";
            this.MainLayout.RowCount = 3;
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 80F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.MainLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.MainLayout.Size = new System.Drawing.Size(591, 452);
            this.MainLayout.TabIndex = 1;
            // 
            // SalesGrid
            // 
            this.SalesGrid.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SalesGrid.Location = new System.Drawing.Point(3, 3);
            this.SalesGrid.MainView = this.MainView;
            this.SalesGrid.Name = "SalesGrid";
            this.SalesGrid.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.UnidadLu});
            this.SalesGrid.Size = new System.Drawing.Size(585, 307);
            this.SalesGrid.TabIndex = 0;
            this.SalesGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.MainView});
            // 
            // MainView
            // 
            this.MainView.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn2});
            this.MainView.FooterPanelHeight = 50;
            this.MainView.GridControl = this.SalesGrid;
            this.MainView.IndicatorWidth = 50;
            this.MainView.Name = "MainView";
            this.MainView.OptionsBehavior.AllowAddRows = DevExpress.Utils.DefaultBoolean.False;
            this.MainView.OptionsBehavior.AllowDeleteRows = DevExpress.Utils.DefaultBoolean.False;
            this.MainView.OptionsBehavior.Editable = false;
            this.MainView.OptionsBehavior.ReadOnly = true;
            this.MainView.OptionsNavigation.AutoFocusNewRow = true;
            this.MainView.OptionsView.GroupFooterShowMode = DevExpress.XtraGrid.Views.Grid.GroupFooterShowMode.VisibleAlways;
            this.MainView.OptionsView.ShowFooter = true;
            this.MainView.OptionsView.ShowGroupPanel = false;
            this.MainView.RowHeight = 30;
            this.MainView.RowClick += new DevExpress.XtraGrid.Views.Grid.RowClickEventHandler(this.MainView_RowClick);
            this.MainView.CustomDrawRowIndicator += new DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventHandler(this.MainView_CustomDrawRowIndicator);
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "Cant";
            this.gridColumn3.DisplayFormat.FormatString = "N2";
            this.gridColumn3.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn3.FieldName = "Cantidad";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Cantidad", "Unidades = {0:N2}")});
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 71;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "Unidad";
            this.gridColumn4.ColumnEdit = this.UnidadLu;
            this.gridColumn4.FieldName = "FK_Unidad";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 1;
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "Articulo";
            this.gridColumn1.FieldName = "Descripcion";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 521;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "Precio";
            this.gridColumn2.DisplayFormat.FormatString = "C2";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn2.FieldName = "Precio";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Summary.AddRange(new DevExpress.XtraGrid.GridSummaryItem[] {
            new DevExpress.XtraGrid.GridColumnSummaryItem(DevExpress.Data.SummaryItemType.Sum, "Precio", "Total = {0:C2}")});
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 105;
            // 
            // PagosLayout
            // 
            this.PagosLayout.ColumnCount = 3;
            this.PagosLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PagosLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PagosLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 33.33333F));
            this.PagosLayout.Controls.Add(this.simpleButton2, 2, 0);
            this.PagosLayout.Controls.Add(this.simpleButton1, 1, 0);
            this.PagosLayout.Controls.Add(this.CancelarBt, 0, 0);
            this.PagosLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PagosLayout.Location = new System.Drawing.Point(3, 376);
            this.PagosLayout.Name = "PagosLayout";
            this.PagosLayout.RowCount = 1;
            this.PagosLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.PagosLayout.Size = new System.Drawing.Size(585, 73);
            this.PagosLayout.TabIndex = 1;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton2.Location = new System.Drawing.Point(393, 3);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(189, 67);
            this.simpleButton2.TabIndex = 4;
            this.simpleButton2.Text = "Otro";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.simpleButton1.Location = new System.Drawing.Point(198, 3);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(189, 67);
            this.simpleButton1.TabIndex = 3;
            this.simpleButton1.Text = "Efectivo";
            // 
            // CancelarBt
            // 
            this.CancelarBt.Dock = System.Windows.Forms.DockStyle.Fill;
            this.CancelarBt.Location = new System.Drawing.Point(3, 3);
            this.CancelarBt.Name = "CancelarBt";
            this.CancelarBt.Size = new System.Drawing.Size(189, 67);
            this.CancelarBt.TabIndex = 5;
            this.CancelarBt.Text = "Cancelar";
            this.CancelarBt.Click += new System.EventHandler(this.CancelarBt_Click);
            // 
            // SearchLayout
            // 
            this.SearchLayout.ColumnCount = 2;
            this.SearchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 160F));
            this.SearchLayout.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SearchLayout.Controls.Add(this.groupControl1, 0, 0);
            this.SearchLayout.Controls.Add(this.groupControl2, 1, 0);
            this.SearchLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchLayout.Location = new System.Drawing.Point(3, 316);
            this.SearchLayout.Name = "SearchLayout";
            this.SearchLayout.RowCount = 1;
            this.SearchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.SearchLayout.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.SearchLayout.Size = new System.Drawing.Size(585, 54);
            this.SearchLayout.TabIndex = 3;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.UPCTx);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(154, 48);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Codigo de Barras";
            // 
            // UPCTx
            // 
            this.UPCTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UPCTx.Location = new System.Drawing.Point(2, 23);
            this.UPCTx.MenuManager = this.barManager1;
            this.UPCTx.Name = "UPCTx";
            this.UPCTx.Size = new System.Drawing.Size(150, 20);
            this.UPCTx.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Controls.Add(this.SearchTx);
            this.groupControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl2.Location = new System.Drawing.Point(163, 3);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(419, 48);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Buscar";
            // 
            // SearchTx
            // 
            this.SearchTx.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SearchTx.Location = new System.Drawing.Point(2, 23);
            this.SearchTx.MenuManager = this.barManager1;
            this.SearchTx.Name = "SearchTx";
            this.SearchTx.Size = new System.Drawing.Size(415, 20);
            this.SearchTx.TabIndex = 0;
            // 
            // FocusTimer
            // 
            this.FocusTimer.Interval = 1000;
            this.FocusTimer.Tick += new System.EventHandler(this.FocusTimer_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(910, 500);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.IconOptions.ShowIcon = false;
            this.Name = "MainForm";
            this.Text = "nanocode POS";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemProgressBar2)).EndInit();
            this.tableLayoutPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.PicturePic)).EndInit();
            this.MainLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SalesGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MainView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.UnidadLu)).EndInit();
            this.PagosLayout.ResumeLayout(false);
            this.SearchLayout.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.UPCTx.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.SearchTx.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.Bar bar3;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.PictureBox PicturePic;
        private System.Windows.Forms.TableLayoutPanel MainLayout;
        private DevExpress.XtraGrid.GridControl SalesGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView MainView;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private System.Windows.Forms.TableLayoutPanel PagosLayout;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton CancelarBt;
        private DevExpress.XtraBars.BarButtonItem barButtonItem1;
        private DevExpress.XtraBars.BarButtonItem ConfigBt;
        private DevExpress.XtraBars.BarButtonItem ReportsBt;
        private DevExpress.XtraBars.BarStaticItem UserRLabel;
        private DevExpress.XtraBars.BarStaticItem StatusLabel;
        private DevExpress.XtraBars.BarStaticItem VigLb;
        private DevExpress.XtraBars.BarStaticItem LSynctLb;
        private DevExpress.XtraBars.BarEditItem LoadingBar;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar1;
        private DevExpress.XtraBars.BarStaticItem barStaticItem4;
        private DevExpress.XtraEditors.Repository.RepositoryItemProgressBar repositoryItemProgressBar2;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private System.Windows.Forms.TableLayoutPanel SearchLayout;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.TextEdit UPCTx;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.TextEdit SearchTx;
        private System.Windows.Forms.Timer FocusTimer;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit UnidadLu;
    }
}
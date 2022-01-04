
namespace VANPHONGPHAM
{
    partial class frmMain
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
            DevExpress.XtraSplashScreen.SplashScreenManager splashScreenManager1 = new DevExpress.XtraSplashScreen.SplashScreenManager(this, typeof(global::VANPHONGPHAM.frmLoading), true, true);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.btnDelete = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarItem1 = new DevExpress.XtraNavBar.NavBarItem();
            this.btnMatHang = new DevExpress.XtraNavBar.NavBarItem();
            this.btnKhachHang = new DevExpress.XtraNavBar.NavBarItem();
            this.btnNCC = new DevExpress.XtraNavBar.NavBarItem();
            this.btnNhanVien = new DevExpress.XtraNavBar.NavBarItem();
            this.barManager1 = new DevExpress.XtraBars.BarManager(this.components);
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.btnBanHang = new DevExpress.XtraBars.BarButtonItem();
            this.btnDatHang = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.barButtonItem2 = new DevExpress.XtraBars.BarButtonItem();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.splitContainerControl1 = new DevExpress.XtraEditors.SplitContainerControl();
            this.navBarControl1 = new DevExpress.XtraNavBar.NavBarControl();
            this.navBarGroup1 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup2 = new DevExpress.XtraNavBar.NavBarGroup();
            this.btnLoaiMH = new DevExpress.XtraNavBar.NavBarItem();
            this.navBarGroup3 = new DevExpress.XtraNavBar.NavBarGroup();
            this.navBarGroup4 = new DevExpress.XtraNavBar.NavBarGroup();
            this.splitContainerControl2 = new DevExpress.XtraEditors.SplitContainerControl();
            this.label1 = new System.Windows.Forms.Label();
            this.peImage = new DevExpress.XtraEditors.PictureEdit();
            this.splitContainerControl3 = new DevExpress.XtraEditors.SplitContainerControl();
            this.label4 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.chartControl2 = new DevExpress.XtraCharts.ChartControl();
            this.splitContainerControl4 = new DevExpress.XtraEditors.SplitContainerControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.chartControl3 = new DevExpress.XtraCharts.ChartControl();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.chartControl1 = new DevExpress.XtraCharts.ChartControl();
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).BeginInit();
            this.splitContainerControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).BeginInit();
            this.splitContainerControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).BeginInit();
            this.splitContainerControl3.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).BeginInit();
            this.splitContainerControl4.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).BeginInit();
            this.panel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).BeginInit();
            this.SuspendLayout();
            // 
            // splashScreenManager1
            // 
            splashScreenManager1.ClosingDelay = 500;
            // 
            // btnDelete
            // 
            this.btnDelete.Caption = "Xóa dữ liệu bán hàng";
            this.btnDelete.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.LargeImage")));
            this.btnDelete.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnDelete.ImageOptions.SmallImage")));
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnDelete_LinkClicked);
            // 
            // navBarItem1
            // 
            this.navBarItem1.Caption = "Thay đổi mật khẩu";
            this.navBarItem1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.ImageOptions.LargeImage")));
            this.navBarItem1.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarItem1.ImageOptions.SmallImage")));
            this.navBarItem1.Name = "navBarItem1";
            // 
            // btnMatHang
            // 
            this.btnMatHang.Caption = "Danh mục Mặt hàng";
            this.btnMatHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnMatHang.ImageOptions.LargeImage")));
            this.btnMatHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnMatHang.ImageOptions.SmallImage")));
            this.btnMatHang.Name = "btnMatHang";
            this.btnMatHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnMatHang_LinkClicked);
            // 
            // btnKhachHang
            // 
            this.btnKhachHang.Caption = "Danh mục Khách Hàng";
            this.btnKhachHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.LargeImage")));
            this.btnKhachHang.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnKhachHang.ImageOptions.SmallImage")));
            this.btnKhachHang.Name = "btnKhachHang";
            this.btnKhachHang.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnKhachHang_LinkClicked);
            // 
            // btnNCC
            // 
            this.btnNCC.Caption = "Danh mục Nhà Cung Cấp";
            this.btnNCC.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNCC.ImageOptions.LargeImage")));
            this.btnNCC.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNCC.ImageOptions.SmallImage")));
            this.btnNCC.Name = "btnNCC";
            this.btnNCC.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnNCC_LinkClicked);
            // 
            // btnNhanVien
            // 
            this.btnNhanVien.Caption = "Quản lý Nhân Viên";
            this.btnNhanVien.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.LargeImage")));
            this.btnNhanVien.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnNhanVien.ImageOptions.SmallImage")));
            this.btnNhanVien.Name = "btnNhanVien";
            this.btnNhanVien.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnNhanVien_LinkClicked);
            // 
            // barManager1
            // 
            this.barManager1.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar2});
            this.barManager1.DockControls.Add(this.barDockControlTop);
            this.barManager1.DockControls.Add(this.barDockControlBottom);
            this.barManager1.DockControls.Add(this.barDockControlLeft);
            this.barManager1.DockControls.Add(this.barDockControlRight);
            this.barManager1.Form = this;
            this.barManager1.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.btnBanHang,
            this.barButtonItem2,
            this.btnDatHang});
            this.barManager1.MainMenu = this.bar2;
            this.barManager1.MaxItemId = 4;
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockRow = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.FloatLocation = new System.Drawing.Point(9, 152);
            this.bar2.FloatSize = new System.Drawing.Size(390, 47);
            this.bar2.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.btnBanHang),
            new DevExpress.XtraBars.LinkPersistInfo(this.btnDatHang)});
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // btnBanHang
            // 
            this.btnBanHang.Caption = "Bán Hàng";
            this.btnBanHang.Id = 0;
            this.btnBanHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnBanHang.ImageOptions.Image")));
            this.btnBanHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnBanHang.ImageOptions.LargeImage")));
            this.btnBanHang.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnBanHang.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ItemAppearance.Normal.Options.UseFont = true;
            this.btnBanHang.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBanHang.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnBanHang.Name = "btnBanHang";
            this.btnBanHang.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnBanHang.Size = new System.Drawing.Size(0, 36);
            this.btnBanHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnBanHang_Click);
            // 
            // btnDatHang
            // 
            this.btnDatHang.Caption = "Đặt Hàng";
            this.btnDatHang.Id = 3;
            this.btnDatHang.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnDatHang.ImageOptions.Image")));
            this.btnDatHang.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnDatHang.ImageOptions.LargeImage")));
            this.btnDatHang.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.ItemAppearance.Hovered.Options.UseFont = true;
            this.btnDatHang.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.ItemAppearance.Normal.Options.UseFont = true;
            this.btnDatHang.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.ItemAppearance.Pressed.Options.UseFont = true;
            this.btnDatHang.ItemInMenuAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDatHang.ItemInMenuAppearance.Hovered.Options.UseFont = true;
            this.btnDatHang.Name = "btnDatHang";
            this.btnDatHang.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            this.btnDatHang.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.btnDatHang_ItemClick);
            // 
            // barDockControlTop
            // 
            this.barDockControlTop.CausesValidation = false;
            this.barDockControlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.barDockControlTop.Location = new System.Drawing.Point(0, 0);
            this.barDockControlTop.Manager = this.barManager1;
            this.barDockControlTop.Size = new System.Drawing.Size(1918, 45);
            // 
            // barDockControlBottom
            // 
            this.barDockControlBottom.CausesValidation = false;
            this.barDockControlBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.barDockControlBottom.Location = new System.Drawing.Point(0, 1020);
            this.barDockControlBottom.Manager = this.barManager1;
            this.barDockControlBottom.Size = new System.Drawing.Size(1918, 0);
            // 
            // barDockControlLeft
            // 
            this.barDockControlLeft.CausesValidation = false;
            this.barDockControlLeft.Dock = System.Windows.Forms.DockStyle.Left;
            this.barDockControlLeft.Location = new System.Drawing.Point(0, 45);
            this.barDockControlLeft.Manager = this.barManager1;
            this.barDockControlLeft.Size = new System.Drawing.Size(0, 975);
            // 
            // barDockControlRight
            // 
            this.barDockControlRight.CausesValidation = false;
            this.barDockControlRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.barDockControlRight.Location = new System.Drawing.Point(1918, 45);
            this.barDockControlRight.Manager = this.barManager1;
            this.barDockControlRight.Size = new System.Drawing.Size(0, 975);
            // 
            // barButtonItem2
            // 
            this.barButtonItem2.Caption = "Báo Cáo";
            this.barButtonItem2.Id = 2;
            this.barButtonItem2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.Image")));
            this.barButtonItem2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("barButtonItem2.ImageOptions.LargeImage")));
            this.barButtonItem2.ItemAppearance.Hovered.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Hovered.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Normal.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Normal.Options.UseFont = true;
            this.barButtonItem2.ItemAppearance.Pressed.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.barButtonItem2.ItemAppearance.Pressed.Options.UseFont = true;
            this.barButtonItem2.Name = "barButtonItem2";
            this.barButtonItem2.PaintStyle = DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel5);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 991);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1918, 29);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.Controls.Add(this.label6);
            this.panel5.Location = new System.Drawing.Point(284, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1440, 29);
            this.panel5.TabIndex = 9;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(3, 3);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(396, 21);
            this.label6.TabIndex = 10;
            this.label6.Text = "Chào mừng đến với văn phòng phẩm sao mai";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(1776, 3);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(62, 21);
            this.label5.TabIndex = 8;
            this.label5.Text = "label5";
            // 
            // splitContainerControl1
            // 
            this.splitContainerControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl1.Location = new System.Drawing.Point(0, 45);
            this.splitContainerControl1.Name = "splitContainerControl1";
            this.splitContainerControl1.Panel1.Controls.Add(this.navBarControl1);
            this.splitContainerControl1.Panel1.Text = "Panel1";
            this.splitContainerControl1.Panel2.Controls.Add(this.splitContainerControl2);
            this.splitContainerControl1.Panel2.Text = "Panel2";
            this.splitContainerControl1.Size = new System.Drawing.Size(1918, 946);
            this.splitContainerControl1.SplitterPosition = 272;
            this.splitContainerControl1.TabIndex = 8;
            // 
            // navBarControl1
            // 
            this.navBarControl1.ActiveGroup = this.navBarGroup1;
            this.navBarControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.navBarControl1.Groups.AddRange(new DevExpress.XtraNavBar.NavBarGroup[] {
            this.navBarGroup1,
            this.navBarGroup2,
            this.navBarGroup3,
            this.navBarGroup4});
            this.navBarControl1.Items.AddRange(new DevExpress.XtraNavBar.NavBarItem[] {
            this.btnLoaiMH});
            this.navBarControl1.Location = new System.Drawing.Point(0, 0);
            this.navBarControl1.Name = "navBarControl1";
            this.navBarControl1.OptionsNavPane.ExpandedWidth = 272;
            this.navBarControl1.Size = new System.Drawing.Size(272, 946);
            this.navBarControl1.TabIndex = 0;
            this.navBarControl1.Text = "navBarControl1";
            // 
            // navBarGroup1
            // 
            this.navBarGroup1.Caption = "HỆ THỐNG";
            this.navBarGroup1.Expanded = true;
            this.navBarGroup1.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.LargeImage")));
            this.navBarGroup1.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup1.ImageOptions.SmallImage")));
            this.navBarGroup1.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnDelete),
            new DevExpress.XtraNavBar.NavBarItemLink(this.navBarItem1)});
            this.navBarGroup1.Name = "navBarGroup1";
            // 
            // navBarGroup2
            // 
            this.navBarGroup2.Caption = "QUẢN LÝ HÀNG HÓA";
            this.navBarGroup2.Expanded = true;
            this.navBarGroup2.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.ImageOptions.LargeImage")));
            this.navBarGroup2.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup2.ImageOptions.SmallImage")));
            this.navBarGroup2.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnMatHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnLoaiMH)});
            this.navBarGroup2.Name = "navBarGroup2";
            // 
            // btnLoaiMH
            // 
            this.btnLoaiMH.Caption = "Danh mục Nhóm hàng hóa";
            this.btnLoaiMH.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("btnLoaiMH.ImageOptions.LargeImage")));
            this.btnLoaiMH.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("btnLoaiMH.ImageOptions.SmallImage")));
            this.btnLoaiMH.Name = "btnLoaiMH";
            this.btnLoaiMH.LinkClicked += new DevExpress.XtraNavBar.NavBarLinkEventHandler(this.btnLoaiHang_LinkClicked);
            // 
            // navBarGroup3
            // 
            this.navBarGroup3.Caption = "QUẢN LÝ ĐỐI TÁC";
            this.navBarGroup3.Expanded = true;
            this.navBarGroup3.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.ImageOptions.LargeImage")));
            this.navBarGroup3.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup3.ImageOptions.SmallImage")));
            this.navBarGroup3.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnKhachHang),
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnNCC)});
            this.navBarGroup3.Name = "navBarGroup3";
            // 
            // navBarGroup4
            // 
            this.navBarGroup4.Caption = "QUẢN LÝ NHÂN VIÊN";
            this.navBarGroup4.Expanded = true;
            this.navBarGroup4.ImageOptions.LargeImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup4.ImageOptions.LargeImage")));
            this.navBarGroup4.ImageOptions.SmallImage = ((System.Drawing.Image)(resources.GetObject("navBarGroup4.ImageOptions.SmallImage")));
            this.navBarGroup4.ItemLinks.AddRange(new DevExpress.XtraNavBar.NavBarItemLink[] {
            new DevExpress.XtraNavBar.NavBarItemLink(this.btnNhanVien)});
            this.navBarGroup4.Name = "navBarGroup4";
            // 
            // splitContainerControl2
            // 
            this.splitContainerControl2.Appearance.BackColor = System.Drawing.Color.White;
            this.splitContainerControl2.Appearance.Options.UseBackColor = true;
            this.splitContainerControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl2.Horizontal = false;
            this.splitContainerControl2.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl2.Name = "splitContainerControl2";
            this.splitContainerControl2.Panel1.Controls.Add(this.label1);
            this.splitContainerControl2.Panel1.Controls.Add(this.peImage);
            this.splitContainerControl2.Panel1.Text = "Panel1";
            this.splitContainerControl2.Panel2.Controls.Add(this.splitContainerControl3);
            this.splitContainerControl2.Panel2.Text = "Panel2";
            this.splitContainerControl2.Size = new System.Drawing.Size(1634, 946);
            this.splitContainerControl2.SplitterPosition = 103;
            this.splitContainerControl2.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.label1.Location = new System.Drawing.Point(275, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(838, 54);
            this.label1.TabIndex = 16;
            this.label1.Text = "PHẦN MỀM QUẢN LÝ VĂN PHÒNG PHẨM";
            // 
            // peImage
            // 
            this.peImage.EditValue = ((object)(resources.GetObject("peImage.EditValue")));
            this.peImage.Location = new System.Drawing.Point(1060, -109);
            this.peImage.Margin = new System.Windows.Forms.Padding(4);
            this.peImage.Name = "peImage";
            this.peImage.Properties.AllowFocused = false;
            this.peImage.Properties.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.peImage.Properties.Appearance.Options.UseBackColor = true;
            this.peImage.Properties.BorderStyle = DevExpress.XtraEditors.Controls.BorderStyles.NoBorder;
            this.peImage.Properties.ShowMenu = false;
            this.peImage.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.peImage.Size = new System.Drawing.Size(512, 312);
            this.peImage.TabIndex = 17;
            // 
            // splitContainerControl3
            // 
            this.splitContainerControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl3.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl3.Name = "splitContainerControl3";
            this.splitContainerControl3.Panel1.Controls.Add(this.label4);
            this.splitContainerControl3.Panel1.Controls.Add(this.panel3);
            this.splitContainerControl3.Panel1.Text = "Panel1";
            this.splitContainerControl3.Panel2.Controls.Add(this.splitContainerControl4);
            this.splitContainerControl3.Panel2.Text = "Panel2";
            this.splitContainerControl3.Size = new System.Drawing.Size(1634, 831);
            this.splitContainerControl3.SplitterPosition = 736;
            this.splitContainerControl3.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Location = new System.Drawing.Point(3, 8);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(680, 29);
            this.label4.TabIndex = 9;
            this.label4.Text = "Biểu đồ top 5 khách hàng chi trả nhiều nhất trong tháng";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.chartControl2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 77);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(736, 754);
            this.panel3.TabIndex = 0;
            // 
            // chartControl2
            // 
            this.chartControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl2.Legend.Name = "Default Legend";
            this.chartControl2.Location = new System.Drawing.Point(0, 0);
            this.chartControl2.Name = "chartControl2";
            this.chartControl2.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl2.Size = new System.Drawing.Size(736, 754);
            this.chartControl2.TabIndex = 0;
            // 
            // splitContainerControl4
            // 
            this.splitContainerControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainerControl4.Horizontal = false;
            this.splitContainerControl4.Location = new System.Drawing.Point(0, 0);
            this.splitContainerControl4.Name = "splitContainerControl4";
            this.splitContainerControl4.Panel1.Controls.Add(this.panel2);
            this.splitContainerControl4.Panel1.Controls.Add(this.label2);
            this.splitContainerControl4.Panel1.Text = "Panel1";
            this.splitContainerControl4.Panel2.Controls.Add(this.label3);
            this.splitContainerControl4.Panel2.Controls.Add(this.panel4);
            this.splitContainerControl4.Panel2.Text = "Panel2";
            this.splitContainerControl4.Size = new System.Drawing.Size(886, 831);
            this.splitContainerControl4.SplitterPosition = 410;
            this.splitContainerControl4.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.chartControl3);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 45);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(886, 365);
            this.panel2.TabIndex = 7;
            // 
            // chartControl3
            // 
            this.chartControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl3.Legend.Name = "Default Legend";
            this.chartControl3.Location = new System.Drawing.Point(0, 0);
            this.chartControl3.Name = "chartControl3";
            this.chartControl3.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl3.Size = new System.Drawing.Size(886, 365);
            this.chartControl3.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(542, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Biểu đồ top 5 mặt hàng bán chạy trong ngày";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Tahoma", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label3.Location = new System.Drawing.Point(3, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(660, 46);
            this.label3.TabIndex = 7;
            this.label3.Text = "Biểu đồ phân bổ nhóm mặt hàng";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label3.UseCompatibleTextRendering = true;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.chartControl1);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 84);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(886, 325);
            this.panel4.TabIndex = 0;
            // 
            // chartControl1
            // 
            this.chartControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.chartControl1.Legend.Name = "Default Legend";
            this.chartControl1.Location = new System.Drawing.Point(0, 0);
            this.chartControl1.Name = "chartControl1";
            this.chartControl1.SeriesSerializable = new DevExpress.XtraCharts.Series[0];
            this.chartControl1.Size = new System.Drawing.Size(886, 325);
            this.chartControl1.TabIndex = 1;
            // 
            // frmMain
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1918, 1020);
            this.Controls.Add(this.splitContainerControl1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QUẢN LÝ VĂN PHÒNG PHẨM";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.Load += new System.EventHandler(this.frmMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.barManager1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl1)).EndInit();
            this.splitContainerControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.navBarControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl2)).EndInit();
            this.splitContainerControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.peImage.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl3)).EndInit();
            this.splitContainerControl3.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainerControl4)).EndInit();
            this.splitContainerControl4.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl3)).EndInit();
            this.panel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.chartControl1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraNavBar.NavBarItem btnMatHang;
        private DevExpress.XtraNavBar.NavBarItem btnKhachHang;
        private DevExpress.XtraNavBar.NavBarItem btnNCC;
        private DevExpress.XtraNavBar.NavBarItem btnNhanVien;
        private DevExpress.XtraNavBar.NavBarItem btnDelete;
        private DevExpress.XtraNavBar.NavBarItem navBarItem1;
        private DevExpress.XtraBars.BarManager barManager1;
        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarButtonItem btnBanHang;
        private DevExpress.XtraBars.BarButtonItem barButtonItem2;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.BarButtonItem btnDatHang;
        private System.Windows.Forms.Timer timer1;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl1;
        private DevExpress.XtraNavBar.NavBarControl navBarControl1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup1;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup2;
        private DevExpress.XtraNavBar.NavBarItem btnLoaiMH;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup3;
        private DevExpress.XtraNavBar.NavBarGroup navBarGroup4;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl2;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl3;
        private DevExpress.XtraEditors.SplitContainerControl splitContainerControl4;
        private System.Windows.Forms.Panel panel2;
        private DevExpress.XtraCharts.ChartControl chartControl3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel4;
        private DevExpress.XtraCharts.ChartControl chartControl1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel3;
        private DevExpress.XtraCharts.ChartControl chartControl2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label6;
        private DevExpress.XtraEditors.PictureEdit peImage;
        private System.Windows.Forms.Label label1;
    }
}


using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DataLayer;
using BusinessLayer;
using DevExpress.XtraGrid.Views.Grid;
using CrystalDecisions.Windows.Forms;
using CrystalDecisions.Shared;
using CrystalDecisions.CrystalReports.Engine;

namespace VANPHONGPHAM
{
    public partial class frmDATHANG : DevExpress.XtraEditors.XtraForm
    {
        public frmDATHANG()
        {
            InitializeComponent();
        }

        List<OBJDDH_MH> lstDDHMH;
        DONDATHANGMATHANG _ddhmh;
        NHACUNGCAP _ncc;
        DONDATHANG _ddh;
        MATHANG _mh;
        LOAIMATHANG _loaimh;
        bool _them;
        string _mamh;

        frmNHACUNGCAP objNHACUNGCAP = (frmNHACUNGCAP)Application.OpenForms["frmNHACUNGCAP"];
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
        private void frmDATHANG_Load(object sender, EventArgs e)
        {
            _ddhmh = new DONDATHANGMATHANG();
            _ncc = new NHACUNGCAP();
            dateEditTuNgay.EditValue = GetFirstDayOfMonth(DateTime.Now);
            dateEditDenNgay.EditValue = DateTime.Now;
            _ddhmh = new DONDATHANGMATHANG();
            _ddh = new DONDATHANG();
            _mh = new MATHANG();
            _loaimh = new LOAIMATHANG();
            _ncc = new NHACUNGCAP();
            lstDDHMH = new List<OBJDDH_MH>();
            loadData();
            enable(false);
            lbThoigian.Text = DateTime.Now.ToString();
            tabControl.SelectedTabPage = tabBanHang;

            showHideControl(true);

            gvDanhSach.ExpandAllGroups();
            dateEditTuNgay.DateTimeChanged += dateEditTuNgay_DateTimeChanged;
            dateEditDenNgay.DateTimeChanged += dateEditTuNgay_DateTimeChanged;

            timer1.Enabled = true;
            timer1.Start();
            label7.Text = DateTime.Now.ToLongTimeString();
        }

        void loadData()
        {
            loadDS();
            loadMH();
            loadNCC();
        }
        void loadDS()
        {
            gcDanhSach.DataSource = _ddhmh.getAll();
        }
        void loadMH()
        {
            gcDanhSachMH.DataSource = _mh.getAll();
        }
        public void loadNCC()
        {
            cmbNhaCungCap.DataSource = _ncc.getAll();
            cmbNhaCungCap.DisplayMember = "TENNCC";
            cmbNhaCungCap.ValueMember = "MANCC";
        }

        public void setNhaCungCap(string mancc)
        {
            var ncc = _ncc.getItem(mancc);
            cmbNhaCungCap.SelectedValue = ncc.MANCC;
            cmbNhaCungCap.Text = ncc.TENNCC;
        }

        void showHideControl(bool t)
        {
            btnThem.Enabled = t;
            btnLuu.Enabled = !t;
            btnBoQua.Enabled = !t;
            btnXoaMH.Enabled = !t;
        }

        public void enable(bool t)
        {
            cmbNhaCungCap.Enabled = t;
            gcDanhSachMH.Enabled = t;
            gcDanhSachDatHang.Enabled = t;
            btnAddnew.Enabled = t;

        }

        void reset(bool t)
        {
            cmbNhaCungCap.SelectedIndex = 0;
            lbThanhTien.Text = "0 ₫";
            gcDanhSachDatHang.DataSource = _ddhmh.getAll(0);
        }
        public static DateTime GetFirstDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }

        bool cal(Int32 _Width, GridView _view)
        {
            _view.IndicatorWidth = _view.IndicatorWidth < _Width ? _Width : _view.IndicatorWidth;
            return true;
        }
        private void gvDanhSach_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
            {
                if (e.RowHandle < 0)
                {
                    e.Info.ImageIndex = 0;
                    e.Info.DisplayText = string.Empty;
                }
                else
                {
                    e.Info.ImageIndex = -1; //Nếu hiển thị
                    e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                }
                SizeF sizeF = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lây kích thước của vùng hiển thị Text
                Int32 _Width = Convert.ToInt32(sizeF.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDanhSach); })); // Tăng kích thước nếu text vượt quá
            }
        }

        private void gvDanhSachMH_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
            {
                if (e.RowHandle < 0)
                {
                    e.Info.ImageIndex = 0;
                    e.Info.DisplayText = string.Empty;
                }
                else
                {
                    e.Info.ImageIndex = -1; //Nếu hiển thị
                    e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                }
                SizeF sizeF = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lây kích thước của vùng hiển thị Text
                Int32 _Width = Convert.ToInt32(sizeF.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDanhSachMH); })); // Tăng kích thước nếu text vượt quá
            }
        }

        private void gvDanhSachDatHang_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {
            if (e.Info.IsRowIndicator) //Nếu là dòng Indicator
            {
                if (e.RowHandle < 0)
                {
                    e.Info.ImageIndex = 0;
                    e.Info.DisplayText = string.Empty;
                }
                else
                {
                    e.Info.ImageIndex = -1; //Nếu hiển thị
                    e.Info.DisplayText = (e.RowHandle + 1).ToString(); //Số thứ tự tăng dần
                }
                SizeF sizeF = e.Graphics.MeasureString(e.Info.DisplayText, e.Appearance.Font); //Lây kích thước của vùng hiển thị Text
                Int32 _Width = Convert.ToInt32(sizeF.Width) + 20;
                BeginInvoke(new MethodInvoker(delegate { cal(_Width, gvDanhSachDatHang); })); // Tăng kích thước nếu text vượt quá
            }
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            frmNHACUNGCAP frm = new frmNHACUNGCAP();
            frm.ShowDialog();
        }

        private void dateEditTuNgay_DateTimeChanged(object sender, EventArgs e)
        {
            if (dateEditDenNgay.DateTime < dateEditTuNgay.DateTime)
            {
                MessageBox.Show("Vui lòng chọn lại", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                gvDanhSach.ExpandAllGroups();
                gcDanhSach.DataSource = _ddhmh.getAllByDate(dateEditTuNgay.DateTime, dateEditDenNgay.DateTime.AddDays(1));
            }
        }

        private void gcDanhSachDatHang_DoubleClick(object sender, EventArgs e)
        {
            
        }
        void loadCTHD()
        {
            List<OBJDDH_MH> lsDDH = new List<OBJDDH_MH>();
            foreach (var item in lstDDHMH)
            {
                lsDDH.Add(item);
            }
            gcDanhSachDatHang.DataSource = lsDDH;
        }

        private void gvDanhSachDatHang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SOLUONG")
            {
                int sl = int.Parse(e.Value.ToString());
                if (sl != 0)
                {
                    double gia = double.Parse(gvDanhSachDatHang.GetRowCellValue(gvDanhSachDatHang.FocusedRowHandle, "DONGIA").ToString());
                    gvDanhSachDatHang.SetRowCellValue(gvDanhSachDatHang.FocusedRowHandle, "THANHTIEN", sl * gia);
                }
                else
                {
                    gvDanhSachDatHang.SetRowCellValue(gvDanhSachDatHang.FocusedRowHandle, "THANHTIEN", 0);
                }
            }
            gvDanhSachDatHang.UpdateTotalSummary();
            lbThanhTien.Text = double.Parse(gvDanhSachDatHang.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()).ToString("N0") + " ₫";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            _them = true;
            reset(true);
            enable(true);
            showHideControl(false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _them = true;
            saveData();
            tabControl.SelectedTabPage = tabDanhSach;
            loadData();
            showHideControl(true);
            reset(true);
            enable(false);
            lstDDHMH.Clear();
            objMain.loadChart();
        }

        void saveData()
        {
            DON_DAT_HANG ddh = new DON_DAT_HANG();

            if (_them)
            {
                ddh.NGAYDAT = DateTime.Now;
                ddh.MANV = "NV02";
                ddh.MANCC = cmbNhaCungCap.SelectedValue.ToString();
                var LuuDDH = _ddh.add(ddh);
                int _maDDH = LuuDDH.MADDH;
                for (int i = 0; i < gvDanhSachDatHang.RowCount; i++)
                {
                    DONDATHANG_MATHANG ddhmh = new DONDATHANG_MATHANG();
                    ddhmh.MADDH = _maDDH;
                    ddhmh.MAMH = gvDanhSachDatHang.GetRowCellValue(i, "MAMH").ToString();
                    ddhmh.SOLUONG = int.Parse(gvDanhSachDatHang.GetRowCellValue(i, "SOLUONG").ToString());
                    ddhmh.DONGIA = double.Parse(gvDanhSachDatHang.GetRowCellValue(i, "THANHTIEN").ToString());
                    _ddhmh.add(ddhmh);
                }
            }
        }

        private void btnBoQua_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabDanhSach;
            reset(true);
            enable(false);
            showHideControl(true);
        }

        private void gcDanhSachDatHang_Click(object sender, EventArgs e)
        {
            _mamh = gvDanhSachDatHang.GetFocusedRowCellValue("MAMH").ToString();
            lbThanhTien.Text = double.Parse(gvDanhSachDatHang.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()).ToString("N0") + " ₫";
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (gvDanhSachDatHang.RowCount > 0)
            {
                gvDanhSachDatHang.DeleteSelectedRows();
                lbThanhTien.Text = double.Parse(gvDanhSachDatHang.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()).ToString("N0") + " ₫";

                lstDDHMH.RemoveAll(r => r.MAMH == _mamh);

                gcDanhSachDatHang.DataSource = lstDDHMH.ToList();
            }
        }

        public int i = 10;

        private void timer1_Tick(object sender, EventArgs e)
        {
            string a = "";
            label7.Text = DateTime.Now.ToLongTimeString();
            if (DateTime.Now.Hour > 5 && DateTime.Now.Hour <= 10)
                a = "Good morning";
            else if (DateTime.Now.Hour > 10 && DateTime.Now.Hour <= 17)
                a = "Good afternoon";
            else
                a = "Good evening";
            label6.Text = a + "! Văn phòng phẩm Sao Mai kính chúc quý khách một ngày tốt lành!";
            label6.Left += i;
            if (label6.Left >= this.Width - 500 || label6.Left <= -750)
                i = -i;
            label6.Left += i;
        }

        private void gcDanhSachMH_DoubleClick(object sender, EventArgs e)
        {
            cmbNhaCungCap.Enabled = false;
            btnAddnew.Enabled = false;
            if (gvDanhSachMH.GetFocusedRowCellValue("MAMH") != null)
            {
                OBJDDH_MH ctdhd = new OBJDDH_MH();
                ctdhd.MAMH = gvDanhSachMH.GetFocusedRowCellValue("MAMH").ToString();
                ctdhd.TENMH = gvDanhSachMH.GetFocusedRowCellValue("TENMH").ToString();
                ctdhd.SOLUONG = 1;
                ctdhd.THANHTIEN = double.Parse(gvDanhSachMH.GetFocusedRowCellValue("GIABAN").ToString());
                ctdhd.MANCC = cmbNhaCungCap.SelectedValue.ToString();
                ctdhd.TENNCC = cmbNhaCungCap.Text;

                ctdhd.DONGIA = long.Parse(gvDanhSachMH.GetFocusedRowCellValue("GIABAN").ToString());
                foreach (var item in lstDDHMH)
                {
                    if (item.MAMH == ctdhd.MAMH)
                    {
                        item.SOLUONG = item.SOLUONG + 1;
                        item.THANHTIEN = item.SOLUONG * item.DONGIA;
                        loadCTHD();
                        lbThanhTien.Text = double.Parse(gvDanhSachDatHang.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()).ToString("N0") + " ₫";
                        return;
                    }
                }
                lstDDHMH.Add(ctdhd);
            }
            loadCTHD();
            lbThanhTien.Text = double.Parse(gvDanhSachDatHang.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()).ToString("N0") + " ₫";
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XuatReport("ReportDDH", "DANH SÁCH THỐNG KÊ LỊCH SỬ ĐẶT HÀNG");
        }

        private void XuatReport(string _reportName, string _tieude)
        {
            if (_mamh != null || _mamh == null)
            {
                Form frm = new Form();
                CrystalReportViewer Crv = new CrystalReportViewer();
                Crv.ShowGroupTreeButton = false;
                Crv.ShowParameterPanelButton = false;
                Crv.ToolPanelView = ToolPanelViewType.None;
                TableLogOnInfo Thongtin;
                ReportDocument doc = new ReportDocument();
                doc.Load(System.Windows.Forms.Application.StartupPath + "\\Reports\\" + _reportName + @".rpt");
                Thongtin = doc.Database.Tables[0].LogOnInfo;
                Thongtin.ConnectionInfo.ServerName = myFun._srv;
                Thongtin.ConnectionInfo.UserID = myFun._us;
                Thongtin.ConnectionInfo.Password = myFun._pw;
                Thongtin.ConnectionInfo.DatabaseName = myFun._db;
                doc.Database.Tables[0].ApplyLogOnInfo(Thongtin);
                try
                {
                    DateTime tungay = dateEditTuNgay.DateTime.Date;
                    DateTime denngay = dateEditDenNgay.DateTime.Date;

                    // thông báo
                    doc.SetParameterValue("@TUNGAY", tungay);
                    doc.SetParameterValue("@DENNGAY", denngay);
                    Crv.Dock = DockStyle.Fill;
                    Crv.ReportSource = doc;
                    frm.Controls.Add(Crv);
                    Crv.Refresh();
                    frm.Text = _tieude;
                    frm.WindowState = FormWindowState.Maximized;
                    frm.ShowDialog();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message);
                }
            }
            else
                MessageBox.Show("Không có dữ liệu.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
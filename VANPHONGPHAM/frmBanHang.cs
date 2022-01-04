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
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace VANPHONGPHAM
{
    public partial class frmBanHang : DevExpress.XtraEditors.XtraForm
    {
        public frmBanHang()
        {
            InitializeComponent();
        }

        List<OBJHOADON_MATHANG> listHDMH;
        HOADONMATHANG _hdmh;
        HOADON _hd;
        LOAIMATHANG _loaimh;
        MATHANG _mh;
        KHACHHANG _kh;
        bool _them;
        string _mamh;

        frmKHACHHANG objKHACHHANG = (frmKHACHHANG)Application.OpenForms["frmKHACHHANG"];
        frmMain objMain = (frmMain)Application.OpenForms["frmMain"];
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

        private void gvDanhSachMuaHang_CustomDrawRowIndicator(object sender, DevExpress.XtraGrid.Views.Grid.RowIndicatorCustomDrawEventArgs e)
        {

        }
        public static DateTime GetFirstDayOfMonth(DateTime dtInput)
        {
            DateTime dtResult = dtInput;
            dtResult = dtResult.AddDays((-dtResult.Day) + 1);
            return dtResult;
        }

        private void frmBanHang_Load(object sender, EventArgs e)
        {
            dateEditTuNgay.EditValue = GetFirstDayOfMonth(DateTime.Now);
            dateEditDenNgay.EditValue = DateTime.Now;
            _hdmh = new HOADONMATHANG();
            _hd = new HOADON();
            _loaimh = new LOAIMATHANG();
            _mh = new MATHANG();
            _kh = new KHACHHANG();

            listHDMH = new List<OBJHOADON_MATHANG>();
            loadData();
            enable(false);
            lbThoiGian.Text = DateTime.Now.ToString();
            tabControl.SelectedTabPage = tabBanHang;

            showHideControl(true);

            gvDanhSach.ExpandAllGroups();
            dateEditTuNgay.DateTimeChanged += dateEditTuNgay_DateTimeChanged;
            dateEditDenNgay.DateTimeChanged += dateEditTuNgay_DateTimeChanged;

            timer1.Enabled = true;
            timer1.Start();
            label7.Text = DateTime.Now.ToLongTimeString();
            lbThoiGian.Text = DateTime.Now.ToLongTimeString();
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
                gcDanhSach.DataSource = _hdmh.getAllByDate(dateEditTuNgay.DateTime.Date, dateEditDenNgay.DateTime.Date.AddDays(1));
            }
            gvDanhSachMuaHang.UpdateTotalSummary();
        }

        void loadData()
        {
            loadDS();
            loadMH();
            loadKH();
        }

        void loadDS()
        {
            gcDanhSach.DataSource = _hdmh.getAll();
        }

        void loadMH()
        {
            gcDanhSachMH.DataSource = _mh.getAll();
        }

        public void loadKH()
        {
            cmbKhachHang.DataSource = _kh.getAll();
            cmbKhachHang.DisplayMember = "TENKH";
            cmbKhachHang.ValueMember = "MAKH";
        }

        public void setKhachHang(int idkh)
        {
            var kh = _kh.getItem(idkh);
            cmbKhachHang.SelectedValue = kh.MAKH;
            cmbKhachHang.Text = kh.TENKH;
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            frmKHACHHANG frm = new frmKHACHHANG();
            frm.ShowDialog();
        }
       

        private void gcDanhSachMH_DoubleClick(object sender, EventArgs e)
        {
            cmbKhachHang.Enabled = false;
            btnAddnew.Enabled = false;
            if (gvDanhSachMH.GetFocusedRowCellValue("MAMH") != null)
            {
                OBJHOADON_MATHANG cthd = new OBJHOADON_MATHANG();
                cthd.MAMH = gvDanhSachMH.GetFocusedRowCellValue("MAMH").ToString();
                cthd.TENMH = gvDanhSachMH.GetFocusedRowCellValue("TENMH").ToString();
                cthd.SOLUONG = 1;
                cthd.THANHTIEN = double.Parse(gvDanhSachMH.GetFocusedRowCellValue("GIABAN").ToString());
                cthd.MAKH = int.Parse(cmbKhachHang.SelectedValue.ToString());
                cthd.TENKH = cmbKhachHang.Text;

                cthd.DONGIA = long.Parse(gvDanhSachMH.GetFocusedRowCellValue("GIABAN").ToString());
                foreach (var item in listHDMH)
                {
                    if(item.MAMH == cthd.MAMH)
                    {
                        item.SOLUONG = item.SOLUONG + 1;
                        item.THANHTIEN = item.SOLUONG * item.DONGIA;
                        loadCTHD();
                        lbThanhTien.Text = double.Parse(gvDanhSachMuaHang.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()).ToString("N0") + " ₫";
                        return ;
                    }
                }
                listHDMH.Add(cthd);
            }
            loadCTHD();
            lbThanhTien.Text = double.Parse(gvDanhSachMuaHang.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()).ToString("N0") + " ₫";
        }
        void loadCTHD()
        {
            List<OBJHOADON_MATHANG> lsHD = new List<OBJHOADON_MATHANG>();
            foreach (var item in listHDMH)
            {
                lsHD.Add(item);
            }
            gcDanhSachMuaHang.DataSource = lsHD;
        }

        private void gvDanhSachMuaHang_CellValueChanged(object sender, DevExpress.XtraGrid.Views.Base.CellValueChangedEventArgs e)
        {
            if (e.Column.FieldName == "SOLUONG")
            {
                int sl = int.Parse(e.Value.ToString());
                if (sl != 0)
                {
                    double gia = double.Parse(gvDanhSachMuaHang.GetRowCellValue(gvDanhSachMuaHang.FocusedRowHandle, "DONGIA").ToString());
                    gvDanhSachMuaHang.SetRowCellValue(gvDanhSachMuaHang.FocusedRowHandle, "THANHTIEN", sl * gia);
                }
                else
                {
                    gvDanhSachMuaHang.SetRowCellValue(gvDanhSachMuaHang.FocusedRowHandle, "THANHTIEN", 0);
                }
            }
            gvDanhSachMuaHang.UpdateTotalSummary();
            lbThanhTien.Text = double.Parse(gvDanhSachMuaHang.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()).ToString("N0") + " ₫";
        }


        void showHideControl(bool t)
        {
            btnThem.Enabled = t;
            btnLuu.Enabled = !t;
            btnIN.Enabled = !t;
            btnBoQua.Enabled = !t;
            btnXoaMH.Enabled = !t;
        }

        public void enable(bool t)
        {
            cmbKhachHang.Enabled = t;
            gcDanhSachMH.Enabled = t;
            gcDanhSachMuaHang.Enabled = t;
            btnAddnew.Enabled = t;

        }

        void reset(bool t)
        {
            cmbKhachHang.SelectedIndex = 0;
            lbThanhTien.Text = "0 ₫";
            gcDanhSachMuaHang.DataSource = _hdmh.getAll(0);
        }

        DateTime ngay = DateTime.Now;

        private void btnThem_Click(object sender, EventArgs e)
        {
            ngay = DateTime.Now;
            _them = true;
            reset(true);
            enable(true);
            showHideControl(false);
            btnIN.Enabled = false;
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            _them = true;
            saveData();
            loadData();
            showHideControl(true);
            enable(false);
            btnIN.Enabled = true;
            objMain.loadChart();
            btnBoQua.Enabled = true;
        }


        void saveData()
        {
            HOA_DON hd = new HOA_DON();
            
            if (_them)
            {
                hd.NGAYLAP = DateTime.Now;
                hd.MANHANVIEN = "NV02";
                hd.MAKH = int.Parse(cmbKhachHang.SelectedValue.ToString());
                var LuuHD = _hd.add(hd);
                int _maHD = LuuHD.MAHOADON;
                for (int i = 0; i < gvDanhSachMuaHang.RowCount; i++)
                {
                    HOADON_MATHANG hdmh = new HOADON_MATHANG();
                    hdmh.MAHD = _maHD;
                    hdmh.MAMH = gvDanhSachMuaHang.GetRowCellValue(i, "MAMH").ToString();
                    hdmh.SOLUONGMUA = int.Parse(gvDanhSachMuaHang.GetRowCellValue(i, "SOLUONG").ToString());
                    hdmh.THANHTIEN = double.Parse(gvDanhSachMuaHang.GetRowCellValue(i, "THANHTIEN").ToString());
                    _hdmh.add(hdmh);
                }
            }
        }


        private void btnBoQua_Click(object sender, EventArgs e)
        {
            tabControl.SelectedTabPage = tabDanhSach;
            reset(true);
            enable(false);
            showHideControl(true);
            btnIN.Enabled = false;
            tabControl.SelectedTabPage = tabDanhSach;
            reset(true);
            listHDMH.Clear();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void gcDanhSachMuaHang_Click(object sender, EventArgs e)
        {
            _mamh = gvDanhSachMuaHang.GetFocusedRowCellValue("MAMH").ToString();
            lbThanhTien.Text = double.Parse(gvDanhSachMuaHang.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()).ToString("N0") + " ₫";
        }

        private void btnXoaMH_Click(object sender, EventArgs e)
        {
            if (gvDanhSachMuaHang.RowCount > 0)
            {
                gvDanhSachMuaHang.DeleteSelectedRows();
                lbThanhTien.Text = double.Parse(gvDanhSachMuaHang.Columns["THANHTIEN"].SummaryItem.SummaryValue.ToString()).ToString("N0") + " ₫";

                listHDMH.RemoveAll(r => r.MAMH == _mamh);

                gcDanhSachMuaHang.DataSource = listHDMH.ToList();
            }
        }
        public int i = 10;
        private void timer1_Tick(object sender, EventArgs e)
        {
            string a = "";
            label7.Text = DateTime.Now.ToLongTimeString();
            lbThoiGian.Text = DateTime.Now.ToLongTimeString();
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

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            XuatReport("ReportBH", "DANH SÁCH THỐNG KÊ BÁN HÀNG");
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

        private void btnIN_Click(object sender, EventArgs e)
        {
            XuatReportHD("ReportHD", "IN HÓA ĐƠN");
            tabControl.SelectedTabPage = tabDanhSach;
            reset(true);
            listHDMH.Clear();
        }

        private void XuatReportHD(string _reportName, string _tieude)
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
                    doc.SetParameterValue("@NGAY", ngay);
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
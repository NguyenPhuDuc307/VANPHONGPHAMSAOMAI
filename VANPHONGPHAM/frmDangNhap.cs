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

namespace VANPHONGPHAM
{
    public partial class frmDangNhap : DevExpress.XtraEditors.XtraForm
    {
        public frmDangNhap()
        {
            InitializeComponent();
        }

        NHANVIEN _nv;

        private void frmDangNhap_Load(object sender, EventArgs e)
        {
            _nv = new NHANVIEN();
            this.ActiveControl = btnDangNhap;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Panel p = sender as Panel;
            ControlPaint.DrawBorder(e.Graphics, p.DisplayRectangle, Color.Blue, ButtonBorderStyle.Solid);
        }

        private void btnAddnew_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        string user;
        string pass;
        
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            frmMain frm = new frmMain();
            this.Visible = false;
            frm.ShowDialog();
            this.Visible = true;
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (txtPass.PasswordChar == '*')
                txtPass.PasswordChar = '\0';
            else
                txtPass.PasswordChar = '*';
        }
    }
}
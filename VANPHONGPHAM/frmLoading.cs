using DevExpress.XtraSplashScreen;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace VANPHONGPHAM
{
    public partial class frmLoading : SplashScreen
    {
        public frmLoading()
        {
            InitializeComponent();
            timer1.Enabled = true;
            timer1.Start();
            lbTime.Text = DateTime.Now.ToLongTimeString();
        }

        #region Overrides

        public override void ProcessCommand(Enum cmd, object arg)
        {
            base.ProcessCommand(cmd, arg);
        }

        #endregion

        public enum SplashScreenCommand
        {
        }
    }
}
﻿
namespace VANPHONGPHAM
{
    partial class frmMK
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMK));
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPASS = new System.Windows.Forms.TextBox();
            this.btnYes = new System.Windows.Forms.Button();
            this.btnNo = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Location = new System.Drawing.Point(47, 27);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(48, 41);
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 6;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // label1
            // 
            this.label1.AllowDrop = true;
            this.label1.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(101, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(389, 41);
            this.label1.TabIndex = 4;
            this.label1.Text = "Để thực hiện cấp quyền, bạn vui lòng xác nhận mật khẩu";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtPASS
            // 
            this.txtPASS.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPASS.Font = new System.Drawing.Font("Consolas", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPASS.Location = new System.Drawing.Point(8, 7);
            this.txtPASS.Name = "txtPASS";
            this.txtPASS.Size = new System.Drawing.Size(251, 20);
            this.txtPASS.TabIndex = 9;
            this.txtPASS.Text = "ẻt";
            this.txtPASS.UseSystemPasswordChar = true;
            this.txtPASS.TextChanged += new System.EventHandler(this.txtPASS_TextChanged);
            // 
            // btnYes
            // 
            this.btnYes.Location = new System.Drawing.Point(326, 98);
            this.btnYes.Name = "btnYes";
            this.btnYes.Size = new System.Drawing.Size(95, 36);
            this.btnYes.TabIndex = 7;
            this.btnYes.Text = "Yes";
            this.btnYes.UseVisualStyleBackColor = true;
            this.btnYes.Click += new System.EventHandler(this.btnYes_Click);
            // 
            // btnNo
            // 
            this.btnNo.Location = new System.Drawing.Point(442, 98);
            this.btnNo.Name = "btnNo";
            this.btnNo.Size = new System.Drawing.Size(95, 36);
            this.btnNo.TabIndex = 8;
            this.btnNo.Text = "No";
            this.btnNo.UseVisualStyleBackColor = true;
            this.btnNo.Click += new System.EventHandler(this.btnNo_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtPASS);
            this.panel1.Location = new System.Drawing.Point(47, 98);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(257, 36);
            this.panel1.TabIndex = 10;
            // 
            // frmMK
            // 
            this.Appearance.BackColor = System.Drawing.Color.White;
            this.Appearance.ForeColor = System.Drawing.Color.Black;
            this.Appearance.Options.UseBackColor = true;
            this.Appearance.Options.UseForeColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 188);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.btnYes);
            this.Controls.Add(this.btnNo);
            this.Controls.Add(this.svgImageBox1);
            this.Controls.Add(this.label1);
            this.FormBorderEffect = DevExpress.XtraEditors.FormBorderEffect.Shadow;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMK";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmMK";
            this.Load += new System.EventHandler(this.frmMK_Load);
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtPASS;
        private System.Windows.Forms.Button btnYes;
        private System.Windows.Forms.Button btnNo;
        private System.Windows.Forms.Panel panel1;
    }
}
﻿namespace XDPM_Nhom1_QLThueDia
{
    partial class ThemTieuDe
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
            this.tbxNSX = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.tbxTen = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.cboLoai = new DevComponents.DotNetBar.Controls.ComboBoxEx();
            this.btnLuu = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.labelX3 = new DevComponents.DotNetBar.LabelX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.SuspendLayout();
            // 
            // tbxNSX
            // 
            // 
            // 
            // 
            this.tbxNSX.Border.Class = "TextBoxBorder";
            this.tbxNSX.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxNSX.Location = new System.Drawing.Point(230, 66);
            this.tbxNSX.Name = "tbxNSX";
            this.tbxNSX.PreventEnterBeep = true;
            this.tbxNSX.Size = new System.Drawing.Size(258, 27);
            this.tbxNSX.TabIndex = 11;
            this.tbxNSX.TextChanged += new System.EventHandler(this.tbxNSX_TextChanged);
            // 
            // tbxTen
            // 
            // 
            // 
            // 
            this.tbxTen.Border.Class = "TextBoxBorder";
            this.tbxTen.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxTen.Location = new System.Drawing.Point(230, 21);
            this.tbxTen.Name = "tbxTen";
            this.tbxTen.PreventEnterBeep = true;
            this.tbxTen.Size = new System.Drawing.Size(258, 27);
            this.tbxTen.TabIndex = 12;
            this.tbxTen.TextChanged += new System.EventHandler(this.tbxTen_TextChanged);
            // 
            // cboLoai
            // 
            this.cboLoai.DisplayMember = "Text";
            this.cboLoai.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.cboLoai.FormattingEnabled = true;
            this.cboLoai.ItemHeight = 22;
            this.cboLoai.Location = new System.Drawing.Point(230, 111);
            this.cboLoai.Name = "cboLoai";
            this.cboLoai.Size = new System.Drawing.Size(258, 28);
            this.cboLoai.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.cboLoai.TabIndex = 10;
            this.cboLoai.SelectedIndexChanged += new System.EventHandler(this.cboLoai_SelectedIndexChanged);
            // 
            // btnLuu
            // 
            this.btnLuu.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnLuu.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnLuu.Location = new System.Drawing.Point(343, 164);
            this.btnLuu.Name = "btnLuu";
            this.btnLuu.Size = new System.Drawing.Size(118, 42);
            this.btnLuu.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnLuu.TabIndex = 8;
            this.btnLuu.Text = "Lưu";
            this.btnLuu.Click += new System.EventHandler(this.btnLuu_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(115, 164);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(118, 42);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 9;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // labelX3
            // 
            // 
            // 
            // 
            this.labelX3.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX3.Location = new System.Drawing.Point(115, 115);
            this.labelX3.Name = "labelX3";
            this.labelX3.Size = new System.Drawing.Size(71, 23);
            this.labelX3.TabIndex = 5;
            this.labelX3.Text = "Loại đĩa:";
            this.labelX3.Click += new System.EventHandler(this.labelX3_Click);
            // 
            // labelX2
            // 
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(85, 70);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(101, 23);
            this.labelX2.TabIndex = 6;
            this.labelX2.Text = "Nhà sản xuất:";
            this.labelX2.Click += new System.EventHandler(this.labelX2_Click);
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(99, 25);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(87, 23);
            this.labelX1.TabIndex = 7;
            this.labelX1.Text = "Tên tiêu đề:";
            this.labelX1.Click += new System.EventHandler(this.labelX1_Click);
            // 
            // ThemTieuDe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(572, 226);
            this.Controls.Add(this.tbxNSX);
            this.Controls.Add(this.tbxTen);
            this.Controls.Add(this.cboLoai);
            this.Controls.Add(this.btnLuu);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.labelX3);
            this.Controls.Add(this.labelX2);
            this.Controls.Add(this.labelX1);
            this.Name = "ThemTieuDe";
            this.Text = "ThemTieuDe";
            this.Load += new System.EventHandler(this.ThemTieuDe_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbxNSX;
        private DevComponents.DotNetBar.Controls.TextBoxX tbxTen;
        private DevComponents.DotNetBar.Controls.ComboBoxEx cboLoai;
        private DevComponents.DotNetBar.ButtonX btnLuu;
        private DevComponents.DotNetBar.ButtonX btnHuy;
        private DevComponents.DotNetBar.LabelX labelX3;
        private DevComponents.DotNetBar.LabelX labelX2;
        private DevComponents.DotNetBar.LabelX labelX1;
    }
}
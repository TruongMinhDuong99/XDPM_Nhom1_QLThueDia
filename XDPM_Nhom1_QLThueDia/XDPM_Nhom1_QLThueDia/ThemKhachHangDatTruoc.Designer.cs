namespace XDPM_Nhom1_QLThueDia
{
    partial class ThemKhachHangDatTruoc
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
            this.tbxMaKhach = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.btnXacNhan = new DevComponents.DotNetBar.ButtonX();
            this.btnHuy = new DevComponents.DotNetBar.ButtonX();
            this.SuspendLayout();
            // 
            // tbxMaKhach
            // 
            // 
            // 
            // 
            this.tbxMaKhach.Border.Class = "TextBoxBorder";
            this.tbxMaKhach.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.tbxMaKhach.Location = new System.Drawing.Point(77, 15);
            this.tbxMaKhach.Name = "tbxMaKhach";
            this.tbxMaKhach.PreventEnterBeep = true;
            this.tbxMaKhach.Size = new System.Drawing.Size(182, 20);
            this.tbxMaKhach.TabIndex = 10;
            // 
            // labelX1
            // 
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(12, 12);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(59, 23);
            this.labelX1.TabIndex = 9;
            this.labelX1.Text = "Mã khách :";
            // 
            // btnXacNhan
            // 
            this.btnXacNhan.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnXacNhan.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnXacNhan.Location = new System.Drawing.Point(42, 56);
            this.btnXacNhan.Name = "btnXacNhan";
            this.btnXacNhan.Size = new System.Drawing.Size(75, 23);
            this.btnXacNhan.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnXacNhan.TabIndex = 11;
            this.btnXacNhan.Text = "Xác nhận";
            this.btnXacNhan.Click += new System.EventHandler(this.btnXacNhan_Click);
            // 
            // btnHuy
            // 
            this.btnHuy.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnHuy.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnHuy.Location = new System.Drawing.Point(138, 56);
            this.btnHuy.Name = "btnHuy";
            this.btnHuy.Size = new System.Drawing.Size(75, 23);
            this.btnHuy.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnHuy.TabIndex = 12;
            this.btnHuy.Text = "Hủy";
            this.btnHuy.Click += new System.EventHandler(this.btnHuy_Click);
            // 
            // ThemKhachHangDatTruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(269, 91);
            this.Controls.Add(this.btnHuy);
            this.Controls.Add(this.btnXacNhan);
            this.Controls.Add(this.tbxMaKhach);
            this.Controls.Add(this.labelX1);
            this.Name = "ThemKhachHangDatTruoc";
            this.Text = "Thêm khách hàng đặt trước";
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.TextBoxX tbxMaKhach;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ButtonX btnXacNhan;
        private DevComponents.DotNetBar.ButtonX btnHuy;
    }
}
namespace XDPM_Nhom1_QLThueDia
{
    partial class DatTruoc
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupPanel1 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.btnThem = new DevComponents.DotNetBar.ButtonX();
            this.btnDatTruoc = new DevComponents.DotNetBar.ButtonX();
            this.groupPanel4 = new DevComponents.DotNetBar.Controls.GroupPanel();
            this.dgvTieuDe = new DevComponents.DotNetBar.Controls.DataGridViewX();
            this.labelX1 = new DevComponents.DotNetBar.LabelX();
            this.dtiNgayDat = new DevComponents.Editors.DateTimeAdv.DateTimeInput();
            this.itemContainer1 = new DevComponents.DotNetBar.ItemContainer();
            this.txbKH = new DevComponents.DotNetBar.Controls.TextBoxX();
            this.labelX2 = new DevComponents.DotNetBar.LabelX();
            this.groupPanel1.SuspendLayout();
            this.groupPanel4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuDe)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNgayDat)).BeginInit();
            this.SuspendLayout();
            // 
            // groupPanel1
            // 
            this.groupPanel1.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel1.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel1.Controls.Add(this.labelX2);
            this.groupPanel1.Controls.Add(this.txbKH);
            this.groupPanel1.Controls.Add(this.dtiNgayDat);
            this.groupPanel1.Controls.Add(this.labelX1);
            this.groupPanel1.Controls.Add(this.btnThem);
            this.groupPanel1.Controls.Add(this.btnDatTruoc);
            this.groupPanel1.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupPanel1.Location = new System.Drawing.Point(0, 0);
            this.groupPanel1.Name = "groupPanel1";
            this.groupPanel1.Size = new System.Drawing.Size(796, 58);
            // 
            // 
            // 
            this.groupPanel1.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel1.Style.BackColorGradientAngle = 90;
            this.groupPanel1.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel1.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderBottomWidth = 1;
            this.groupPanel1.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel1.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderLeftWidth = 1;
            this.groupPanel1.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderRightWidth = 1;
            this.groupPanel1.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel1.Style.BorderTopWidth = 1;
            this.groupPanel1.Style.CornerDiameter = 4;
            this.groupPanel1.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel1.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel1.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel1.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel1.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel1.TabIndex = 0;
            // 
            // btnThem
            // 
            this.btnThem.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnThem.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnThem.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnThem.Location = new System.Drawing.Point(499, 11);
            this.btnThem.Name = "btnThem";
            this.btnThem.Size = new System.Drawing.Size(141, 38);
            this.btnThem.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnThem.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.itemContainer1});
            this.btnThem.TabIndex = 9;
            this.btnThem.Text = "Thêm khách hàng";
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnDatTruoc
            // 
            this.btnDatTruoc.AccessibleRole = System.Windows.Forms.AccessibleRole.PushButton;
            this.btnDatTruoc.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDatTruoc.ColorTable = DevComponents.DotNetBar.eButtonColor.OrangeWithBackground;
            this.btnDatTruoc.Location = new System.Drawing.Point(646, 11);
            this.btnDatTruoc.Name = "btnDatTruoc";
            this.btnDatTruoc.Size = new System.Drawing.Size(141, 38);
            this.btnDatTruoc.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.btnDatTruoc.TabIndex = 6;
            this.btnDatTruoc.Text = "Đặt trước";
            this.btnDatTruoc.Click += new System.EventHandler(this.btnDatTruoc_Click);
            // 
            // groupPanel4
            // 
            this.groupPanel4.CanvasColor = System.Drawing.SystemColors.Control;
            this.groupPanel4.ColorSchemeStyle = DevComponents.DotNetBar.eDotNetBarStyle.Office2007;
            this.groupPanel4.Controls.Add(this.dgvTieuDe);
            this.groupPanel4.DisabledBackColor = System.Drawing.Color.Empty;
            this.groupPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupPanel4.Location = new System.Drawing.Point(0, 58);
            this.groupPanel4.Name = "groupPanel4";
            this.groupPanel4.Size = new System.Drawing.Size(796, 423);
            // 
            // 
            // 
            this.groupPanel4.Style.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.groupPanel4.Style.BackColorGradientAngle = 90;
            this.groupPanel4.Style.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.groupPanel4.Style.BorderBottom = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderBottomWidth = 1;
            this.groupPanel4.Style.BorderColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
            this.groupPanel4.Style.BorderLeft = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderLeftWidth = 1;
            this.groupPanel4.Style.BorderRight = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderRightWidth = 1;
            this.groupPanel4.Style.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.groupPanel4.Style.BorderTopWidth = 1;
            this.groupPanel4.Style.CornerDiameter = 4;
            this.groupPanel4.Style.CornerType = DevComponents.DotNetBar.eCornerType.Rounded;
            this.groupPanel4.Style.TextAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Center;
            this.groupPanel4.Style.TextColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelText;
            this.groupPanel4.Style.TextLineAlignment = DevComponents.DotNetBar.eStyleTextAlignment.Near;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseDown.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.groupPanel4.StyleMouseOver.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.groupPanel4.TabIndex = 8;
            this.groupPanel4.Text = "Thông tin tiêu đề";
            // 
            // dgvTieuDe
            // 
            this.dgvTieuDe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvTieuDe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvTieuDe.DefaultCellStyle = dataGridViewCellStyle9;
            this.dgvTieuDe.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dgvTieuDe.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(215)))), ((int)(((byte)(229)))));
            this.dgvTieuDe.Location = new System.Drawing.Point(0, 0);
            this.dgvTieuDe.Name = "dgvTieuDe";
            this.dgvTieuDe.Size = new System.Drawing.Size(790, 402);
            this.dgvTieuDe.TabIndex = 3;
            this.dgvTieuDe.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvTieuDe_CellContentClick);
            // 
            // labelX1
            // 
            this.labelX1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX1.Location = new System.Drawing.Point(242, 26);
            this.labelX1.Name = "labelX1";
            this.labelX1.Size = new System.Drawing.Size(55, 23);
            this.labelX1.TabIndex = 10;
            this.labelX1.Text = "Ngày đặt :";
            // 
            // dtiNgayDat
            // 
            this.dtiNgayDat.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.dtiNgayDat.BackgroundStyle.Class = "DateTimeInputBackground";
            this.dtiNgayDat.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgayDat.ButtonDropDown.Shortcut = DevComponents.DotNetBar.eShortcut.AltDown;
            this.dtiNgayDat.ButtonDropDown.Visible = true;
            this.dtiNgayDat.IsInputReadOnly = true;
            this.dtiNgayDat.IsPopupCalendarOpen = false;
            this.dtiNgayDat.Location = new System.Drawing.Point(299, 29);
            // 
            // 
            // 
            // 
            // 
            // 
            this.dtiNgayDat.MonthCalendar.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgayDat.MonthCalendar.CalendarDimensions = new System.Drawing.Size(1, 1);
            this.dtiNgayDat.MonthCalendar.ClearButtonVisible = true;
            // 
            // 
            // 
            this.dtiNgayDat.MonthCalendar.CommandsBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground2;
            this.dtiNgayDat.MonthCalendar.CommandsBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNgayDat.MonthCalendar.CommandsBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarBackground;
            this.dtiNgayDat.MonthCalendar.CommandsBackgroundStyle.BorderTop = DevComponents.DotNetBar.eStyleBorderType.Solid;
            this.dtiNgayDat.MonthCalendar.CommandsBackgroundStyle.BorderTopColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.BarDockedBorder;
            this.dtiNgayDat.MonthCalendar.CommandsBackgroundStyle.BorderTopWidth = 1;
            this.dtiNgayDat.MonthCalendar.CommandsBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgayDat.MonthCalendar.DisplayMonth = new System.DateTime(2020, 12, 1, 0, 0, 0, 0);
            // 
            // 
            // 
            this.dtiNgayDat.MonthCalendar.NavigationBackgroundStyle.BackColor2SchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground2;
            this.dtiNgayDat.MonthCalendar.NavigationBackgroundStyle.BackColorGradientAngle = 90;
            this.dtiNgayDat.MonthCalendar.NavigationBackgroundStyle.BackColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBackground;
            this.dtiNgayDat.MonthCalendar.NavigationBackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.dtiNgayDat.MonthCalendar.TodayButtonVisible = true;
            this.dtiNgayDat.Name = "dtiNgayDat";
            this.dtiNgayDat.Size = new System.Drawing.Size(194, 20);
            this.dtiNgayDat.Style = DevComponents.DotNetBar.eDotNetBarStyle.StyleManagerControlled;
            this.dtiNgayDat.TabIndex = 11;
            // 
            // itemContainer1
            // 
            // 
            // 
            // 
            this.itemContainer1.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.itemContainer1.Name = "itemContainer1";
            // 
            // 
            // 
            this.itemContainer1.TitleMouseOverStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // 
            // 
            this.itemContainer1.TitleStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            // 
            // txbKH
            // 
            // 
            // 
            // 
            this.txbKH.Border.Class = "TextBoxBorder";
            this.txbKH.Border.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.txbKH.Location = new System.Drawing.Point(90, 29);
            this.txbKH.Name = "txbKH";
            this.txbKH.PreventEnterBeep = true;
            this.txbKH.Size = new System.Drawing.Size(146, 20);
            this.txbKH.TabIndex = 13;
            // 
            // labelX2
            // 
            this.labelX2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            // 
            // 
            // 
            this.labelX2.BackgroundStyle.CornerType = DevComponents.DotNetBar.eCornerType.Square;
            this.labelX2.Location = new System.Drawing.Point(16, 26);
            this.labelX2.Name = "labelX2";
            this.labelX2.Size = new System.Drawing.Size(68, 23);
            this.labelX2.TabIndex = 14;
            this.labelX2.Text = "Khách hàng :";
            // 
            // DatTruoc
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 481);
            this.Controls.Add(this.groupPanel4);
            this.Controls.Add(this.groupPanel1);
            this.Name = "DatTruoc";
            this.Text = "Quản lý đặt trước";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.QuanLyDatTruoc_Load);
            this.groupPanel1.ResumeLayout(false);
            this.groupPanel4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTieuDe)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtiNgayDat)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel1;
        private DevComponents.DotNetBar.Controls.GroupPanel groupPanel4;
        private DevComponents.DotNetBar.Controls.DataGridViewX dgvTieuDe;
        private DevComponents.DotNetBar.ButtonX btnDatTruoc;
        private DevComponents.DotNetBar.ButtonX btnThem;
        private DevComponents.Editors.DateTimeAdv.DateTimeInput dtiNgayDat;
        private DevComponents.DotNetBar.LabelX labelX1;
        private DevComponents.DotNetBar.ItemContainer itemContainer1;
        private DevComponents.DotNetBar.Controls.TextBoxX txbKH;
        private DevComponents.DotNetBar.LabelX labelX2;
    }
}
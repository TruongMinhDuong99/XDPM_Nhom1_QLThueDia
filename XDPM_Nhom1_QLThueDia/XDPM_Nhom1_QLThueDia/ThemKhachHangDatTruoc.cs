using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ENTITTY;
using BUS;

namespace XDPM_Nhom1_QLThueDia
{
    public partial class ThemKhachHangDatTruoc : Form
    {
        busPhieuDat busPD;
        public List<eTieuDe> listTD;
        public string maKH;
        public ThemKhachHangDatTruoc()
        {
            InitializeComponent();
            busPD = new busPhieuDat();
            listTD = new List<eTieuDe>();
        }

        private void btnXacNhan_Click(object sender, EventArgs e)
        {

            if (busPD.LayDanhSachTieuDeDuocDat(tbxMaKhach.Text) != null)
            {
                listTD = busPD.LayDanhSachTieuDeDuocDat(tbxMaKhach.Text);
                maKH = tbxMaKhach.Text;
                this.DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Khách hàng không tồn tại!");
                this.DialogResult = DialogResult.Cancel;
                
            }
               
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

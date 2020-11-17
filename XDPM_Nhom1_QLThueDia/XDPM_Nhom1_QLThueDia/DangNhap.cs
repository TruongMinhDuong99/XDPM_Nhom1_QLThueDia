using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using ENTITTY;

namespace XDPM_Nhom1_QLThueDia
{
    public partial class DangNhap : Form
    {
        private eTaiKhoan eTK;
        private busTaiKhoan busTK;
        public DangNhap()
        {
            InitializeComponent();
            txbMatKhau.PasswordChar = '*';
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            eTK = new eTaiKhoan(txbTenDangNhap.Text,txbMatKhau.Text);
            busTK = new busTaiKhoan();
            if (busTK.DangNhap(eTK))
            {
                MessageBox.Show("Đăng nhập thành công !");
                foreach (Form frm in MdiChildren)
                {
                    frm.Close();
                }
                this.Close();
                btnDangNhap.DialogResult = DialogResult.OK;
               

            }
            else
            {
                MessageBox.Show("Đăng nhập thất bại !");
                btnDangNhap.DialogResult = DialogResult.Cancel;
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
                
        }

        private void DangNhap_Load(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}

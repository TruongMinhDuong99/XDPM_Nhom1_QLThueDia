using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace XDPM_Nhom1_QLThueDia
{
    public partial class Menu : Form
    {
        private string tenDN;
        public Menu()
        {
            InitializeComponent();
        }

        private void MenuQuanLy_Load(object sender, EventArgs e)
        {
            đổiMậtKhẩuToolStripMenuItem.Visible = false;
            đăngXuấtToolStripMenuItem.Visible = false;
            quảnLýTiêuĐềToolStripMenuItem.Visible = false;
            quảnLýĐĩaDVDToolStripMenuItem.Visible = false;
            hủyPhíTrảMuộnToolStripMenuItem1.Visible = false;
            thốngKêToolStripMenuItem.Visible = false;
            thayĐổiĐiềuKhoảnChoThuêToolStripMenuItem.Visible = false;
        }

        private void đăngNhậpQuyềnQuảnLýToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            DangNhap frmDN = new DangNhap();
            if (frmDN.ShowDialog() == DialogResult.OK)
            {
                tenDN = frmDN.tenDN;
                đăngNhậpQuyềnQuảnLýToolStripMenuItem.Visible = false;
                đổiMậtKhẩuToolStripMenuItem.Visible = true;
                đăngXuấtToolStripMenuItem.Visible = true;
                quảnLýTiêuĐềToolStripMenuItem.Visible = true;
                quảnLýĐĩaDVDToolStripMenuItem.Visible = true;
                hủyPhíTrảMuộnToolStripMenuItem1.Visible = true;
                thốngKêToolStripMenuItem.Visible = true;
                thayĐổiĐiềuKhoảnChoThuêToolStripMenuItem.Visible = true;
                frmDN.Close();
            }
        }

        private void đăngXuấtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            đổiMậtKhẩuToolStripMenuItem.Visible = false;
            đăngXuấtToolStripMenuItem.Visible = false;
            quảnLýTiêuĐềToolStripMenuItem.Visible = false;
            quảnLýĐĩaDVDToolStripMenuItem.Visible = false;
            hủyPhíTrảMuộnToolStripMenuItem1.Visible = false;
            thốngKêToolStripMenuItem.Visible = false;
            thayĐổiĐiềuKhoảnChoThuêToolStripMenuItem.Visible = false;
            đăngNhậpQuyềnQuảnLýToolStripMenuItem.Visible = true;
        }

        private void đổiMậtKhẩuToolStripMenuItem_Click(object sender, EventArgs e)
        {

            DoiMatKhau frmDMK = new DoiMatKhau(tenDN);
            if (frmDMK.ShowDialog() == DialogResult.OK)
            {
                đổiMậtKhẩuToolStripMenuItem.Visible = false;
                đăngXuấtToolStripMenuItem.Visible = false;
                quảnLýTiêuĐềToolStripMenuItem.Visible = false;
                quảnLýĐĩaDVDToolStripMenuItem.Visible = false;
                hủyPhíTrảMuộnToolStripMenuItem1.Visible = false;
                thốngKêToolStripMenuItem.Visible = false;
                thayĐổiĐiềuKhoảnChoThuêToolStripMenuItem.Visible = false;
                đăngNhậpQuyềnQuảnLýToolStripMenuItem.Visible = true;
            }           
        }

        private void xemThôngTinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XemThongTinKhachHang frmXemTT = new XemThongTinKhachHang();
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            frmXemTT.MdiParent = this;
            frmXemTT.Show();
        }

        private void thôngTinĐĩaTrảTrễToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDiaTraTre frmTKDiaTraTre = new ThongKeDiaTraTre();
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            frmTKDiaTraTre.MdiParent = this;
            frmTKDiaTraTre.Show();
        }

        private void đĩaThuêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeDiaDangThue frmDiaThue = new ThongKeDiaDangThue();
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            frmDiaThue.MdiParent = this;
            frmDiaThue.Show();
        }

        private void tổngThôngTinNợToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ThongKeTongNo frmTongNo = new ThongKeTongNo();
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            frmTongNo.MdiParent = this;
            frmTongNo.Show();
        }

        private void kiểmTraĐĩaTrốngTrongTiêuĐềToolStripMenuItem_Click(object sender, EventArgs e)
        {
            KiemTraDiaTrong frmDiaTrong = new KiemTraDiaTrong();
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            frmDiaTrong.MdiParent = this;
            frmDiaTrong.Show();
        }

        private void đặtTrướcToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DatTruoc frmQLDT = new DatTruoc();
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            frmQLDT.MdiParent = this;
            frmQLDT.Show();
        }

        private void xóaĐặtTrướcToolStripMenuItem_Click(object sender, EventArgs e)
        {
            XoaDatTruoc frmXDT = new XoaDatTruoc();
            foreach (Form frm in MdiChildren)
            {
                frm.Close();
            }
            frmXDT.MdiParent = this;
            frmXDT.Show();
        }
    }
}

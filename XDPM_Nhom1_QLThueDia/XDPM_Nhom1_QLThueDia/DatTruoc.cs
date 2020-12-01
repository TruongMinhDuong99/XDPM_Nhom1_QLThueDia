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
    public partial class DatTruoc : Form
    {
        List<eTieuDe> listTD;
        ePhieuDat dt;
        busPhieuDat busPD;
        busKhachHang busKH;
        private string maKH;
        public DatTruoc()
        {
            InitializeComponent();
            listTD = new List<eTieuDe>();
            dt = new ePhieuDat();
            busPD = new busPhieuDat();
            busKH = new busKhachHang();
            dtiNgayDat.Value = DateTime.Now;
            dtiNgayDat.Enabled = false;
            txbKH.Enabled = false;
        }

        private void QuanLyDatTruoc_Load(object sender, EventArgs e)
        {

        }

        private void btnDatTruoc_Click(object sender, EventArgs e)
        {
            if (maKH != null)
            {
                if (dgvTieuDe.SelectedRows.Count > 0)
                {
                    dt.maDat = busPD.PhatSinhDatTruoc();
                    dt.ngayDat = dtiNgayDat.Value;
                    dt.trangThai = "Đã đặt";
                    dt.maKhachHang = txbKH.Text;
                    dt.maTieuDe = dgvTieuDe.SelectedRows[0].Cells[1].Value.ToString();
                    dt.maDia = null;
                    int trangThai = busPD.ThemDatTruoc(dt);
                    if (trangThai==1)
                    {
                        MessageBox.Show("Thêm thành công");
                    }
                    else if(trangThai==0)
                    {
                        MessageBox.Show("Thêm thất bại");
                    }else if (trangThai == -1)
                    {
                        MessageBox.Show("Khách hàng đã đặt trước tiêu đề này rồi");

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tiêu đề cần đặt !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng thêm khách hàng cần đặt trước !");
            }
        }

        private void dgvTieuDe_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ThemKhachHangDatTruoc frmThem = new ThemKhachHangDatTruoc();            
            if (frmThem.ShowDialog() == DialogResult.OK)
            {               
                dgvTieuDe.Columns.Clear();
                listTD = frmThem.listTD;
                maKH = frmThem.maKH;
                txbKH.Text = busKH.layKhachHangTheoMaKhachHang(maKH).hoTen;
                TaoSTT();
                dgvTieuDe.DataSource = listTD;
                TaoTenCot();
            }
        }
        private void TaoSTT()
        {
            dgvTieuDe.Columns.Add("STT", "STT");
        }
        private void TaoTenCot()
        {
            for (int i = 0; i < listTD.Count; i++)
            {
                dgvTieuDe.Rows[i].Cells[0].Value = i + 1;
                
            }
            dgvTieuDe.Columns["maTieuDe"].HeaderText = "Mã tiêu đề";
            dgvTieuDe.Columns["maTieuDe"].ReadOnly = true;
            dgvTieuDe.Columns["tenTieuDe"].HeaderText = "Tên tiêu đề";
            dgvTieuDe.Columns["tenTieuDe"].ReadOnly = true;
            dgvTieuDe.Columns["nhaSanXuat"].HeaderText = "Nhà sản xuất";
            dgvTieuDe.Columns["nhaSanXuat"].ReadOnly = true;
            dgvTieuDe.Columns["maLoaiDia"].HeaderText = "Loại đĩa";
            dgvTieuDe.Columns["maLoaiDia"].ReadOnly = true;
        }

    }
}

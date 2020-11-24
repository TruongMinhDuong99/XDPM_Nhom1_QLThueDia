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
    public partial class XoaDatTruoc : Form
    {
        busPhieuDat busPD;
        List<eTieuDe> listTD;
        List<eKhachHang> listKH;
        private string maKH;
        public XoaDatTruoc()
        {
            InitializeComponent();
            busPD = new busPhieuDat();
            listKH = new List<eKhachHang>();
            listTD = new List<eTieuDe>();
            dgvKhachHang.Columns.Clear();
            TaoSTTChoKhach();
            listKH = busPD.layDanhSachKhachHangDaDatTruoc();
            dgvKhachHang.DataSource = listKH;
            TaoTenCotChoKhachHang();
        }

        private void btnXoaDatTruoc_Click(object sender, EventArgs e)
        {
            if(dgvKhachHang.SelectedRows.Count > 0)
            {
                if(dgvKhachHang.SelectedRows.Count > 0)
                {
                    maKH = dgvKhachHang.CurrentRow.Cells["maKhachHang"].Value.ToString();
                        if (busPD.XoaDatTruoc(maKH,
                            dgvTieuDe.CurrentRow.Cells["maTieuDe"].Value.ToString()))
                        {
                            MessageBox.Show("Xóa thành công");
                            dgvKhachHang.Columns.Clear();
                            TaoSTTChoKhach();
                            listKH = busPD.layDanhSachKhachHangDaDatTruoc();
                            dgvKhachHang.DataSource = listKH;
                            TaoTenCotChoKhachHang();
                            dgvTieuDe.Columns.Clear();
                            TaoSTTChoTieuDe();
                            listTD = busPD.LayDanhSachTieuDeDaDatTruocCuaKhach(maKH);
                            dgvTieuDe.DataSource = listTD;
                            TaoTenCotChoTieuDe();

                        }
                    else
                    {
                        MessageBox.Show("Xóa thất bại");

                    }
                }
                else
                {
                    MessageBox.Show("Vui lòng chọn tiều đề cần xóa !");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng chọn khách hàng cần xóa !");
            }
        }

        private void XoaDatTruoc_Load(object sender, EventArgs e)
        {
            dgvKhachHang.Columns.Clear();
            TaoSTTChoKhach();
            listKH = busPD.layDanhSachKhachHangDaDatTruoc();
            dgvKhachHang.DataSource = listKH;
            TaoTenCotChoKhachHang();
        }
        private void TaoSTTChoTieuDe()
        {
            dgvTieuDe.Columns.Add("STT", "STT");
        }
        private void TaoSTTChoKhach()
        {
            dgvKhachHang.Columns.Add("STT", "STT");
        }
        private void TaoTenCotChoTieuDe()
        {
            for (int i = 0; i < listTD.Count; i++)
            {
                dgvTieuDe.Rows[i].Cells[0].Value = i + 1;
            }
            dgvTieuDe.Columns["maTieuDe"].HeaderText = "Mã tiêu đề";
            dgvTieuDe.Columns["tenTieuDe"].HeaderText = "Tên tiêu đề";
            dgvTieuDe.Columns["nhaSanXuat"].HeaderText = "Nhà sản xuất";
            dgvTieuDe.Columns["maLoaiDia"].HeaderText = "Loại đĩa";
        }
        private void TaoTenCotChoKhachHang()
        {
            for (int i = 0; i < listKH.Count; i++)
            {
                dgvKhachHang.Rows[i].Cells[0].Value = i + 1;
            }
            dgvKhachHang.Columns["maKhachHang"].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns["hoTen"].HeaderText = "Họ tên";
            dgvKhachHang.Columns["diaChi"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["sDT"].HeaderText = "Số điện thoại";
        }

        private void dgvKhachHang_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                dgvTieuDe.Columns.Clear();
                TaoSTTChoTieuDe();
                listTD = busPD.LayDanhSachTieuDeDaDatTruocCuaKhach(dgvKhachHang.SelectedRows[0].Cells["maKhachHang"].Value.ToString());
                dgvTieuDe.DataSource = listTD;
                TaoTenCotChoTieuDe();
            }
        }
    }
}

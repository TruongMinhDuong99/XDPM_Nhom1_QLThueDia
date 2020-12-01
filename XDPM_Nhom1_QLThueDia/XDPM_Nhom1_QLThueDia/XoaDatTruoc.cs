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
        busDia busDia;
        List<eTieuDe> listTD;
        List<eKhachHang> listKH;
        private string maKH;
        private eDia dia;
        public XoaDatTruoc()
        {
            InitializeComponent();
            busPD = new busPhieuDat();
            listKH = new List<eKhachHang>();
            listTD = new List<eTieuDe>();
            busDia = new busDia();
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
                    maKH = dgvKhachHang.CurrentRow.Cells["makh"].Value.ToString();
                    dia = new eDia();
                    dia = busPD.layDiaGanDatTruoc(maKH, dgvTieuDe.CurrentRow.Cells["maTieuDe"].Value.ToString());                  
                        if (busPD.XoaDatTruoc(maKH,
                            dgvTieuDe.CurrentRow.Cells["maTieuDe"].Value.ToString()))
                        {
                            MessageBox.Show("Xóa thành công");
                            busDia.updateTrangThaiDiaTra(dia.Madia);
                            GanDia frmGan = new GanDia(dia);
                            frmGan.Show();
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
            dgvKhachHang.Columns["makh"].HeaderText = "Mã khách hàng";
            dgvKhachHang.Columns["tenkh"].HeaderText = "Họ tên";
            dgvKhachHang.Columns["diachi"].HeaderText = "Địa chỉ";
            dgvKhachHang.Columns["sodt"].HeaderText = "Số điện thoại";
        }

        private void dgvKhachHang_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                dgvTieuDe.Columns.Clear();
                TaoSTTChoTieuDe();
                listTD = busPD.LayDanhSachTieuDeDaDatTruocCuaKhach(dgvKhachHang.SelectedRows[0].Cells["makh"].Value.ToString());
                dgvTieuDe.DataSource = listTD;
                TaoTenCotChoTieuDe();
            }
        }
    }
}

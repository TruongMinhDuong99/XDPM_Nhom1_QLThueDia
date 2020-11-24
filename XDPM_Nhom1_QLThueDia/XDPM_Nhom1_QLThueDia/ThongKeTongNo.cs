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
    public partial class ThongKeTongNo : Form
    {
        busThongKeTheoKhachHang busTKKH;
        List<eThongKeNoCuaKhachHang> listTK;
        List<eKhachHang> listKH;
        public ThongKeTongNo()
        {
            InitializeComponent();
            listTK = new List<eThongKeNoCuaKhachHang>();
            busTKKH = new busThongKeTheoKhachHang();
            listKH = new List<eKhachHang>();
            cboLoaiKhachHang.Items.Add("Tất cả khách hàng");//loai=0
            cboLoaiKhachHang.Items.Add("Khách hàng có mặt hàng quá hạn");//loai=1
            cboLoaiKhachHang.Items.Add("Khách hàng có phí trả muộn");//loai=2
            cboLoaiKhachHang.Text = "Chọn loại";
        }

        private void cboLoaiKhachHang_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboLoaiKhachHang.Text == "Tất cả khách hàng")
            {
                listKH = busTKKH.LayDanhSachKhachHangNo(0);
                if (listKH.Count > 0)
                {
                    dgvKhachHang.Columns.Clear();
                    TaoSTTChoKhach();
                    dgvKhachHang.DataSource = listKH;
                    TaoTenCotChoKhachHang();
                }
                else
                {
                    dgvThongTinNo.Columns.Clear();
                    MessageBox.Show("Khách hàng trống");
                }

            }
            else if (cboLoaiKhachHang.Text == "Khách hàng có mặt hàng quá hạn")
            {
                listKH = busTKKH.LayDanhSachKhachHangNo(1);
                if (listKH.Count > 0)
                {
                    dgvKhachHang.Columns.Clear();
                    TaoSTTChoKhach();
                    dgvKhachHang.DataSource = listKH;
                    TaoTenCotChoKhachHang();

                }
                else
                {
                    dgvKhachHang.Columns.Clear();
                    MessageBox.Show("Khách hàng trống");
                }
            }
            else if (cboLoaiKhachHang.Text == "Khách hàng có phí trả muộn")
            {
                listKH = busTKKH.LayDanhSachKhachHangNo(2);
                if (listKH.Count > 0)
                {
                    dgvKhachHang.Columns.Clear();
                    TaoSTTChoKhach();
                    dgvKhachHang.DataSource = listKH;
                    TaoTenCotChoKhachHang();
                }
                else
                {
                    dgvKhachHang.Columns.Clear();
                    MessageBox.Show("Khách hàng trống");
                }

            }
        }
        private void TaoSTTChoNo()
        {
            dgvThongTinNo.Columns.Add("STT", "STT");
        }
        private void TaoSTTChoKhach()
        {
            dgvKhachHang.Columns.Add("STT", "STT");
        }
        private void TaoTenCotChoThongTinNo()
        {
            for (int i = 0; i < listTK.Count; i++)
            {
                dgvThongTinNo.Rows[i].Cells[0].Value = i + 1;
            }
            dgvThongTinNo.Columns["tenTieuDe"].HeaderText = "Tiêu đề";
            dgvThongTinNo.Columns["tenDia"].HeaderText = "Tên đĩa";
            dgvThongTinNo.Columns["ngayHenTra"].HeaderText = "Ngày hẹn trả";
            dgvThongTinNo.Columns["ngayTra"].HeaderText = "Ngày trả";
            dgvThongTinNo.Columns["phiTraMuon"].HeaderText = "Phí trả muộn";
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
        private void dgvKhachHang_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                listTK = busTKKH.ThongKeNoCuaKhachHang(dgvKhachHang.CurrentRow.Cells["maKhachHang"].Value.ToString());
                dgvThongTinNo.Columns.Clear();
                TaoSTTChoNo();
                dgvThongTinNo.DataSource = listTK;
                TaoTenCotChoThongTinNo();
                double tongNo = 0.0;
                for (int i = 0; i < listTK.Count; i++)
                {
                    tongNo += listTK[i].phiTraMuon;
                }
                lblTongNo.Text = string.Format("{0:#,##0}", tongNo) + " VNĐ";
            }
        }

        private void dgvKhachHang_RowStateChanged(object sender, DataGridViewRowStateChangedEventArgs e)
        {
            if (dgvKhachHang.SelectedRows.Count > 0)
            {
                listTK = busTKKH.ThongKeNoCuaKhachHang(dgvKhachHang.SelectedRows[0].Cells["maKhachHang"].Value.ToString());
                dgvThongTinNo.Columns.Clear();
                TaoSTTChoNo();
                dgvThongTinNo.DataSource = listTK;
                TaoTenCotChoThongTinNo();
                double tongNo=0.0;
                for(int i = 0; i<listTK.Count; i++)
                {
                    tongNo += listTK[i].phiTraMuon;
                }
                lblTongNo.Text = string.Format("{0:#,##0}", tongNo) + " VNĐ";
            }
        }
    }
}

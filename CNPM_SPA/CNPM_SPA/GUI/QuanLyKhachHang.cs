using ClosedXML.Excel;
using CNPM_SPA.BLL;
using CNPM_SPA.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CNPM_SPA
{
    public partial class QuanLyKhachHang : UserControl
    {
        KhachHangBLL bll = new KhachHangBLL();
        int maDangChon = -1;

        public QuanLyKhachHang()
        {
            InitializeComponent();
            dgvquanlykhachhang.CellClick += dgvquanlykhachhang_CellClick;
        }

        private void QuanLyKhachHang_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvquanlykhachhang.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ================= LOAD DATA =================
        void LoadData()
        {
            dgvquanlykhachhang.DataSource = bll.Load();
        }

        // ================= THÊM =================
        private void btnthemkhachhang_Click(object sender, EventArgs e)
        {
            try
            {
                KhachHangDTO kh = new KhachHangDTO
                {
                    TenKhachHang = txttenkhachhang.Text,
                    SoDienThoai = txtsodienthoai.Text,
                    DiemTichLuy = string.IsNullOrEmpty(txtdiemtichluy.Text)
                                  ? 0
                                  : Convert.ToInt32(txtdiemtichluy.Text)
                };

                bll.Them(kh);
                LoadData();
                ResetForm();

                MessageBox.Show("Thêm khách hàng thành công");
            }
            catch
            {
                MessageBox.Show("Lỗi dữ liệu nhập");
            }
        }

        // ================= SỬA =================
        private void btnsua_Click(object sender, EventArgs e)
        {
            if (maDangChon == -1) return;

            KhachHangDTO kh = new KhachHangDTO
            {
                MaKhachHang = maDangChon,
                TenKhachHang = txttenkhachhang.Text,
                SoDienThoai = txtsodienthoai.Text,
                DiemTichLuy = Convert.ToInt32(txtdiemtichluy.Text)
            };

            bll.Sua(kh);
            LoadData();
            ResetForm();

            MessageBox.Show("Sửa thành công");
        }

        // ================= XOÁ =================
        private void btnxoakhachhang_Click(object sender, EventArgs e)
        {
            if (maDangChon == -1) return;

            bll.Xoa(maDangChon);
            LoadData();
            ResetForm();

            MessageBox.Show("Xoá thành công");
        }

        // ================= TÌM KIẾM =================
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            dgvquanlykhachhang.DataSource = bll.TimKiem(txttimkiem.Text);
        }

        // ================= CLICK GRID =================
        private void dgvquanlykhachhang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvquanlykhachhang.Rows[e.RowIndex];

            maDangChon = Convert.ToInt32(row.Cells["MaKhachHang"].Value);

            txttenkhachhang.Text = row.Cells["TenKhachHang"].Value.ToString();
            txtsodienthoai.Text = row.Cells["SoDienThoai"].Value.ToString();
            txtdiemtichluy.Text = row.Cells["DiemTichLuy"].Value.ToString();

            int diem = Convert.ToInt32(txtdiemtichluy.Text);

            cbvip.Checked = diem >= 100;
            cbthuong.Checked = diem < 100;
        }

        // ================= XUẤT EXCEL =================
        private void btnxuatfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Filter = "Excel File|*.xlsx";

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        using (var wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add("KhachHang");

                            // HEADER
                            for (int i = 0; i < dgvquanlykhachhang.Columns.Count; i++)
                            {
                                ws.Cell(1, i + 1).Value = dgvquanlykhachhang.Columns[i].HeaderText;
                                ws.Cell(1, i + 1).Style.Font.Bold = true;
                            }

                            // DATA
                            for (int i = 0; i < dgvquanlykhachhang.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvquanlykhachhang.Columns.Count; j++)
                                {
                                    ws.Cell(i + 2, j + 1).Value =
                                        dgvquanlykhachhang.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            ws.Columns().AdjustToContents();
                            wb.SaveAs(save.FileName);
                        }

                        MessageBox.Show("Xuất file Excel thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất file: " + ex.Message);
            }
        }

        // ================= RESET FORM =================
        void ResetForm()
        {
            txttenkhachhang.Clear();
            txtsodienthoai.Clear();
            txtdiemtichluy.Text = "0";

            cbvip.Checked = false;
            cbthuong.Checked = false;

            maDangChon = -1;
        }

        private void cbvip_CheckedChanged(object sender, EventArgs e)
        {
            if (cbvip.Checked)
            {
                dgvquanlykhachhang.DataSource = bll.VIP();

                // bỏ tick checkbox khác nếu có
                cbthuong.Checked = false;
            }
            else
            {
                LoadData(); // load lại toàn bộ
            }
        }

        private void cbthuong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbthuong.Checked)
            {
                dgvquanlykhachhang.DataSource = bll.Thuong(); // hoặc SP riêng
                cbvip.Checked = false;
            }
            else
            {
                LoadData();
            }

        }
    }
}

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
    public partial class QuanLyNhanVien : UserControl
    {
        NhanVienBLL bll = new NhanVienBLL();
        int maDangChon = -1;

        public QuanLyNhanVien()
        {
            InitializeComponent();
            dgvquanlynhanvien.CellClick += dgvquanlynhanvien_CellClick;
        }

        private void QuanLyNhanVien_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvquanlynhanvien.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void LoadData()
        {
            dgvquanlynhanvien.DataSource = bll.Load();
        }

        // ================= SPA STAFF =================
        private void cbnhanvienspa_CheckedChanged(object sender, EventArgs e)
        {
            if (cbnhanvienspa.Checked)
            {
                cbnhanvientiepnhan.Checked = false;

                DataTable dt = bll.Load();
                DataView dv = new DataView(dt);
                dv.RowFilter = "ChucVu = 'Kỹ thuật viên'";

                dgvquanlynhanvien.DataSource = dv;
            }
            else LoadData();
        }

        // ================= RECEPTION =================
        private void cbnhanvientiepnhan_CheckedChanged(object sender, EventArgs e)
        {
            if (cbnhanvientiepnhan.Checked)
            {
                cbnhanvienspa.Checked = false;

                DataTable dt = bll.Load();
                DataView dv = new DataView(dt);
                dv.RowFilter = "ChucVu = 'Lễ tân'";

                dgvquanlynhanvien.DataSource = dv;
            }
            else LoadData();
        }

        // ================= ADD =================
        private void btnthemnhanvien_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO
            {
                TenNhanVien = txttennhanvien.Text,
                SoDienThoai = txtsodienthoai.Text,
                ChucVu = txtchucvu.Text,
                LuongCoBan = float.Parse(txtluongcoban.Text)
            };

            bll.Them(nv);
            LoadData();
        }

        // ================= DELETE =================
        private void btnxoanhanvien_Click(object sender, EventArgs e)
        {
            if (maDangChon == -1) return;

            bll.Xoa(maDangChon);
            LoadData();
        }

        // ================= UPDATE =================
        private void btnsua_Click(object sender, EventArgs e)
        {
            NhanVienDTO nv = new NhanVienDTO
            {
                MaNhanVien = maDangChon,
                TenNhanVien = txttennhanvien.Text,
                SoDienThoai = txtsodienthoai.Text,
                ChucVu = txtchucvu.Text,
                LuongCoBan = float.Parse(txtluongcoban.Text)
            };

            bll.Sua(nv);
            LoadData();
        }

        // ================= SEARCH =================
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            dgvquanlynhanvien.DataSource = bll.TimKiem(txttimkiem.Text);
        }

        // ================= CLICK GRID =================
        private void dgvquanlynhanvien_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvquanlynhanvien.Rows[e.RowIndex];

            maDangChon = Convert.ToInt32(row.Cells["MaNhanVien"].Value);
            txttennhanvien.Text = row.Cells["TenNhanVien"].Value.ToString();
            txtsodienthoai.Text = row.Cells["SoDienThoai"].Value.ToString();
            txtchucvu.Text = row.Cells["ChucVu"].Value.ToString();
            txtluongcoban.Text = row.Cells["LuongCoBan"].Value.ToString();
        }

        // ================= EXPORT EXCEL =================
        private void btnxuatfile_Click(object sender, EventArgs e)
        {
            SaveFileDialog save = new SaveFileDialog();
            save.Filter = "Excel|*.xlsx";

            if (save.ShowDialog() == DialogResult.OK)
            {
                using (var wb = new XLWorkbook())
                {
                    var ws = wb.Worksheets.Add("NhanVien");

                    for (int i = 0; i < dgvquanlynhanvien.Columns.Count; i++)
                        ws.Cell(1, i + 1).Value = dgvquanlynhanvien.Columns[i].HeaderText;

                    for (int i = 0; i < dgvquanlynhanvien.Rows.Count; i++)
                        for (int j = 0; j < dgvquanlynhanvien.Columns.Count; j++)
                            ws.Cell(i + 2, j + 1).Value =
                                dgvquanlynhanvien.Rows[i].Cells[j].Value?.ToString();

                    ws.Columns().AdjustToContents();
                    wb.SaveAs(save.FileName);
                }

                MessageBox.Show("Xuất file thành công!");
            }
        }

    }
}

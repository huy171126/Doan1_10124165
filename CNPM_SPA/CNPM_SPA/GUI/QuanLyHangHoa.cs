using ClosedXML.Excel;
using CNPM_SPA.BLL;
using CNPM_SPA.DTO;
using System;
using System.Windows.Forms;

namespace CNPM_SPA
{
    public partial class QuanLyHangHoa : UserControl
    {
        SanPhamBLL bll = new SanPhamBLL();

        public QuanLyHangHoa()
        {
            InitializeComponent();
            dgvhanghoa.CellClick += dgvhanghoa_CellClick;
        }

        private void QuanLyHangHoa_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvhanghoa.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvhanghoa.Width = 1049;
            dgvhanghoa.Height = 394;
        }

        private void LoadData()
        {
            dgvhanghoa.DataSource = bll.Load();
        }

        // ================= CÒN TỒN =================
        private void cbconton_CheckedChanged(object sender, EventArgs e)
        {
            if (cbconton.Checked)
            {
                dgvhanghoa.DataSource = bll.ConTon();
                cbhethang.Checked = false;
            }
            else LoadData();
        }

        // ================= HẾT HÀNG =================
        private void cbhethang_CheckedChanged(object sender, EventArgs e)
        {
            if (cbhethang.Checked)
            {
                dgvhanghoa.DataSource = bll.HetHang();
                cbconton.Checked = false;
            }
            else LoadData();
        }

        // ================= THÊM =================
        private void btnthemhang_Click(object sender, EventArgs e)
        {
            try
            {
                SanPhamDTO sp = new SanPhamDTO
                {
                    TenSanPham = txttensp.Text,
                    MaDanhMuc = Convert.ToInt32(txtmadanhmuc.Text),
                    GiaNhap = Convert.ToDecimal(txtgianhap.Text),
                    GiaBan = Convert.ToDecimal(txtgiaban.Text)
                };

                bll.Them(sp);
                LoadData();
                MessageBox.Show("Thêm thành công");
            }
            catch
            {
                MessageBox.Show("Sai dữ liệu nhập");
            }
        }

        // ================= XOÁ =================
        private void btnxoahang_Click(object sender, EventArgs e)
        {
            if (dgvhanghoa.CurrentRow == null) return;

            int ma = Convert.ToInt32(dgvhanghoa.CurrentRow.Cells["MaSanPham"].Value);

            bll.Xoa(ma);

            LoadData();
            MessageBox.Show("Xoá thành công!");
        }

        // ================= TÌM KIẾM =================
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            dgvhanghoa.DataSource = bll.TimKiem(txttimkiem.Text);
        }

        // ================= CLICK GRID =================
        private void dgvhanghoa_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            var row = dgvhanghoa.Rows[e.RowIndex];

            txttensp.Text = row.Cells["TenSanPham"].Value.ToString();
            txtmadanhmuc.Text = row.Cells["MaDanhMuc"].Value.ToString();
            txtgianhap.Text = row.Cells["GiaNhap"].Value.ToString();
            txtgiaban.Text = row.Cells["GiaBan"].Value.ToString();
        }

        private void btnxuatfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog save = new SaveFileDialog())
                {
                    save.Filter = "Excel Workbook|*.xlsx";
                    save.Title = "Lưu file Excel";

                    if (save.ShowDialog() == DialogResult.OK)
                    {
                        using (var wb = new XLWorkbook())
                        {
                            var ws = wb.Worksheets.Add("SanPham");

                            // ===== HEADER =====
                            for (int i = 0; i < dgvhanghoa.Columns.Count; i++)
                            {
                                ws.Cell(1, i + 1).Value = dgvhanghoa.Columns[i].HeaderText;
                                ws.Cell(1, i + 1).Style.Font.Bold = true;
                                ws.Cell(1, i + 1).Style.Alignment.Horizontal = XLAlignmentHorizontalValues.Center;
                            }

                            // ===== DATA =====
                            for (int i = 0; i < dgvhanghoa.Rows.Count; i++)
                            {
                                for (int j = 0; j < dgvhanghoa.Columns.Count; j++)
                                {
                                    ws.Cell(i + 2, j + 1).Value = dgvhanghoa.Rows[i].Cells[j].Value?.ToString();
                                }
                            }

                            // ===== AUTO FIT =====
                            ws.Columns().AdjustToContents();

                            wb.SaveAs(save.FileName);
                        }

                        MessageBox.Show("Xuất Excel thành công!");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi xuất Excel: " + ex.Message);
            }
        }
    }
}
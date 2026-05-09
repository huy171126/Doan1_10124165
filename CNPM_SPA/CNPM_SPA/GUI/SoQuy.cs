using ClosedXML.Excel;
using CNPM_SPA.BLL;
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
    public partial class SoQuy : UserControl
    {
        SoQuyBLL bll = new SoQuyBLL();

        public SoQuy()
        {
            InitializeComponent();
            this.Load += SoQuy_Load;
        }

        // ================= LOAD =================
        private void SoQuy_Load(object sender, EventArgs e)
        {
            LoadData();
            LoadTong();
            dgvsoquy.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        void LoadData()
        {
            dgvsoquy.DataSource = bll.Lay();
        }

        void LoadTong()
        {
            txtthu.Text = bll.GetThu().ToString();
            txtchi.Text = bll.GetChi().ToString();

            double quy = bll.GetThu() - bll.GetChi();
            txtquy.Text = quy.ToString();
        }

        // ================= THÊM THU =================
        private void btnlapphieuthu_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtsotien.Text, out double tien))
            {
                MessageBox.Show("Số tiền không hợp lệ!");
                return;
            }

            if (txtmota.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mô tả!");
                return;
            }

            bll.Them("Thu", tien, txtmota.Text);

            LoadData();
            LoadTong();
            ClearInput();
        }

        // ================= THÊM CHI =================
        private void btnlapphieuchi_Click(object sender, EventArgs e)
        {
            if (!double.TryParse(txtsotien.Text, out double tien))
            {
                MessageBox.Show("Số tiền không hợp lệ!");
                return;
            }

            if (txtmota.Text.Trim() == "")
            {
                MessageBox.Show("Nhập mô tả!");
                return;
            }

            bll.Them("Chi", tien, txtmota.Text);

            LoadData();
            LoadTong();
            ClearInput();
        }

        // ================= TÌM KIẾM =================
        private void btntimkiem_Click(object sender, EventArgs e)
        {
            dgvsoquy.DataSource = bll.Tim(txttimkiem.Text);
        }

        // ================= CHECKBOX THU =================
        private void cbphieuthu_CheckedChanged(object sender, EventArgs e)
        {
            if (cbphieuthu.Checked)
            {
                cbphieuchi.Checked = false;
                dgvsoquy.DataSource = bll.LocThu();
            }
            else
            {
                ReloadFilter();
            }
        }

        // ================= CHECKBOX CHI =================
        private void cbphieuchi_CheckedChanged(object sender, EventArgs e)
        {
            if (cbphieuchi.Checked)
            {
                cbphieuthu.Checked = false;
                dgvsoquy.DataSource = bll.LocChi();
            }
            else
            {
                ReloadFilter();
            }
        }

        // ================= RESET FILTER =================
        void ReloadFilter()
        {
            if (!cbphieuthu.Checked && !cbphieuchi.Checked)
                LoadData();
        }

        // ================= CLEAR INPUT =================
        void ClearInput()
        {
            txtsotien.Clear();
            txtmota.Clear();
        }

        // ================= CLICK GRID =================
        private void dgvsoquy_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                txtmota.Text = dgvsoquy.Rows[e.RowIndex].Cells["MoTa"].Value.ToString();
                txtsotien.Text = dgvsoquy.Rows[e.RowIndex].Cells["SoTien"].Value.ToString();
            }
        }

        private void cb7ngaytruoc_CheckedChanged(object sender, EventArgs e)
        {
            if (cb7ngaytruoc.Checked)
            {
                // Nếu chỉ chọn 7 ngày
                if (!cbphieuthu.Checked && !cbphieuchi.Checked)
                {
                    dgvsoquy.DataSource = bll.Lay7Ngay();
                }
                // Nếu có chọn Thu
                else if (cbphieuthu.Checked)
                {
                    dgvsoquy.DataSource = bll.Loc7NgayTheoLoai("Thu");
                }
                // Nếu có chọn Chi
                else if (cbphieuchi.Checked)
                {
                    dgvsoquy.DataSource = bll.Loc7NgayTheoLoai("Chi");
                }
            }
            else
            {
                // bỏ tick => quay lại filter bình thường
                if (cbphieuthu.Checked)
                    dgvsoquy.DataSource = bll.LocThu();
                else if (cbphieuchi.Checked)
                    dgvsoquy.DataSource = bll.LocChi();
                else
                    LoadData();
            }
        }

        private void btnxuatfile_Click(object sender, EventArgs e)
        {
            try
            {
                using (SaveFileDialog sfd = new SaveFileDialog()
                {
                    Filter = "Excel Workbook|*.xlsx",
                    FileName = "SoQuy.xlsx"
                })
                {
                    if (sfd.ShowDialog() == DialogResult.OK)
                    {
                        using (XLWorkbook wb = new XLWorkbook())
                        {
                            DataTable dt = (DataTable)dgvsoquy.DataSource;

                            wb.Worksheets.Add(dt, "SoQuy");
                            wb.SaveAs(sfd.FileName);
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
    }
}


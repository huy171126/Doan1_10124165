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
    public partial class QuanLyPhong : UserControl
    {
        PhongBLL bll = new PhongBLL();
        int maPhongSelected = -1;

        public QuanLyPhong()
        {
            InitializeComponent();
            this.Load += QuanLyPhong_Load;
        }

        private void QuanLyPhong_Load(object sender, EventArgs e)
        {
            LoadData();
            dgvquanlyphong.Width = 1049;
            dgvquanlyphong.Height = 417;

            dgvquanlyphong.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void LoadData()
        {
            dgvquanlyphong.DataSource = bll.LoadTatCa();
        }

        private void dgvquanlyphong_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0) return;

            DataGridViewRow row = dgvquanlyphong.Rows[e.RowIndex];

            maPhongSelected = Convert.ToInt32(row.Cells["MaPhong"].Value);
            txttenphong.Text = row.Cells["TenPhong"].Value.ToString();
            txttrangthai.Text = row.Cells["TrangThai"].Value.ToString();
        }

        private void cbdanghoatdong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbdanghoatdong.Checked)
            {
                cbphongtrong.Checked = false;
                dgvquanlyphong.DataSource = bll.LoadDangHoatDong();
            }
            else if (!cbphongtrong.Checked)
            {
                LoadData();
            }
        }

        private void cbphongtrong_CheckedChanged(object sender, EventArgs e)
        {
            if (cbphongtrong.Checked)
            {
                cbdanghoatdong.Checked = false;
                dgvquanlyphong.DataSource = bll.LoadPhongTrong();
            }
            else if (!cbdanghoatdong.Checked)
            {
                LoadData();
            }
        }

        private void btnthemphong_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txttenphong.Text)) return;

            bll.Them(txttenphong.Text, txttrangthai.Text);
            LoadData();
        }

        private void btnxoaphong_Click(object sender, EventArgs e)
        {
            if (maPhongSelected == -1) return;

            bll.Xoa(maPhongSelected);
            LoadData();
            maPhongSelected = -1;
        }

        private void btnsuaphong_Click(object sender, EventArgs e)
        {
            if (maPhongSelected == -1) return;

            bll.Sua(maPhongSelected, txttenphong.Text, txttrangthai.Text);
            LoadData();
        }

        private void QuanLyPhong_Load_1(object sender, EventArgs e)
        {

        }
    }
}

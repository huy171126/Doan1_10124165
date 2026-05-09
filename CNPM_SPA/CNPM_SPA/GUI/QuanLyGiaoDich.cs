using CNPM_SPA.BLL;
using CNPM_SPA.GUI;
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
    public partial class QuanLyGiaoDich : UserControl
    {
        GiaoDichBLL bll = new GiaoDichBLL();
        DataTable dt;

        public QuanLyGiaoDich()
        {
            InitializeComponent();
            this.Load += QuanLyGiaoDich_Load;
        }

        private void QuanLyGiaoDich_Load(object sender, EventArgs e)
        {
            dt = bll.LoadAll();
            dgvquanlygiaodich.DataSource = dt;
            dgvquanlygiaodich.Width = 1049;
            dgvquanlygiaodich.Height = 417;

            dgvquanlygiaodich.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        private void Filter()
        {
            List<string> filters = new List<string>();

            // LOẠI
            if (cbthanhtoan.Checked && !cbnhaphang.Checked)
                filters.Add("LoaiGiaoDich = 'Hóa đơn'");

            if (cbnhaphang.Checked && !cbthanhtoan.Checked)
                filters.Add("LoaiGiaoDich = 'Nhập hàng'");

            // NGÀY
            if (cbtrongngay.Checked)
                filters.Add($"Ngay >= '{DateTime.Today:yyyy-MM-dd}'");

            if (cb7ngaytruoc.Checked)
            {
                DateTime from = DateTime.Today.AddDays(-7);
                filters.Add($"Ngay >= '{from:yyyy-MM-dd}'");
            }

            string where = string.Join(" AND ", filters);

            DataView dv = new DataView(dt);

            try
            {
                dv.RowFilter = where;
                dgvquanlygiaodich.DataSource = dv;
            }
            catch
            {
                dgvquanlygiaodich.DataSource = dt;
            }
        }

        private void cbthanhtoan_CheckedChanged(object sender, EventArgs e) => Filter();
        private void cbnhaphang_CheckedChanged(object sender, EventArgs e) => Filter();
        private void cbtrongngay_CheckedChanged(object sender, EventArgs e) => Filter();
        private void cb7ngaytruoc_CheckedChanged(object sender, EventArgs e) => Filter();

        private void btnthemgiaodich_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn muốn thêm giao dịch nào?\n\nYes: Hóa đơn\nNo: Phiếu nhập\nCancel: Thoát",
                "Chọn giao dịch",
                MessageBoxButtons.YesNoCancel,
                MessageBoxIcon.Question
            );

            if (result == DialogResult.Yes)
            {
                frHoaDon hd = new frHoaDon();
                hd.Show();
            }
            else if (result == DialogResult.No)
            {
                frPhieuNhap pn = new frPhieuNhap();
                pn.Show();
            }
        }

        private void QuanLyGiaoDich_Load_1(object sender, EventArgs e)
        {

        }
    }
}


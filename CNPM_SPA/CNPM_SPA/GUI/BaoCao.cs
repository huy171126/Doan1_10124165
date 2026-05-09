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
    public partial class BaoCao : UserControl
    {
        BaoCaoBLL bll = new BaoCaoBLL();

        public BaoCao()
        {
            InitializeComponent();
        }

        private void BaoCao_Load(object sender, EventArgs e)
        {
            LoadAll();

            dgvdoanhthu.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvsoluongton.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        // ================= LOAD =================
        void LoadAll()
        {
            dgvsoluongton.DataSource = bll.TonKho();
            dgvdoanhthu.DataSource = bll.DoanhThuNgay();
        }

        // ================= FILTER DOANH THU =================
        private void cbxemtruoctrongngay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxemtruoctrongngay.Checked)
            {
                cbxemtruoc7ngay.Checked = false;
                cbxemtruoc30ngay.Checked = false;

                dgvdoanhthu.DataSource = bll.DoanhThuNgay();
            }
        }

        private void cbxemtruoc7ngay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxemtruoc7ngay.Checked)
            {
                cbxemtruoctrongngay.Checked = false;
                cbxemtruoc30ngay.Checked = false;

                dgvdoanhthu.DataSource = bll.DoanhThu7Ngay();
            }
        }

        private void cbxemtruoc30ngay_CheckedChanged(object sender, EventArgs e)
        {
            if (cbxemtruoc30ngay.Checked)
            {
                cbxemtruoctrongngay.Checked = false;
                cbxemtruoc7ngay.Checked = false;

                dgvdoanhthu.DataSource = bll.DoanhThu30Ngay();
            }
        }

        // ================= EXPORT CHUNG =================
        void Export(DataTable dt, string fileName)
        {
            using (SaveFileDialog sfd = new SaveFileDialog()
            {
                FileName = fileName,
                Filter = "Excel|*.xlsx"
            })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    using (var wb = new XLWorkbook())
                    {
                        wb.Worksheets.Add(dt, "BaoCao");
                        wb.SaveAs(sfd.FileName);
                    }

                    MessageBox.Show("Xuất file thành công!");
                }
            }
        }

        // ================= BUTTON EXPORT =================
        private void btnxuatsoluongton_Click(object sender, EventArgs e)
        {
            Export((DataTable)dgvsoluongton.DataSource, "TonKho.xlsx");
        }

        private void btnxuatdoanhthutrongngay_Click(object sender, EventArgs e)
        {
            Export(bll.DoanhThuNgay(), "DoanhThu_Ngay.xlsx");
        }

        private void btnxuatdoanhthu7ngay_Click(object sender, EventArgs e)
        {
            Export(bll.DoanhThu7Ngay(), "DoanhThu_7Ngay.xlsx");
        }

        private void btnxuatdoanhthu30ngay_Click(object sender, EventArgs e)
        {
            Export(bll.DoanhThu30Ngay(), "DoanhThu_30Ngay.xlsx");
        }
    }
}

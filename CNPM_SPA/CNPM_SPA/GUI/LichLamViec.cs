using CNPM_SPA.BLL;
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace CNPM_SPA
{
    public partial class LichLamViec : UserControl
    {
        LichLamViecBLL bll = new LichLamViecBLL();

        int START_HOUR = 6;
        int END_HOUR = 22; // 22h
        int ROW_COUNT = 17; // 6 → 22

        public LichLamViec()
        {
            InitializeComponent();
        }

        // ================= LOAD =================
        private void LichLamViec_Load(object sender, EventArgs e)
        {
            InitGrid();
            LoadLich();
            dgvlichlam.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

        }

        // ================= INIT GRID =================
        void InitGrid()
        {
            dgvlichlam.Columns.Clear();
            dgvlichlam.Rows.Clear();

            string[] days = { "T2", "T3", "T4", "T5", "T6", "T7", "CN" };

            dgvlichlam.ColumnCount = 7;
            for (int i = 0; i < 7; i++)
                dgvlichlam.Columns[i].Name = days[i];

            dgvlichlam.RowCount = ROW_COUNT;

            for (int i = 0; i < ROW_COUNT; i++)
            {
                dgvlichlam.Rows[i].HeaderCell.Value = (START_HOUR + i) + "h";
                dgvlichlam.Rows[i].Height = 35;
            }

            dgvlichlam.RowHeadersWidth = 60;
            dgvlichlam.AllowUserToAddRows = false;
        }

        // ================= MAP NGÀY =================
        int GetCol(DateTime t)
        {
            switch (t.DayOfWeek)
            {
                case DayOfWeek.Monday: return 0;
                case DayOfWeek.Tuesday: return 1;
                case DayOfWeek.Wednesday: return 2;
                case DayOfWeek.Thursday: return 3;
                case DayOfWeek.Friday: return 4;
                case DayOfWeek.Saturday: return 5;
                case DayOfWeek.Sunday: return 6;
                default: return 0;
            }
        }

        // ================= MAP GIỜ =================
        int GetRow(DateTime t)
        {
            int row = t.Hour - START_HOUR;

            if (row < 0 || row >= ROW_COUNT)
                return -1;

            return row;
        }

        // ================= LOAD LỊCH =================
        void LoadLich()
        {
            DateTime startWeek = DateTime.Today.AddDays(-(int)DateTime.Today.DayOfWeek + 1);

            DataTable dt = bll.GetLichTuan(startWeek);

            if (dt == null) return;

            foreach (DataRow r in dt.Rows)
            {
                if (r["ThoiGian"] == DBNull.Value) continue;

                DateTime time = Convert.ToDateTime(r["ThoiGian"]);
                string tenKH = r["TenKhachHang"].ToString();

                int col = GetCol(time);
                int row = GetRow(time);

                if (row == -1) continue;

                dgvlichlam[col, row].Value = tenKH;
                dgvlichlam[col, row].Style.BackColor = Color.LightSkyBlue;
                dgvlichlam[col, row].Style.Font = new Font("Segoe UI", 9, FontStyle.Bold);
            }
        }

        // ================= CLICK CELL =================
        private void dgvlichlam_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0 || e.ColumnIndex < 0) return;

            var val = dgvlichlam[e.ColumnIndex, e.RowIndex].Value;

            if (val != null)
                MessageBox.Show(val.ToString());
        }
    }
}
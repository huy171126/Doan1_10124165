namespace CNPM_SPA
{
    partial class QuanLyGiaoDich
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.dgvquanlygiaodich = new System.Windows.Forms.DataGridView();
            this.cbthanhtoan = new System.Windows.Forms.CheckBox();
            this.cbnhaphang = new System.Windows.Forms.CheckBox();
            this.btnthemgiaodich = new System.Windows.Forms.Button();
            this.cbtrongngay = new System.Windows.Forms.CheckBox();
            this.cb7ngaytruoc = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlygiaodich)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(375, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "QUẢN LÝ GIAO DỊCH";
            // 
            // dgvquanlygiaodich
            // 
            this.dgvquanlygiaodich.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquanlygiaodich.Location = new System.Drawing.Point(19, 140);
            this.dgvquanlygiaodich.Name = "dgvquanlygiaodich";
            this.dgvquanlygiaodich.Size = new System.Drawing.Size(1049, 417);
            this.dgvquanlygiaodich.TabIndex = 6;
            // 
            // cbthanhtoan
            // 
            this.cbthanhtoan.AutoSize = true;
            this.cbthanhtoan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbthanhtoan.Location = new System.Drawing.Point(19, 100);
            this.cbthanhtoan.Name = "cbthanhtoan";
            this.cbthanhtoan.Size = new System.Drawing.Size(95, 23);
            this.cbthanhtoan.TabIndex = 7;
            this.cbthanhtoan.Text = "Thanh toán";
            this.cbthanhtoan.UseVisualStyleBackColor = true;
            this.cbthanhtoan.CheckedChanged += new System.EventHandler(this.cbthanhtoan_CheckedChanged);
            // 
            // cbnhaphang
            // 
            this.cbnhaphang.AutoSize = true;
            this.cbnhaphang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnhaphang.Location = new System.Drawing.Point(145, 100);
            this.cbnhaphang.Name = "cbnhaphang";
            this.cbnhaphang.Size = new System.Drawing.Size(94, 23);
            this.cbnhaphang.TabIndex = 8;
            this.cbnhaphang.Text = "Nhập hàng";
            this.cbnhaphang.UseVisualStyleBackColor = true;
            this.cbnhaphang.CheckedChanged += new System.EventHandler(this.cbnhaphang_CheckedChanged);
            // 
            // btnthemgiaodich
            // 
            this.btnthemgiaodich.BackColor = System.Drawing.Color.GreenYellow;
            this.btnthemgiaodich.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemgiaodich.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthemgiaodich.Location = new System.Drawing.Point(40, 587);
            this.btnthemgiaodich.Name = "btnthemgiaodich";
            this.btnthemgiaodich.Size = new System.Drawing.Size(137, 31);
            this.btnthemgiaodich.TabIndex = 11;
            this.btnthemgiaodich.Text = "Thêm giao dịch";
            this.btnthemgiaodich.UseVisualStyleBackColor = false;
            this.btnthemgiaodich.Click += new System.EventHandler(this.btnthemgiaodich_Click);
            // 
            // cbtrongngay
            // 
            this.cbtrongngay.AutoSize = true;
            this.cbtrongngay.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbtrongngay.Location = new System.Drawing.Point(323, 100);
            this.cbtrongngay.Name = "cbtrongngay";
            this.cbtrongngay.Size = new System.Drawing.Size(95, 23);
            this.cbtrongngay.TabIndex = 12;
            this.cbtrongngay.Text = "Trong ngày";
            this.cbtrongngay.UseVisualStyleBackColor = true;
            this.cbtrongngay.CheckedChanged += new System.EventHandler(this.cbtrongngay_CheckedChanged);
            // 
            // cb7ngaytruoc
            // 
            this.cb7ngaytruoc.AutoSize = true;
            this.cb7ngaytruoc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb7ngaytruoc.Location = new System.Drawing.Point(472, 100);
            this.cb7ngaytruoc.Name = "cb7ngaytruoc";
            this.cb7ngaytruoc.Size = new System.Drawing.Size(105, 23);
            this.cb7ngaytruoc.TabIndex = 13;
            this.cb7ngaytruoc.Text = "7 ngày trước";
            this.cb7ngaytruoc.UseVisualStyleBackColor = true;
            this.cb7ngaytruoc.CheckedChanged += new System.EventHandler(this.cb7ngaytruoc_CheckedChanged);
            // 
            // QuanLyGiaoDich
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cb7ngaytruoc);
            this.Controls.Add(this.cbtrongngay);
            this.Controls.Add(this.btnthemgiaodich);
            this.Controls.Add(this.cbnhaphang);
            this.Controls.Add(this.cbthanhtoan);
            this.Controls.Add(this.dgvquanlygiaodich);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyGiaoDich";
            this.Size = new System.Drawing.Size(1086, 646);
            this.Load += new System.EventHandler(this.QuanLyGiaoDich_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlygiaodich)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvquanlygiaodich;
        private System.Windows.Forms.CheckBox cbthanhtoan;
        private System.Windows.Forms.CheckBox cbnhaphang;
        private System.Windows.Forms.Button btnthemgiaodich;
        private System.Windows.Forms.CheckBox cbtrongngay;
        private System.Windows.Forms.CheckBox cb7ngaytruoc;
    }
}

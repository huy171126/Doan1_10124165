namespace CNPM_SPA
{
    partial class QuanLyHangHoa
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
            this.cbconton = new System.Windows.Forms.CheckBox();
            this.cbhethang = new System.Windows.Forms.CheckBox();
            this.btnthemhang = new System.Windows.Forms.Button();
            this.btnxuatfile = new System.Windows.Forms.Button();
            this.dgvhanghoa = new System.Windows.Forms.DataGridView();
            this.btnxoahang = new System.Windows.Forms.Button();
            this.btntimkiem = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtgianhap = new System.Windows.Forms.TextBox();
            this.txtmadanhmuc = new System.Windows.Forms.TextBox();
            this.txttensp = new System.Windows.Forms.TextBox();
            this.txtgiaban = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).BeginInit();
            this.SuspendLayout();
            // 
            // cbconton
            // 
            this.cbconton.AutoSize = true;
            this.cbconton.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbconton.Location = new System.Drawing.Point(18, 88);
            this.cbconton.Name = "cbconton";
            this.cbconton.Size = new System.Drawing.Size(109, 23);
            this.cbconton.TabIndex = 0;
            this.cbconton.Text = "Còn tồn hàng";
            this.cbconton.UseVisualStyleBackColor = true;
            this.cbconton.CheckedChanged += new System.EventHandler(this.cbconton_CheckedChanged);
            // 
            // cbhethang
            // 
            this.cbhethang.AutoSize = true;
            this.cbhethang.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbhethang.Location = new System.Drawing.Point(144, 88);
            this.cbhethang.Name = "cbhethang";
            this.cbhethang.Size = new System.Drawing.Size(100, 23);
            this.cbhethang.TabIndex = 1;
            this.cbhethang.Text = "Đã hết hàng";
            this.cbhethang.UseVisualStyleBackColor = true;
            this.cbhethang.CheckedChanged += new System.EventHandler(this.cbhethang_CheckedChanged);
            // 
            // btnthemhang
            // 
            this.btnthemhang.BackColor = System.Drawing.Color.GreenYellow;
            this.btnthemhang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemhang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthemhang.Location = new System.Drawing.Point(41, 589);
            this.btnthemhang.Name = "btnthemhang";
            this.btnthemhang.Size = new System.Drawing.Size(137, 31);
            this.btnthemhang.TabIndex = 2;
            this.btnthemhang.Text = "Thêm Hàng";
            this.btnthemhang.UseVisualStyleBackColor = false;
            this.btnthemhang.Click += new System.EventHandler(this.btnthemhang_Click);
            // 
            // btnxuatfile
            // 
            this.btnxuatfile.BackColor = System.Drawing.Color.GreenYellow;
            this.btnxuatfile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnxuatfile.Location = new System.Drawing.Point(222, 589);
            this.btnxuatfile.Name = "btnxuatfile";
            this.btnxuatfile.Size = new System.Drawing.Size(137, 31);
            this.btnxuatfile.TabIndex = 3;
            this.btnxuatfile.Text = "Xuất file";
            this.btnxuatfile.UseVisualStyleBackColor = false;
            this.btnxuatfile.Click += new System.EventHandler(this.btnxuatfile_Click);
            // 
            // dgvhanghoa
            // 
            this.dgvhanghoa.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvhanghoa.Location = new System.Drawing.Point(18, 138);
            this.dgvhanghoa.Name = "dgvhanghoa";
            this.dgvhanghoa.Size = new System.Drawing.Size(1049, 394);
            this.dgvhanghoa.TabIndex = 4;
            // 
            // btnxoahang
            // 
            this.btnxoahang.BackColor = System.Drawing.Color.GreenYellow;
            this.btnxoahang.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoahang.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnxoahang.Location = new System.Drawing.Point(402, 589);
            this.btnxoahang.Name = "btnxoahang";
            this.btnxoahang.Size = new System.Drawing.Size(137, 31);
            this.btnxoahang.TabIndex = 5;
            this.btnxoahang.Text = "Xoá hàng";
            this.btnxoahang.UseVisualStyleBackColor = false;
            this.btnxoahang.Click += new System.EventHandler(this.btnxoahang_Click);
            // 
            // btntimkiem
            // 
            this.btntimkiem.BackColor = System.Drawing.Color.GreenYellow;
            this.btntimkiem.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btntimkiem.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btntimkiem.Location = new System.Drawing.Point(583, 589);
            this.btntimkiem.Name = "btntimkiem";
            this.btntimkiem.Size = new System.Drawing.Size(137, 31);
            this.btntimkiem.TabIndex = 6;
            this.btntimkiem.Text = "Tìm kiếm";
            this.btntimkiem.UseVisualStyleBackColor = false;
            this.btntimkiem.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(750, 592);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(264, 26);
            this.txttimkiem.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(370, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(295, 31);
            this.label1.TabIndex = 8;
            this.label1.Text = "QUẢN LÝ HÀNG HOÁ";
            // 
            // txtgianhap
            // 
            this.txtgianhap.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgianhap.Location = new System.Drawing.Point(483, 538);
            this.txtgianhap.Name = "txtgianhap";
            this.txtgianhap.Size = new System.Drawing.Size(196, 26);
            this.txtgianhap.TabIndex = 9;
            // 
            // txtmadanhmuc
            // 
            this.txtmadanhmuc.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtmadanhmuc.Location = new System.Drawing.Point(332, 538);
            this.txtmadanhmuc.Name = "txtmadanhmuc";
            this.txtmadanhmuc.Size = new System.Drawing.Size(97, 26);
            this.txtmadanhmuc.TabIndex = 10;
            // 
            // txttensp
            // 
            this.txttensp.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttensp.Location = new System.Drawing.Point(18, 538);
            this.txttensp.Name = "txttensp";
            this.txttensp.Size = new System.Drawing.Size(264, 26);
            this.txttensp.TabIndex = 11;
            // 
            // txtgiaban
            // 
            this.txtgiaban.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtgiaban.Location = new System.Drawing.Point(709, 538);
            this.txtgiaban.Name = "txtgiaban";
            this.txtgiaban.Size = new System.Drawing.Size(196, 26);
            this.txtgiaban.TabIndex = 12;
            // 
            // QuanLyHangHoa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.txtgiaban);
            this.Controls.Add(this.txttensp);
            this.Controls.Add(this.txtmadanhmuc);
            this.Controls.Add(this.txtgianhap);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btntimkiem);
            this.Controls.Add(this.btnxoahang);
            this.Controls.Add(this.dgvhanghoa);
            this.Controls.Add(this.btnxuatfile);
            this.Controls.Add(this.btnthemhang);
            this.Controls.Add(this.cbhethang);
            this.Controls.Add(this.cbconton);
            this.Name = "QuanLyHangHoa";
            this.Size = new System.Drawing.Size(1086, 646);
            this.Load += new System.EventHandler(this.QuanLyHangHoa_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvhanghoa)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbconton;
        private System.Windows.Forms.CheckBox cbhethang;
        private System.Windows.Forms.Button btnthemhang;
        private System.Windows.Forms.Button btnxuatfile;
        private System.Windows.Forms.DataGridView dgvhanghoa;
        private System.Windows.Forms.Button btnxoahang;
        private System.Windows.Forms.Button btntimkiem;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtgianhap;
        private System.Windows.Forms.TextBox txtmadanhmuc;
        private System.Windows.Forms.TextBox txttensp;
        private System.Windows.Forms.TextBox txtgiaban;
    }
}

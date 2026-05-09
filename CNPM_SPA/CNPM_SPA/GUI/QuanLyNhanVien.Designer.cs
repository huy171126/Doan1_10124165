namespace CNPM_SPA
{
    partial class QuanLyNhanVien
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
            this.dgvquanlynhanvien = new System.Windows.Forms.DataGridView();
            this.cbnhanvientiepnhan = new System.Windows.Forms.CheckBox();
            this.cbnhanvienspa = new System.Windows.Forms.CheckBox();
            this.btnthemnhanvien = new System.Windows.Forms.Button();
            this.btnxoanhanvien = new System.Windows.Forms.Button();
            this.btnsua = new System.Windows.Forms.Button();
            this.btnxoa = new System.Windows.Forms.Button();
            this.txttimkiem = new System.Windows.Forms.TextBox();
            this.btnxuatfile = new System.Windows.Forms.Button();
            this.txttennhanvien = new System.Windows.Forms.TextBox();
            this.txtsodienthoai = new System.Windows.Forms.TextBox();
            this.txtchucvu = new System.Windows.Forms.TextBox();
            this.txtluongcoban = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlynhanvien)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(347, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(300, 31);
            this.label1.TabIndex = 9;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dgvquanlynhanvien
            // 
            this.dgvquanlynhanvien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquanlynhanvien.Location = new System.Drawing.Point(18, 122);
            this.dgvquanlynhanvien.Name = "dgvquanlynhanvien";
            this.dgvquanlynhanvien.Size = new System.Drawing.Size(1049, 384);
            this.dgvquanlynhanvien.TabIndex = 10;
            // 
            // cbnhanvientiepnhan
            // 
            this.cbnhanvientiepnhan.AutoSize = true;
            this.cbnhanvientiepnhan.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnhanvientiepnhan.Location = new System.Drawing.Point(164, 85);
            this.cbnhanvientiepnhan.Name = "cbnhanvientiepnhan";
            this.cbnhanvientiepnhan.Size = new System.Drawing.Size(137, 23);
            this.cbnhanvientiepnhan.TabIndex = 11;
            this.cbnhanvientiepnhan.Text = "Nhân viên tiếp tân";
            this.cbnhanvientiepnhan.UseVisualStyleBackColor = true;
            this.cbnhanvientiepnhan.CheckedChanged += new System.EventHandler(this.cbnhanvientiepnhan_CheckedChanged);
            // 
            // cbnhanvienspa
            // 
            this.cbnhanvienspa.AutoSize = true;
            this.cbnhanvienspa.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbnhanvienspa.Location = new System.Drawing.Point(18, 85);
            this.cbnhanvienspa.Name = "cbnhanvienspa";
            this.cbnhanvienspa.Size = new System.Drawing.Size(114, 23);
            this.cbnhanvienspa.TabIndex = 12;
            this.cbnhanvienspa.Text = "Nhân viên spa";
            this.cbnhanvienspa.UseVisualStyleBackColor = true;
            this.cbnhanvienspa.CheckedChanged += new System.EventHandler(this.cbnhanvienspa_CheckedChanged);
            // 
            // btnthemnhanvien
            // 
            this.btnthemnhanvien.BackColor = System.Drawing.Color.GreenYellow;
            this.btnthemnhanvien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemnhanvien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthemnhanvien.Location = new System.Drawing.Point(38, 587);
            this.btnthemnhanvien.Name = "btnthemnhanvien";
            this.btnthemnhanvien.Size = new System.Drawing.Size(172, 31);
            this.btnthemnhanvien.TabIndex = 13;
            this.btnthemnhanvien.Text = "Thêm nhân viên";
            this.btnthemnhanvien.UseVisualStyleBackColor = false;
            this.btnthemnhanvien.Click += new System.EventHandler(this.btnthemnhanvien_Click);
            // 
            // btnxoanhanvien
            // 
            this.btnxoanhanvien.BackColor = System.Drawing.Color.GreenYellow;
            this.btnxoanhanvien.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoanhanvien.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnxoanhanvien.Location = new System.Drawing.Point(238, 587);
            this.btnxoanhanvien.Name = "btnxoanhanvien";
            this.btnxoanhanvien.Size = new System.Drawing.Size(172, 31);
            this.btnxoanhanvien.TabIndex = 14;
            this.btnxoanhanvien.Text = "Xoá nhân viên";
            this.btnxoanhanvien.UseVisualStyleBackColor = false;
            this.btnxoanhanvien.Click += new System.EventHandler(this.btnxoanhanvien_Click);
            // 
            // btnsua
            // 
            this.btnsua.BackColor = System.Drawing.Color.GreenYellow;
            this.btnsua.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsua.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsua.Location = new System.Drawing.Point(448, 587);
            this.btnsua.Name = "btnsua";
            this.btnsua.Size = new System.Drawing.Size(137, 31);
            this.btnsua.TabIndex = 17;
            this.btnsua.Text = "Sửa";
            this.btnsua.UseVisualStyleBackColor = false;
            this.btnsua.Click += new System.EventHandler(this.btnsua_Click);
            // 
            // btnxoa
            // 
            this.btnxoa.BackColor = System.Drawing.Color.GreenYellow;
            this.btnxoa.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoa.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnxoa.Location = new System.Drawing.Point(615, 587);
            this.btnxoa.Name = "btnxoa";
            this.btnxoa.Size = new System.Drawing.Size(137, 31);
            this.btnxoa.TabIndex = 18;
            this.btnxoa.Text = "Tìm kiếm";
            this.btnxoa.UseVisualStyleBackColor = false;
            this.btnxoa.Click += new System.EventHandler(this.btntimkiem_Click);
            // 
            // txttimkiem
            // 
            this.txttimkiem.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txttimkiem.Location = new System.Drawing.Point(779, 590);
            this.txttimkiem.Name = "txttimkiem";
            this.txttimkiem.Size = new System.Drawing.Size(279, 26);
            this.txttimkiem.TabIndex = 19;
            // 
            // btnxuatfile
            // 
            this.btnxuatfile.BackColor = System.Drawing.Color.GreenYellow;
            this.btnxuatfile.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxuatfile.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnxuatfile.Location = new System.Drawing.Point(921, 85);
            this.btnxuatfile.Name = "btnxuatfile";
            this.btnxuatfile.Size = new System.Drawing.Size(137, 31);
            this.btnxuatfile.TabIndex = 21;
            this.btnxuatfile.Text = "Xuất file";
            this.btnxuatfile.UseVisualStyleBackColor = false;
            this.btnxuatfile.Click += new System.EventHandler(this.btnxuatfile_Click);
            // 
            // txttennhanvien
            // 
            this.txttennhanvien.Location = new System.Drawing.Point(18, 525);
            this.txttennhanvien.Name = "txttennhanvien";
            this.txttennhanvien.Size = new System.Drawing.Size(206, 20);
            this.txttennhanvien.TabIndex = 22;
            // 
            // txtsodienthoai
            // 
            this.txtsodienthoai.Location = new System.Drawing.Point(247, 525);
            this.txtsodienthoai.Name = "txtsodienthoai";
            this.txtsodienthoai.Size = new System.Drawing.Size(210, 20);
            this.txtsodienthoai.TabIndex = 23;
            // 
            // txtchucvu
            // 
            this.txtchucvu.Location = new System.Drawing.Point(484, 525);
            this.txtchucvu.Name = "txtchucvu";
            this.txtchucvu.Size = new System.Drawing.Size(144, 20);
            this.txtchucvu.TabIndex = 24;
            // 
            // txtluongcoban
            // 
            this.txtluongcoban.Location = new System.Drawing.Point(663, 525);
            this.txtluongcoban.Name = "txtluongcoban";
            this.txtluongcoban.Size = new System.Drawing.Size(200, 20);
            this.txtluongcoban.TabIndex = 25;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(74, 548);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 19);
            this.label2.TabIndex = 26;
            this.label2.Text = "Tên nhân viên";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(719, 548);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 19);
            this.label4.TabIndex = 28;
            this.label4.Text = "Lương cơ bản";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(505, 548);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 19);
            this.label5.TabIndex = 29;
            this.label5.Text = "Chức vụ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(308, 548);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 19);
            this.label6.TabIndex = 30;
            this.label6.Text = "Số điện thoại";
            // 
            // QuanLyNhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtluongcoban);
            this.Controls.Add(this.txtchucvu);
            this.Controls.Add(this.txtsodienthoai);
            this.Controls.Add(this.txttennhanvien);
            this.Controls.Add(this.btnxuatfile);
            this.Controls.Add(this.txttimkiem);
            this.Controls.Add(this.btnxoa);
            this.Controls.Add(this.btnsua);
            this.Controls.Add(this.btnxoanhanvien);
            this.Controls.Add(this.btnthemnhanvien);
            this.Controls.Add(this.cbnhanvienspa);
            this.Controls.Add(this.cbnhanvientiepnhan);
            this.Controls.Add(this.dgvquanlynhanvien);
            this.Controls.Add(this.label1);
            this.Name = "QuanLyNhanVien";
            this.Size = new System.Drawing.Size(1086, 646);
            this.Load += new System.EventHandler(this.QuanLyNhanVien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlynhanvien)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvquanlynhanvien;
        private System.Windows.Forms.CheckBox cbnhanvientiepnhan;
        private System.Windows.Forms.CheckBox cbnhanvienspa;
        private System.Windows.Forms.Button btnthemnhanvien;
        private System.Windows.Forms.Button btnxoanhanvien;
        private System.Windows.Forms.Button btnsua;
        private System.Windows.Forms.Button btnxoa;
        private System.Windows.Forms.TextBox txttimkiem;
        private System.Windows.Forms.Button btnxuatfile;
        private System.Windows.Forms.TextBox txttennhanvien;
        private System.Windows.Forms.TextBox txtsodienthoai;
        private System.Windows.Forms.TextBox txtchucvu;
        private System.Windows.Forms.TextBox txtluongcoban;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
    }
}

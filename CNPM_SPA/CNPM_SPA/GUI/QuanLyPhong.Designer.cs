namespace CNPM_SPA
{
    partial class QuanLyPhong
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
            this.dgvquanlyphong = new System.Windows.Forms.DataGridView();
            this.btnthemphong = new System.Windows.Forms.Button();
            this.btnxoaphong = new System.Windows.Forms.Button();
            this.cbdanghoatdong = new System.Windows.Forms.CheckBox();
            this.cbphongtrong = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txttenphong = new System.Windows.Forms.TextBox();
            this.txttrangthai = new System.Windows.Forms.TextBox();
            this.btnsuaphong = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlyphong)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvquanlyphong
            // 
            this.dgvquanlyphong.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvquanlyphong.Location = new System.Drawing.Point(18, 142);
            this.dgvquanlyphong.Name = "dgvquanlyphong";
            this.dgvquanlyphong.Size = new System.Drawing.Size(1049, 417);
            this.dgvquanlyphong.TabIndex = 5;
            this.dgvquanlyphong.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvquanlyphong_CellClick);
            // 
            // btnthemphong
            // 
            this.btnthemphong.BackColor = System.Drawing.Color.GreenYellow;
            this.btnthemphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnthemphong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnthemphong.Location = new System.Drawing.Point(57, 589);
            this.btnthemphong.Name = "btnthemphong";
            this.btnthemphong.Size = new System.Drawing.Size(137, 31);
            this.btnthemphong.TabIndex = 6;
            this.btnthemphong.Text = "Thêm Phòng";
            this.btnthemphong.UseVisualStyleBackColor = false;
            this.btnthemphong.Click += new System.EventHandler(this.btnthemphong_Click);
            // 
            // btnxoaphong
            // 
            this.btnxoaphong.BackColor = System.Drawing.Color.GreenYellow;
            this.btnxoaphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnxoaphong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnxoaphong.Location = new System.Drawing.Point(255, 589);
            this.btnxoaphong.Name = "btnxoaphong";
            this.btnxoaphong.Size = new System.Drawing.Size(137, 31);
            this.btnxoaphong.TabIndex = 8;
            this.btnxoaphong.Text = "Xoá phòng";
            this.btnxoaphong.UseVisualStyleBackColor = false;
            this.btnxoaphong.Click += new System.EventHandler(this.btnxoaphong_Click);
            // 
            // cbdanghoatdong
            // 
            this.cbdanghoatdong.AutoSize = true;
            this.cbdanghoatdong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbdanghoatdong.Location = new System.Drawing.Point(18, 91);
            this.cbdanghoatdong.Name = "cbdanghoatdong";
            this.cbdanghoatdong.Size = new System.Drawing.Size(124, 23);
            this.cbdanghoatdong.TabIndex = 9;
            this.cbdanghoatdong.Text = "Đang hoạt động";
            this.cbdanghoatdong.UseVisualStyleBackColor = true;
            this.cbdanghoatdong.CheckedChanged += new System.EventHandler(this.cbdanghoatdong_CheckedChanged);
            // 
            // cbphongtrong
            // 
            this.cbphongtrong.AutoSize = true;
            this.cbphongtrong.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbphongtrong.Location = new System.Drawing.Point(188, 91);
            this.cbphongtrong.Name = "cbphongtrong";
            this.cbphongtrong.Size = new System.Drawing.Size(101, 23);
            this.cbphongtrong.TabIndex = 10;
            this.cbphongtrong.Text = "Phòng trống";
            this.cbphongtrong.UseVisualStyleBackColor = true;
            this.cbphongtrong.CheckedChanged += new System.EventHandler(this.cbphongtrong_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(386, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 31);
            this.label1.TabIndex = 11;
            this.label1.Text = "QUẢN LÝ PHÒNG";
            // 
            // txttenphong
            // 
            this.txttenphong.Location = new System.Drawing.Point(657, 596);
            this.txttenphong.Name = "txttenphong";
            this.txttenphong.Size = new System.Drawing.Size(186, 20);
            this.txttenphong.TabIndex = 12;
            // 
            // txttrangthai
            // 
            this.txttrangthai.Location = new System.Drawing.Point(871, 596);
            this.txttrangthai.Name = "txttrangthai";
            this.txttrangthai.Size = new System.Drawing.Size(186, 20);
            this.txttrangthai.TabIndex = 14;
            // 
            // btnsuaphong
            // 
            this.btnsuaphong.BackColor = System.Drawing.Color.GreenYellow;
            this.btnsuaphong.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsuaphong.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnsuaphong.Location = new System.Drawing.Point(451, 589);
            this.btnsuaphong.Name = "btnsuaphong";
            this.btnsuaphong.Size = new System.Drawing.Size(137, 31);
            this.btnsuaphong.TabIndex = 15;
            this.btnsuaphong.Text = "Sửa phòng";
            this.btnsuaphong.UseVisualStyleBackColor = false;
            this.btnsuaphong.Click += new System.EventHandler(this.btnsuaphong_Click);
            // 
            // QuanLyPhong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.btnsuaphong);
            this.Controls.Add(this.txttrangthai);
            this.Controls.Add(this.txttenphong);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbphongtrong);
            this.Controls.Add(this.cbdanghoatdong);
            this.Controls.Add(this.btnxoaphong);
            this.Controls.Add(this.btnthemphong);
            this.Controls.Add(this.dgvquanlyphong);
            this.Name = "QuanLyPhong";
            this.Size = new System.Drawing.Size(1086, 646);
            this.Load += new System.EventHandler(this.QuanLyPhong_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.dgvquanlyphong)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvquanlyphong;
        private System.Windows.Forms.Button btnthemphong;
        private System.Windows.Forms.Button btnxoaphong;
        private System.Windows.Forms.CheckBox cbdanghoatdong;
        private System.Windows.Forms.CheckBox cbphongtrong;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txttenphong;
        private System.Windows.Forms.TextBox txttrangthai;
        private System.Windows.Forms.Button btnsuaphong;
    }
}

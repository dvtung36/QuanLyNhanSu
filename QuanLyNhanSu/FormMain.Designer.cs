namespace QuanLyNhanSu
{
    partial class FormMain
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnQLPB = new System.Windows.Forms.Button();
            this.btnQLDA = new System.Windows.Forms.Button();
            this.btnQLThanNhan = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnQLNhanVien = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnQLPB
            // 
            this.btnQLPB.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLPB.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnQLPB.Location = new System.Drawing.Point(442, 186);
            this.btnQLPB.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLPB.Name = "btnQLPB";
            this.btnQLPB.Size = new System.Drawing.Size(233, 106);
            this.btnQLPB.TabIndex = 17;
            this.btnQLPB.Text = "Quản Lý Phòng Ban";
            this.btnQLPB.UseVisualStyleBackColor = true;
            this.btnQLPB.Click += new System.EventHandler(this.btnQLPB_Click);
            // 
            // btnQLDA
            // 
            this.btnQLDA.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLDA.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnQLDA.Location = new System.Drawing.Point(442, 407);
            this.btnQLDA.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLDA.Name = "btnQLDA";
            this.btnQLDA.Size = new System.Drawing.Size(233, 106);
            this.btnQLDA.TabIndex = 16;
            this.btnQLDA.Text = "Quản Lý Dự Án";
            this.btnQLDA.UseVisualStyleBackColor = true;
            this.btnQLDA.Click += new System.EventHandler(this.btnQLDA_Click);
            // 
            // btnQLThanNhan
            // 
            this.btnQLThanNhan.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLThanNhan.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnQLThanNhan.Location = new System.Drawing.Point(87, 423);
            this.btnQLThanNhan.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLThanNhan.Name = "btnQLThanNhan";
            this.btnQLThanNhan.Size = new System.Drawing.Size(233, 96);
            this.btnQLThanNhan.TabIndex = 14;
            this.btnQLThanNhan.Text = "Quản Lý Thân Nhân";
            this.btnQLThanNhan.UseVisualStyleBackColor = true;
            this.btnQLThanNhan.Click += new System.EventHandler(this.btnQLThanNhan_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnThoat.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnThoat.Location = new System.Drawing.Point(761, 186);
            this.btnThoat.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(234, 106);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 25.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(376, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(361, 49);
            this.label1.TabIndex = 9;
            this.label1.Text = "Quản Lý Nhân Sự";
            // 
            // btnQLNhanVien
            // 
            this.btnQLNhanVien.Font = new System.Drawing.Font("Times New Roman", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnQLNhanVien.ForeColor = System.Drawing.Color.SaddleBrown;
            this.btnQLNhanVien.Location = new System.Drawing.Point(87, 186);
            this.btnQLNhanVien.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnQLNhanVien.Name = "btnQLNhanVien";
            this.btnQLNhanVien.Size = new System.Drawing.Size(233, 106);
            this.btnQLNhanVien.TabIndex = 10;
            this.btnQLNhanVien.Text = "QL Nhân Viên";
            this.btnQLNhanVien.UseVisualStyleBackColor = true;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.ClientSize = new System.Drawing.Size(1127, 600);
            this.Controls.Add(this.btnQLPB);
            this.Controls.Add(this.btnQLDA);
            this.Controls.Add(this.btnQLThanNhan);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.btnQLNhanVien);
            this.Controls.Add(this.label1);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FormMain";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnQLPB;
        private System.Windows.Forms.Button btnQLDA;
        private System.Windows.Forms.Button btnQLThanNhan;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnQLNhanVien;
    }
}


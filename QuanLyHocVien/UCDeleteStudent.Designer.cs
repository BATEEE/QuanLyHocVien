namespace QuanLyHocVien
{
    partial class UCDeleteStudent
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
            this.pnFind = new System.Windows.Forms.Panel();
            this.btnXoa = new System.Windows.Forms.Button();
            this.txtMaSoFind = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.title = new System.Windows.Forms.Label();
            this.pnFind.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnFind
            // 
            this.pnFind.Controls.Add(this.btnXoa);
            this.pnFind.Controls.Add(this.txtMaSoFind);
            this.pnFind.Controls.Add(this.label6);
            this.pnFind.Location = new System.Drawing.Point(0, 78);
            this.pnFind.Name = "pnFind";
            this.pnFind.Size = new System.Drawing.Size(502, 41);
            this.pnFind.TabIndex = 24;
            // 
            // btnXoa
            // 
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Location = new System.Drawing.Point(409, 3);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(81, 29);
            this.btnXoa.TabIndex = 2;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // txtMaSoFind
            // 
            this.txtMaSoFind.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaSoFind.Location = new System.Drawing.Point(158, 4);
            this.txtMaSoFind.Name = "txtMaSoFind";
            this.txtMaSoFind.Size = new System.Drawing.Size(236, 26);
            this.txtMaSoFind.TabIndex = 1;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(13, 10);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(139, 20);
            this.label6.TabIndex = 0;
            this.label6.Text = "Nhập mã học viên:";
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.IndianRed;
            this.title.Location = new System.Drawing.Point(12, 22);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(196, 29);
            this.title.TabIndex = 25;
            this.title.Text = "XÓA HỌC VIÊN";
            // 
            // UCDeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.title);
            this.Controls.Add(this.pnFind);
            this.Name = "UCDeleteStudent";
            this.Size = new System.Drawing.Size(502, 368);
            this.Load += new System.EventHandler(this.UCDeleteStudent_Load);
            this.pnFind.ResumeLayout(false);
            this.pnFind.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnFind;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.TextBox txtMaSoFind;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label title;
    }
}

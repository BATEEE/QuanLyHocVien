namespace QuanLyHocVien
{
    partial class UCIsHocBong
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
            this.title = new System.Windows.Forms.Label();
            this.dataIsHocBongSinhVien = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataIsHocBongSinhVien)).BeginInit();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.IndianRed;
            this.title.Location = new System.Drawing.Point(12, 12);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(477, 62);
            this.title.TabIndex = 27;
            this.title.Text = "DANH SÁCH CÁC HỌC VIÊN ĐƯỢC HỌC BỔNG";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // dataIsHocBongSinhVien
            // 
            this.dataIsHocBongSinhVien.BackgroundColor = System.Drawing.Color.White;
            this.dataIsHocBongSinhVien.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataIsHocBongSinhVien.Location = new System.Drawing.Point(0, 77);
            this.dataIsHocBongSinhVien.Name = "dataIsHocBongSinhVien";
            this.dataIsHocBongSinhVien.Size = new System.Drawing.Size(502, 291);
            this.dataIsHocBongSinhVien.TabIndex = 28;
            // 
            // UCIsHocBong
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.dataIsHocBongSinhVien);
            this.Controls.Add(this.title);
            this.Name = "UCIsHocBong";
            this.Size = new System.Drawing.Size(502, 368);
            ((System.ComponentModel.ISupportInitialize)(this.dataIsHocBongSinhVien)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.DataGridView dataIsHocBongSinhVien;
    }
}

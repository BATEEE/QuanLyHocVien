namespace QuanLyHocVien
{
    partial class UCShowListStudents
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
            this.flpStudents = new System.Windows.Forms.FlowLayoutPanel();
            this.SuspendLayout();
            // 
            // title
            // 
            this.title.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.Color.IndianRed;
            this.title.Location = new System.Drawing.Point(11, 10);
            this.title.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(477, 34);
            this.title.TabIndex = 28;
            this.title.Text = "DANH SÁCH CÁC HỌC VIÊN";
            this.title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // flpStudents
            // 
            this.flpStudents.AutoScroll = true;
            this.flpStudents.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.flpStudents.Location = new System.Drawing.Point(16, 47);
            this.flpStudents.Name = "flpStudents";
            this.flpStudents.Size = new System.Drawing.Size(472, 302);
            this.flpStudents.TabIndex = 29;
            // 
            // UCShowListStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LemonChiffon;
            this.Controls.Add(this.flpStudents);
            this.Controls.Add(this.title);
            this.Name = "UCShowListStudents";
            this.Size = new System.Drawing.Size(502, 368);
            this.Load += new System.EventHandler(this.UCShowListStudents_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label title;
        private System.Windows.Forms.FlowLayoutPanel flpStudents;
    }
}

namespace QuanLyHocVien
{
    partial class fQuanLyHocVien
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
            this.pnHeader = new System.Windows.Forms.Panel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbExit = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pnMenu = new System.Windows.Forms.Panel();
            this.btnListHocVien = new System.Windows.Forms.Button();
            this.btnIsHocBongFunc = new System.Windows.Forms.Button();
            this.btnSearchStudentFunc = new System.Windows.Forms.Button();
            this.btnDeleteStudentFunc = new System.Windows.Forms.Button();
            this.btnUpdateStudentFunc = new System.Windows.Forms.Button();
            this.btnAddStudentFunc = new System.Windows.Forms.Button();
            this.pnContent = new System.Windows.Forms.Panel();
            this.pnHeader.SuspendLayout();
            this.pnMenu.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnHeader
            // 
            this.pnHeader.BackColor = System.Drawing.Color.LightGray;
            this.pnHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnHeader.Controls.Add(this.panel1);
            this.pnHeader.Controls.Add(this.lbExit);
            this.pnHeader.Controls.Add(this.lbUsername);
            this.pnHeader.Controls.Add(this.label1);
            this.pnHeader.ForeColor = System.Drawing.Color.White;
            this.pnHeader.Location = new System.Drawing.Point(0, 0);
            this.pnHeader.Margin = new System.Windows.Forms.Padding(2);
            this.pnHeader.Name = "pnHeader";
            this.pnHeader.Size = new System.Drawing.Size(725, 47);
            this.pnHeader.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Location = new System.Drawing.Point(2, 47);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(234, 387);
            this.panel1.TabIndex = 1;
            // 
            // lbExit
            // 
            this.lbExit.AutoSize = true;
            this.lbExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Italic | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbExit.ForeColor = System.Drawing.Color.Red;
            this.lbExit.Location = new System.Drawing.Point(676, 16);
            this.lbExit.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbExit.Name = "lbExit";
            this.lbExit.Size = new System.Drawing.Size(38, 15);
            this.lbExit.TabIndex = 2;
            this.lbExit.Text = "Thoát";
            this.lbExit.Click += new System.EventHandler(this.lbExit_Click);
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsername.ForeColor = System.Drawing.Color.Black;
            this.lbUsername.Location = new System.Drawing.Point(58, 16);
            this.lbUsername.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(17, 17);
            this.lbUsername.TabIndex = 1;
            this.lbUsername.Text = "0";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.125F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Tên:";
            // 
            // pnMenu
            // 
            this.pnMenu.BackColor = System.Drawing.Color.PeachPuff;
            this.pnMenu.Controls.Add(this.btnListHocVien);
            this.pnMenu.Controls.Add(this.btnIsHocBongFunc);
            this.pnMenu.Controls.Add(this.btnSearchStudentFunc);
            this.pnMenu.Controls.Add(this.btnDeleteStudentFunc);
            this.pnMenu.Controls.Add(this.btnUpdateStudentFunc);
            this.pnMenu.Controls.Add(this.btnAddStudentFunc);
            this.pnMenu.Location = new System.Drawing.Point(0, 45);
            this.pnMenu.Margin = new System.Windows.Forms.Padding(2);
            this.pnMenu.Name = "pnMenu";
            this.pnMenu.Size = new System.Drawing.Size(224, 390);
            this.pnMenu.TabIndex = 1;
            // 
            // btnListHocVien
            // 
            this.btnListHocVien.BackColor = System.Drawing.Color.PeachPuff;
            this.btnListHocVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnListHocVien.Location = new System.Drawing.Point(-2, 211);
            this.btnListHocVien.Margin = new System.Windows.Forms.Padding(2);
            this.btnListHocVien.Name = "btnListHocVien";
            this.btnListHocVien.Size = new System.Drawing.Size(224, 44);
            this.btnListHocVien.TabIndex = 5;
            this.btnListHocVien.Text = "Danh sách học viên";
            this.btnListHocVien.UseVisualStyleBackColor = false;
            this.btnListHocVien.Click += new System.EventHandler(this.btnListHocVien_Click);
            // 
            // btnIsHocBongFunc
            // 
            this.btnIsHocBongFunc.BackColor = System.Drawing.Color.PeachPuff;
            this.btnIsHocBongFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIsHocBongFunc.Location = new System.Drawing.Point(-2, 168);
            this.btnIsHocBongFunc.Margin = new System.Windows.Forms.Padding(2);
            this.btnIsHocBongFunc.Name = "btnIsHocBongFunc";
            this.btnIsHocBongFunc.Size = new System.Drawing.Size(224, 44);
            this.btnIsHocBongFunc.TabIndex = 4;
            this.btnIsHocBongFunc.Text = "Học viên được học bổng";
            this.btnIsHocBongFunc.UseVisualStyleBackColor = false;
            this.btnIsHocBongFunc.Click += new System.EventHandler(this.btnIsHocBongFunc_Click);
            // 
            // btnSearchStudentFunc
            // 
            this.btnSearchStudentFunc.BackColor = System.Drawing.Color.PeachPuff;
            this.btnSearchStudentFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearchStudentFunc.Location = new System.Drawing.Point(0, 125);
            this.btnSearchStudentFunc.Margin = new System.Windows.Forms.Padding(2);
            this.btnSearchStudentFunc.Name = "btnSearchStudentFunc";
            this.btnSearchStudentFunc.Size = new System.Drawing.Size(224, 44);
            this.btnSearchStudentFunc.TabIndex = 3;
            this.btnSearchStudentFunc.Text = "Tìm kiếm học viên";
            this.btnSearchStudentFunc.UseVisualStyleBackColor = false;
            this.btnSearchStudentFunc.Click += new System.EventHandler(this.btnSearchStudentFunc_Click);
            // 
            // btnDeleteStudentFunc
            // 
            this.btnDeleteStudentFunc.BackColor = System.Drawing.Color.PeachPuff;
            this.btnDeleteStudentFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteStudentFunc.Location = new System.Drawing.Point(0, 83);
            this.btnDeleteStudentFunc.Margin = new System.Windows.Forms.Padding(2);
            this.btnDeleteStudentFunc.Name = "btnDeleteStudentFunc";
            this.btnDeleteStudentFunc.Size = new System.Drawing.Size(224, 44);
            this.btnDeleteStudentFunc.TabIndex = 2;
            this.btnDeleteStudentFunc.Text = "Xóa học viên";
            this.btnDeleteStudentFunc.UseVisualStyleBackColor = false;
            this.btnDeleteStudentFunc.Click += new System.EventHandler(this.btnDeleteStudentFunc_Click);
            // 
            // btnUpdateStudentFunc
            // 
            this.btnUpdateStudentFunc.BackColor = System.Drawing.Color.PeachPuff;
            this.btnUpdateStudentFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdateStudentFunc.Location = new System.Drawing.Point(0, 42);
            this.btnUpdateStudentFunc.Margin = new System.Windows.Forms.Padding(2);
            this.btnUpdateStudentFunc.Name = "btnUpdateStudentFunc";
            this.btnUpdateStudentFunc.Size = new System.Drawing.Size(224, 44);
            this.btnUpdateStudentFunc.TabIndex = 1;
            this.btnUpdateStudentFunc.Text = "Sửa học viên";
            this.btnUpdateStudentFunc.UseVisualStyleBackColor = false;
            this.btnUpdateStudentFunc.Click += new System.EventHandler(this.btnUpdateStudentFunc_Click);
            // 
            // btnAddStudentFunc
            // 
            this.btnAddStudentFunc.BackColor = System.Drawing.Color.PeachPuff;
            this.btnAddStudentFunc.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddStudentFunc.Location = new System.Drawing.Point(0, 0);
            this.btnAddStudentFunc.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddStudentFunc.Name = "btnAddStudentFunc";
            this.btnAddStudentFunc.Size = new System.Drawing.Size(224, 44);
            this.btnAddStudentFunc.TabIndex = 0;
            this.btnAddStudentFunc.Text = "Thêm học viên";
            this.btnAddStudentFunc.UseVisualStyleBackColor = false;
            this.btnAddStudentFunc.Click += new System.EventHandler(this.btnAddStudentFunc_Click);
            // 
            // pnContent
            // 
            this.pnContent.BackColor = System.Drawing.Color.LemonChiffon;
            this.pnContent.Location = new System.Drawing.Point(223, 45);
            this.pnContent.Margin = new System.Windows.Forms.Padding(2);
            this.pnContent.Name = "pnContent";
            this.pnContent.Size = new System.Drawing.Size(502, 368);
            this.pnContent.TabIndex = 2;
            // 
            // fQuanLyHocVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(726, 413);
            this.Controls.Add(this.pnContent);
            this.Controls.Add(this.pnMenu);
            this.Controls.Add(this.pnHeader);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "fQuanLyHocVien";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QuanLyHocVien";
            this.Load += new System.EventHandler(this.fQuanLyHocVien_Load);
            this.pnHeader.ResumeLayout(false);
            this.pnHeader.PerformLayout();
            this.pnMenu.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnHeader;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbExit;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel pnMenu;
        private System.Windows.Forms.Button btnAddStudentFunc;
        private System.Windows.Forms.Panel pnContent;
        private System.Windows.Forms.Button btnSearchStudentFunc;
        private System.Windows.Forms.Button btnDeleteStudentFunc;
        private System.Windows.Forms.Button btnUpdateStudentFunc;
        private System.Windows.Forms.Button btnListHocVien;
        private System.Windows.Forms.Button btnIsHocBongFunc;
    }
}
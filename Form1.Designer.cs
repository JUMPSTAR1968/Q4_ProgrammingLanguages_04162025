namespace StudentDetailsApp
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            txtStudentId = new TextBox();
            btnSearch = new Button();
            lblName = new Label();
            lblDob = new Label();
            lblAge = new Label();
            label1 = new Label();
            SuspendLayout();
            // 
            // txtStudentId
            // 
            txtStudentId.Location = new Point(160, 30);
            txtStudentId.Name = "txtStudentId";
            txtStudentId.Size = new Size(150, 23);
            txtStudentId.TabIndex = 0;
            txtStudentId.TextChanged += txtStudentId_TextChanged;
            // 
            // btnSearch
            // 
            btnSearch.Location = new Point(320, 29);
            btnSearch.Name = "btnSearch";
            btnSearch.Size = new Size(75, 25);
            btnSearch.TabIndex = 1;
            btnSearch.Text = "Search";
            btnSearch.UseVisualStyleBackColor = true;
            btnSearch.Click += btnSearch_Click;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.Location = new Point(30, 80);
            lblName.Name = "lblName";
            lblName.Size = new Size(42, 15);
            lblName.TabIndex = 2;
            lblName.Text = "Name:";
            // 
            // lblDob
            // 
            lblDob.AutoSize = true;
            lblDob.Location = new Point(30, 110);
            lblDob.Name = "lblDob";
            lblDob.Size = new Size(76, 15);
            lblDob.TabIndex = 3;
            lblDob.Text = "Date of Birth:";
            // 
            // lblAge
            // 
            lblAge.AutoSize = true;
            lblAge.Location = new Point(30, 140);
            lblAge.Name = "lblAge";
            lblAge.Size = new Size(31, 15);
            lblAge.TabIndex = 4;
            lblAge.Text = "Age:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(121, 15);
            label1.TabIndex = 5;
            label1.Text = "Enter Student ID here:";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(430, 200);
            Controls.Add(label1);
            Controls.Add(lblAge);
            Controls.Add(lblDob);
            Controls.Add(lblName);
            Controls.Add(btnSearch);
            Controls.Add(txtStudentId);
            Name = "Form1";
            Text = "Student Information Viewer";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox txtStudentId;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblDob;
        private System.Windows.Forms.Label lblAge;
        private System.Windows.Forms.Label label1;
    }
}

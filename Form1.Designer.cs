namespace Wk3Assignment3._3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblStudentList = new Label();
            dgStudentList = new DataGridView();
            btnAddToList = new Button();
            lblFirstName = new Label();
            label1 = new Label();
            lblAddress = new Label();
            lblGrade = new Label();
            lblMonthOfAdm = new Label();
            txtFirst = new TextBox();
            txtLast = new TextBox();
            txtAddress = new TextBox();
            cbGrade = new ComboBox();
            cbMonthOfAdm = new ComboBox();
            btnDelete = new Button();
            ((System.ComponentModel.ISupportInitialize)dgStudentList).BeginInit();
            SuspendLayout();
            // 
            // lblStudentList
            // 
            lblStudentList.AutoSize = true;
            lblStudentList.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblStudentList.Location = new Point(53, 41);
            lblStudentList.Name = "lblStudentList";
            lblStudentList.Size = new Size(148, 32);
            lblStudentList.TabIndex = 0;
            lblStudentList.Text = "Student List";
            // 
            // dgStudentList
            // 
            dgStudentList.BackgroundColor = SystemColors.ControlLight;
            dgStudentList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgStudentList.Location = new Point(53, 76);
            dgStudentList.Name = "dgStudentList";
            dgStudentList.Size = new Size(684, 128);
            dgStudentList.TabIndex = 1;
            // 
            // btnAddToList
            // 
            btnAddToList.BackColor = SystemColors.GradientActiveCaption;
            btnAddToList.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddToList.Location = new Point(53, 210);
            btnAddToList.Name = "btnAddToList";
            btnAddToList.Size = new Size(256, 43);
            btnAddToList.TabIndex = 2;
            btnAddToList.Text = "^^Add To List^^";
            btnAddToList.UseVisualStyleBackColor = false;
            btnAddToList.Click += btnAddToList_Click;
            // 
            // lblFirstName
            // 
            lblFirstName.AutoSize = true;
            lblFirstName.Location = new Point(53, 280);
            lblFirstName.Name = "lblFirstName";
            lblFirstName.Size = new Size(67, 15);
            lblFirstName.TabIndex = 3;
            lblFirstName.Text = "First Name:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(274, 280);
            label1.Name = "label1";
            label1.Size = new Size(66, 15);
            label1.TabIndex = 4;
            label1.Text = "Last Name:";
            // 
            // lblAddress
            // 
            lblAddress.AutoSize = true;
            lblAddress.Location = new Point(513, 280);
            lblAddress.Name = "lblAddress";
            lblAddress.Size = new Size(52, 15);
            lblAddress.TabIndex = 5;
            lblAddress.Text = "Address:";
            // 
            // lblGrade
            // 
            lblGrade.AutoSize = true;
            lblGrade.Location = new Point(53, 360);
            lblGrade.Name = "lblGrade";
            lblGrade.Size = new Size(41, 15);
            lblGrade.TabIndex = 6;
            lblGrade.Text = "Grade:";
            // 
            // lblMonthOfAdm
            // 
            lblMonthOfAdm.AutoSize = true;
            lblMonthOfAdm.Location = new Point(274, 360);
            lblMonthOfAdm.Name = "lblMonthOfAdm";
            lblMonthOfAdm.Size = new Size(116, 15);
            lblMonthOfAdm.TabIndex = 7;
            lblMonthOfAdm.Text = "Month of Admission";
            // 
            // txtFirst
            // 
            txtFirst.BackColor = SystemColors.Info;
            txtFirst.Location = new Point(53, 297);
            txtFirst.Name = "txtFirst";
            txtFirst.Size = new Size(205, 23);
            txtFirst.TabIndex = 8;
            // 
            // txtLast
            // 
            txtLast.BackColor = SystemColors.Info;
            txtLast.Location = new Point(274, 298);
            txtLast.Name = "txtLast";
            txtLast.Size = new Size(205, 23);
            txtLast.TabIndex = 9;
            // 
            // txtAddress
            // 
            txtAddress.BackColor = SystemColors.Info;
            txtAddress.Location = new Point(513, 298);
            txtAddress.Multiline = true;
            txtAddress.Name = "txtAddress";
            txtAddress.Size = new Size(224, 140);
            txtAddress.TabIndex = 10;
            // 
            // cbGrade
            // 
            cbGrade.FormattingEnabled = true;
            cbGrade.Location = new Point(100, 357);
            cbGrade.Name = "cbGrade";
            cbGrade.Size = new Size(66, 23);
            cbGrade.TabIndex = 11;
            // 
            // cbMonthOfAdm
            // 
            cbMonthOfAdm.FormattingEnabled = true;
            cbMonthOfAdm.Location = new Point(396, 357);
            cbMonthOfAdm.Name = "cbMonthOfAdm";
            cbMonthOfAdm.Size = new Size(66, 23);
            cbMonthOfAdm.TabIndex = 12;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.IndianRed;
            btnDelete.FlatStyle = FlatStyle.Flat;
            btnDelete.Font = new Font("Segoe UI Semibold", 11.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnDelete.Location = new Point(513, 210);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(224, 43);
            btnDelete.TabIndex = 13;
            btnDelete.Text = "Delete Student";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnDelete);
            Controls.Add(cbMonthOfAdm);
            Controls.Add(cbGrade);
            Controls.Add(txtAddress);
            Controls.Add(txtLast);
            Controls.Add(txtFirst);
            Controls.Add(lblMonthOfAdm);
            Controls.Add(lblGrade);
            Controls.Add(lblAddress);
            Controls.Add(label1);
            Controls.Add(lblFirstName);
            Controls.Add(btnAddToList);
            Controls.Add(dgStudentList);
            Controls.Add(lblStudentList);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgStudentList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblStudentList;
        private DataGridView dgStudentList;
        private Button btnAddToList;
        private Label lblFirstName;
        private Label label1;
        private Label lblAddress;
        private Label lblGrade;
        private Label lblMonthOfAdm;
        private TextBox txtFirst;
        private TextBox txtLast;
        private TextBox txtAddress;
        private ComboBox cbGrade;
        private ComboBox cbMonthOfAdm;
        private Button btnDelete;
    }
}

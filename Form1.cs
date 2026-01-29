namespace Wk3Assignment3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dgStudentList.DataSource = Data.Students;
            cbGrade.DataSource = Enum.GetValues(typeof(Grade));
            cbMonthOfAdm.DataSource = Enum.GetValues(typeof(MonthOfAdmission));
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            Student student = (Student)dgStudentList.CurrentRow.DataBoundItem;
            var result = MessageBox.Show($"Are you sure you want to delete {student.FirstName} {student.LastName}?", "Confirm", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Data.Students.RemoveAt(dgStudentList.CurrentRow.Index);
                dgStudentList.DataSource = null;
                dgStudentList.DataSource = Data.Students;
            }
        }

        private void btnAddToList_Click(object sender, EventArgs e)
        {
            if (txtFirst.Text == string.Empty || txtLast.Text == string.Empty || txtAddress.Text == string.Empty || cbGrade.Text == string.Empty || cbMonthOfAdm.Text == string.Empty)
            {
                MessageBox.Show("Cannot add empty fields");
            }
            else
            {
                Student newStudent = new Student();
                newStudent.FirstName = txtFirst.Text;
                newStudent.LastName = txtLast.Text;
                newStudent.Address = txtAddress.Text;
                newStudent.Grade = (Grade)(cbGrade.SelectedIndex + 1);
                newStudent.AdmissionMonth = (MonthOfAdmission)(cbMonthOfAdm.SelectedIndex + 1);
                Data.Students.Add(newStudent);
                MessageBox.Show($"Added {newStudent.FirstName} {newStudent.LastName} to list.");
                EmptyAllFields();
            }
            dgStudentList.DataSource = null;
            dgStudentList.DataSource = Data.Students;

        }

        public void EmptyAllFields()
        { 
            txtFirst.Text = string.Empty;
            txtLast.Text = string.Empty;
            txtAddress.Text = string.Empty;
            cbGrade.SelectedIndex = 0;
            cbMonthOfAdm.SelectedIndex = 0;
        }
    }
}

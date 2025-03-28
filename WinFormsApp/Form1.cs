using System.Data;
using System.Data.SqlClient;

namespace WinFormsApp;

public partial class Form1 : Form

{
    public Form1()
    {
        InitializeComponent();
        SetupEventHandlers();
    }
    private void SetupEventHandlers()
    {
        // Connect button click events to their handlers
        btnInsert.Click += BtnInsert_Click;
        btnUpdate.Click += BtnUpdate_Click;
        btnDelete.Click += BtnDelete_Click;
        btnSearch.Click += BtnSearch_Click;
        btnSearchSpecific.Click += BtnSearchSpecific_Click;
    }

    private void BtnInsert_Click(object sender, EventArgs e)
    {
        StudentProps p = new StudentProps();

        StudentBLL bll = new StudentBLL();

        p.ID = txtId.Text;
        p.Name = txtName.Text;
        p.semester = txtSemester.Text;
        p.degree = txtProgram.Text;
        p.department = txtDepartment.Text;
        string msg = bll.Insertstudent(p);
        MessageBox.Show(msg);

    }

    private void BtnUpdate_Click(object sender, EventArgs e)
    {
        StudentProps p = new StudentProps();
        StudentBLL bll = new StudentBLL();

        p.ID = txtId.Text;
        p.Name = txtName.Text;
        p.semester = txtSemester.Text;
        p.degree = txtProgram.Text;
        p.department = txtDepartment.Text;
        string msg = bll.UpdateStudent(p);
        MessageBox.Show(msg);

    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {
        StudentProps p = new StudentProps();
        StudentBLL bll = new StudentBLL();

        p.ID = txtId.Text;
        string msg = bll.DeleteStudent(p);
        MessageBox.Show(msg);

    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {

        StudentBLL bll = new StudentBLL();
        DataTable result = bll.searchallStudent();
        dataGridView1.DataSource = result;

    }

    private void BtnSearchSpecific_Click(object sender, EventArgs e)
    {
        StudentProps p = new StudentProps();
        StudentBLL bll = new StudentBLL();
        p.ID = txtId.Text;
        DataTable dt=bll.searchStudentById(p);
        dataGridView1.DataSource = dt;


    }
}

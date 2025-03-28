namespace WinFormsApp;

public partial class Form1 : Form
{
    public Form1()
    {
        InitializeComponent();
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



    }

    private void BtnUpdate_Click(object sender, EventArgs e)
    {

    }

    private void BtnDelete_Click(object sender, EventArgs e)
    {

    }

    private void BtnSearch_Click(object sender, EventArgs e)
    {

    }

    private void BtnSearchSpecific_Click(object sender, EventArgs e)
    {


    }
}

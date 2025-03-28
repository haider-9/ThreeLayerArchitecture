namespace WinFormsApp;

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
        this.txtId = new TextBox();
        this.txtName = new TextBox();
        this.txtSemester = new TextBox();
        this.txtDepartment = new TextBox();
        this.txtProgram = new TextBox();
        this.lblId = new Label();
        this.lblName = new Label();
        this.lblSemester = new Label();
        this.lblDepartment = new Label();
        this.lblProgram = new Label();
        this.btnInsert = new Button();
        this.btnUpdate = new Button();
        this.btnDelete = new Button();
        this.btnSearch = new Button();
        this.btnSearchSpecific = new Button();
        this.panel1 = new Panel();
        this.dataGridView1 = new DataGridView();
        this.lblTitle = new Label();

        // 
        // panel1
        // 
        this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        this.panel1.Controls.Add(this.lblTitle);
        this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
        this.panel1.Location = new System.Drawing.Point(0, 0);
        this.panel1.Name = "panel1";
        this.panel1.Size = new System.Drawing.Size(800, 60);
        this.panel1.TabIndex = 0;

        // 
        // lblTitle
        // 
        this.lblTitle.AutoSize = true;
        this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 16F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.lblTitle.ForeColor = System.Drawing.Color.White;
        this.lblTitle.Location = new System.Drawing.Point(12, 14);
        this.lblTitle.Name = "lblTitle";
        this.lblTitle.Size = new System.Drawing.Size(219, 30);
        this.lblTitle.TabIndex = 0;
        this.lblTitle.Text = "Student Information";

        // 
        // lblId
        // 
        this.lblId.AutoSize = true;
        this.lblId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblId.Location = new System.Drawing.Point(30, 80);
        this.lblId.Name = "lblId";
        this.lblId.Size = new System.Drawing.Size(23, 19);
        this.lblId.TabIndex = 1;
        this.lblId.Text = "ID:";

        // 
        // txtId
        // 
        this.txtId.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtId.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtId.Location = new System.Drawing.Point(120, 78);
        this.txtId.Name = "txtId";
        this.txtId.Size = new System.Drawing.Size(200, 25);
        this.txtId.TabIndex = 2;

        // 
        // lblName
        // 
        this.lblName.AutoSize = true;
        this.lblName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblName.Location = new System.Drawing.Point(30, 115);
        this.lblName.Name = "lblName";
        this.lblName.Size = new System.Drawing.Size(48, 19);
        this.lblName.TabIndex = 3;
        this.lblName.Text = "Name:";

        // 
        // txtName
        // 
        this.txtName.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtName.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtName.Location = new System.Drawing.Point(120, 113);
        this.txtName.Name = "txtName";
        this.txtName.Size = new System.Drawing.Size(200, 25);
        this.txtName.TabIndex = 4;

        // 
        // lblSemester
        // 
        this.lblSemester.AutoSize = true;
        this.lblSemester.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblSemester.Location = new System.Drawing.Point(30, 150);
        this.lblSemester.Name = "lblSemester";
        this.lblSemester.Size = new System.Drawing.Size(68, 19);
        this.lblSemester.TabIndex = 5;
        this.lblSemester.Text = "Semester:";

        // 
        // txtSemester
        // 
        this.txtSemester.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtSemester.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtSemester.Location = new System.Drawing.Point(120, 148);
        this.txtSemester.Name = "txtSemester";
        this.txtSemester.Size = new System.Drawing.Size(200, 25);
        this.txtSemester.TabIndex = 6;

        // 
        // lblDepartment
        // 
        this.lblDepartment.AutoSize = true;
        this.lblDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblDepartment.Location = new System.Drawing.Point(30, 185);
        this.lblDepartment.Name = "lblDepartment";
        this.lblDepartment.Size = new System.Drawing.Size(85, 19);
        this.lblDepartment.TabIndex = 7;
        this.lblDepartment.Text = "Department:";

        // 
        // txtDepartment
        // 
        this.txtDepartment.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtDepartment.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtDepartment.Location = new System.Drawing.Point(120, 183);
        this.txtDepartment.Name = "txtDepartment";
        this.txtDepartment.Size = new System.Drawing.Size(200, 25);
        this.txtDepartment.TabIndex = 8;

        // 
        // lblProgram
        // 
        this.lblProgram.AutoSize = true;
        this.lblProgram.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.lblProgram.Location = new System.Drawing.Point(30, 220);
        this.lblProgram.Name = "lblProgram";
        this.lblProgram.Size = new System.Drawing.Size(64, 19);
        this.lblProgram.TabIndex = 9;
        this.lblProgram.Text = "Program:";

        // 
        // txtProgram
        // 
        this.txtProgram.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
        this.txtProgram.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
        this.txtProgram.Location = new System.Drawing.Point(120, 218);
        this.txtProgram.Name = "txtProgram";
        this.txtProgram.Size = new System.Drawing.Size(200, 25);
        this.txtProgram.TabIndex = 10;

        // 
        // btnInsert
        // 
        this.btnInsert.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        this.btnInsert.FlatAppearance.BorderSize = 0;
        this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnInsert.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnInsert.ForeColor = System.Drawing.Color.White;
        this.btnInsert.Location = new System.Drawing.Point(30, 260);
        this.btnInsert.Name = "btnInsert";
        this.btnInsert.Size = new System.Drawing.Size(100, 35);
        this.btnInsert.TabIndex = 11;
        this.btnInsert.Text = "Insert";
        this.btnInsert.UseVisualStyleBackColor = false;

        // 
        // btnUpdate
        // 
        this.btnUpdate.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        this.btnUpdate.FlatAppearance.BorderSize = 0;
        this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnUpdate.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnUpdate.ForeColor = System.Drawing.Color.White;
        this.btnUpdate.Location = new System.Drawing.Point(140, 260);
        this.btnUpdate.Name = "btnUpdate";
        this.btnUpdate.Size = new System.Drawing.Size(100, 35);
        this.btnUpdate.TabIndex = 12;
        this.btnUpdate.Text = "Update";
        this.btnUpdate.UseVisualStyleBackColor = false;

        // 
        // btnDelete
        // 
        this.btnDelete.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        this.btnDelete.FlatAppearance.BorderSize = 0;
        this.btnDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnDelete.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnDelete.ForeColor = System.Drawing.Color.White;
        this.btnDelete.Location = new System.Drawing.Point(250, 260);
        this.btnDelete.Name = "btnDelete";
        this.btnDelete.Size = new System.Drawing.Size(100, 35);
        this.btnDelete.TabIndex = 13;
        this.btnDelete.Text = "Delete";
        this.btnDelete.UseVisualStyleBackColor = false;

        // 
        // btnSearch
        // 
        this.btnSearch.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        this.btnSearch.FlatAppearance.BorderSize = 0;
        this.btnSearch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSearch.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSearch.ForeColor = System.Drawing.Color.White;
        this.btnSearch.Location = new System.Drawing.Point(30, 305);
        this.btnSearch.Name = "btnSearch";
        this.btnSearch.Size = new System.Drawing.Size(155, 35);
        this.btnSearch.TabIndex = 14;
        this.btnSearch.Text = "Search All";
        this.btnSearch.UseVisualStyleBackColor = false;

        // 
        // btnSearchSpecific
        // 
        this.btnSearchSpecific.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
        this.btnSearchSpecific.FlatAppearance.BorderSize = 0;
        this.btnSearchSpecific.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
        this.btnSearchSpecific.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
        this.btnSearchSpecific.ForeColor = System.Drawing.Color.White;
        this.btnSearchSpecific.Location = new System.Drawing.Point(195, 305);
        this.btnSearchSpecific.Name = "btnSearchSpecific";
        this.btnSearchSpecific.Size = new System.Drawing.Size(155, 35);
        this.btnSearchSpecific.TabIndex = 15;
        this.btnSearchSpecific.Text = "Search Specific";
        this.btnSearchSpecific.UseVisualStyleBackColor = false;

        // 
        // dataGridView1
        // 
        this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
        | System.Windows.Forms.AnchorStyles.Left)
        | System.Windows.Forms.AnchorStyles.Right)));
        this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
        this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.None;
        this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
        this.dataGridView1.Location = new System.Drawing.Point(360, 78);
        this.dataGridView1.Name = "dataGridView1";
        this.dataGridView1.RowTemplate.Height = 25;
        this.dataGridView1.Size = new System.Drawing.Size(410, 350);
        this.dataGridView1.TabIndex = 16;

        // 
        // Form1
        // 
        this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
        this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
        this.BackColor = System.Drawing.Color.White;
        this.ClientSize = new System.Drawing.Size(800, 450);
        this.Controls.Add(this.dataGridView1);
        this.Controls.Add(this.btnSearchSpecific);
        this.Controls.Add(this.btnSearch);
        this.Controls.Add(this.btnDelete);
        this.Controls.Add(this.btnUpdate);
        this.Controls.Add(this.btnInsert);
        this.Controls.Add(this.txtProgram);
        this.Controls.Add(this.lblProgram);
        this.Controls.Add(this.txtDepartment);
        this.Controls.Add(this.lblDepartment);
        this.Controls.Add(this.txtSemester);
        this.Controls.Add(this.lblSemester);
        this.Controls.Add(this.txtName);
        this.Controls.Add(this.lblName);
        this.Controls.Add(this.txtId);
        this.Controls.Add(this.lblId);
        this.Controls.Add(this.panel1);
        this.Name = "Form1";
        this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
        this.Text = "Student Information System";
        this.panel1.ResumeLayout(false);
        this.panel1.PerformLayout();
        ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
        this.ResumeLayout(false);
        this.PerformLayout();
    }

    #endregion

    private Panel panel1;
    private Label lblTitle;
    private Label lblId;
    private TextBox txtId;
    private Label lblName;
    private TextBox txtName;
    private Label lblSemester;
    private TextBox txtSemester;
    private Label lblDepartment;
    private TextBox txtDepartment;
    private Label lblProgram;
    private TextBox txtProgram;
    private Button btnInsert;
    private Button btnUpdate;
    private Button btnDelete;
    private Button btnSearch;
    private Button btnSearchSpecific;
    private DataGridView dataGridView1;
}

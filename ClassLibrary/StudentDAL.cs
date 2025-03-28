using System.Data;
using System.Data.SqlClient;

public class StudentDAL
{
    DBconn conn = new DBconn();

    public int insertStudent(StudentProps p)
    {
        string qry = "insert into students values('" + p.ID + "','" + p.Name + "','" + p.semester + "','" + p.degree + "','" + p.department + "')";
        return conn.DUI(qry);
    }

    public int updatStudent(StudentProps p)
    {
        string qry = "Update students Set Name='" + p.Name + "',sem='" + p.semester + "',degree='" + p.degree + "',program='" + p.department + "' where ID='" + p.ID + "'";
        return conn.DUI(qry);
    }
    public int DeleteStudent(StudentProps p)
    {
        string qry = "Delete from students where ID='" + p.ID + "'";
        return conn.DUI(qry);
    }
    public DataTable GetallStudents()
    {
        string qry = "Select * from students";
        return conn.searchConnectionless(qry);
    }

    public DataTable GetStudentByID(StudentProps p)
    {
        string qry = "Select * from students where ID='" + p.ID + "'";
        return conn.searchConnectionless(qry);
    }
}
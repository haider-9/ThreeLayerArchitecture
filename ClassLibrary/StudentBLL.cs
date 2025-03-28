using System.Data;
using System.Data.SqlClient;

public class StudentBLL{
    StudentDAL dl=new StudentDAL();
    public string Insertstudent(StudentProps p){
        int res=dl.insertStudent(p);
        if(res>0)
            return "Student inserted successfully";
        
        else{
            return "Failed to insert student";
        }
    }
    public string DeleteStudent(StudentProps p){
        int res=dl.DeleteStudent(p);
        if(res>0)
            return "Student deleted successfully";
        
        else{
            return "Failed to delete student";
        }
    }
    public string UpdateStudent(StudentProps p){
        int res=dl.updatStudent(p);
        if(res>0)
            return "Student updated successfully";
        
        else{
            return "Failed to update student";
        }
    }
    public SqlDataReader searchallStudent(StudentProps p){
        SqlDataReader rdr=dl.GetallStudents(p);
        return rdr;
    }
    public SqlDataReader searchStudentById(StudentProps p){
        SqlDataReader rdr=dl.GetStudentByID(p);
        return rdr;
    }

}
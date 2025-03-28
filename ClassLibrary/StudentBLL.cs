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
    
}
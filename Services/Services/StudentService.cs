using Models.Domain;

namespace Services.Services;

public class StudentService
{
 private List<Student> namesOfStudents = new List<Student>();


 public List<Student> GetStudent(){
return namesOfStudents;
 }  





public void Add(Student student){
namesOfStudents.Add(student);
}






public void Update(Student student, int id){
int cnt=0;
foreach (var st in namesOfStudents)
{
   if(st.Id==id){
    namesOfStudents.Remove(st);
    namesOfStudents.Insert(cnt,student);
   }
   cnt++;
}

}


public Student GetStudentById(int id){
Student ik  = new Student();
foreach (var st in namesOfStudents)
{
   if(st.Id==id)
   
ik=st;
    
}
return ik;
}






public void Delete( int id){
foreach (var st in namesOfStudents)
{
   if(st.Id==id){
    namesOfStudents.Remove(st);
   }
}

}



public int Count(){
int cnt=namesOfStudents.Count();
return cnt;

}






















}
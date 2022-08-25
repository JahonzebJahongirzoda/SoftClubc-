using Models.Domain;

namespace Services.Services;

public class TeacherService
{
 private List<Teacher> namesOfTeachers = new List<Teacher>();


 public List<Teacher> GetTeacher(){
return namesOfTeachers;
 }  





public void Add(Teacher teacher){
namesOfTeachers.Add(teacher);
}






public void Update(Teacher teacher, int id){
int cnt=0;
foreach (var st in namesOfTeachers)
{
   if(st.Id==id){
    namesOfTeachers.Remove(st);
    namesOfTeachers.Insert(cnt,teacher);
   }
   cnt++;
}

}


public Teacher GetTeacherById(int id){
Teacher ik =new Teacher();
foreach (var st in namesOfTeachers)
{
   if(st.Id==id)
   
ik=st;
    
}
return ik;
}






public void Delete( int id){
foreach (var st in namesOfTeachers)
{
   if(st.Id==id){
    namesOfTeachers.Remove(st);
   }
}

}



public int Count(){
int cnt=namesOfTeachers.Count();
return cnt;

}






















}
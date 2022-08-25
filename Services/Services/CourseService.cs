using Models.Domain;

namespace Services.Services;

public class CourseService
{
    private List<Course> namesOfCourses = new List<Course>();


    public List<Course> GetCourse()
    {
        return namesOfCourses;
    }





    public void Add(Course course)
    {
        namesOfCourses.Add(course);
    }






    public void Update(Course course, int id)
    {
        int cnt = 0;
        foreach (var st in namesOfCourses)
        {
            if (st.Id == id)
            {
                namesOfCourses.Remove(st);
                namesOfCourses.Insert(cnt, course);
            }
            cnt++;
        }

    }


    public Course GetCourseById(int id)
    {
        Course ik = new Course();
        foreach (var st in namesOfCourses)
        {
            if (st.Id == id)

                ik = st;

        }
        return ik;
    }






    public void Delete(int id)
    {
        foreach (var st in namesOfCourses)
        {
            if (st.Id == id)
            {
                namesOfCourses.Remove(st);
            }
        }

    }



    public int Count()
    {
        int cnt = namesOfCourses.Count();
        return cnt;

    }






















}
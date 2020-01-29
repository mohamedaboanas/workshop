
using System;

namespace DBFirst
{
    public enum Level
    {
        Beginner = 1,
        Intermediate = 2,
        Advanced = 3

    }
    internal class Program
    {
        private static void Main()
        {
            var dbContext = new PlutoDBContext();

            var courses = dbContext.GetCourses();

            var newCourse = new Course
            {
                Level = CourseLevel.Beginner
            };
            dbContext.Courses.Add(newCourse);


            foreach (var course in courses)
            {
                Console.WriteLine(course.Title);
            }
        }
    }
}

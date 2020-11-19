using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MID
{
    class Department
    {
        public string Name { get; set; }
        public int CourseCount { get; set; }
        Course[] Courses;
        public Department()
        {
            Courses = new Course[20];
            CourseCount = 0;
        }
        public Department(string name)
        {
            Name = name;
            Courses = new Course[20];
            CourseCount = 0;
        }
        public void AddCourses(params Course[] c)
        {
            foreach(Course a in c)
            {
                Courses[CourseCount++] = a;
            }
        }
    }
}

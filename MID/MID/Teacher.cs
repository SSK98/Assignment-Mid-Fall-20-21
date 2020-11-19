using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MID
{
    class Teacher
    {
        public string Name { get; set; }
        public int TeachingHour { get; set; }
        public int SectionCount { get; set; }
        public string TeacherId { get; set; }
        public Department Department { get; set; }
        private Course[] Courses;
        private Section[] Sections;


        public Teacher()
        {
            Courses = new Course[10];
            TeachingHour = 0;
            SectionCount = 0;
            Sections = new Section[10];
        }
        public Teacher(string name, Department department,string id)
        {
            Name = name;
            Department = department;
            TeacherId = id;
            TeachingHour = 0;
            SectionCount = 0;
            Courses = new Course[10];
            Sections = new Section[10];

        }
    
        public bool AddTeachingHour(int num) ///Adds Teaching Hours and Checks for Max limit(21)
        {
            if (TeachingHour + num < 21)
            {
                TeachingHour += num;
                return true;
            }
            else
            {
                Console.WriteLine("Cannot add teacher to this section\n" +
                    "Current Working Hours :" + TeachingHour);
                return false;
            }
        }
        public void AddSection(Section section)
        {
            Sections[SectionCount++] = section;
        }
        public void ShowInfo()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("************    TEACHER INFORMATION   *********");
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("ID:" + TeacherId);
            Console.WriteLine("Department:" + Department.Name);
            Console.WriteLine("Weekly Teaching Hours:" + TeachingHour+"\n");
            Console.WriteLine("Courses:");
            Console.WriteLine("******************************************");
            Console.WriteLine("************    SECTION INFORMATION OF TEACHERS   *********");
            for (int i = 0; i < SectionCount; i++)
            {
                Console.WriteLine("Setion:  " + Sections[i].Name);
                Console.WriteLine("Class Time:  " + Sections[i].ClassTime);
            }
        }

    }
}

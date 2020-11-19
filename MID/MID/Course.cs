using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MID
{
    class Course
    {
        public string Name { get; set; }
        public string CourseId { get; set; }
        public int SectionCount { get; set; }
        public int TeacherCount { get; set; }
        Department department;
        private Section[] sections;
        public Teacher[] teachers;

        public Course()
        {
            sections = new Section[10];
            TeacherCount = 0;
            SectionCount = 0;
        }
        public Course(string name, string id)
        {
            sections = new Section[10];
            teachers = new Teacher[10];
            Name = name;
            CourseId = id;
            TeacherCount = 0;
            SectionCount = 0;
        }
        public void AddSection(params Section[] s)
        {
            foreach (var a in s)
            {
                
                sections[SectionCount++] = a;
              
                teachers[TeacherCount++] = a.Teacher;

            }
        }
        public void ShowInfo()
        {
            Console.WriteLine("******************************************");
            Console.WriteLine("************    COURSE DETAILS   *********");
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("CourseId:" + CourseId);
            Console.WriteLine("SectionCount:" + SectionCount);
            Console.WriteLine("************    Section and Teacher DETAILS   ********");
            for (int i = 0; i < TeacherCount; i++)
            {
                Console.WriteLine("Section Name:" + sections[i].Name);
                Console.WriteLine("Section Time:" + sections[i].ClassTime);
               Console.WriteLine("Teacher Name:" + teachers[i].Name);
                Console.WriteLine("Teacher Id:" + teachers[i].TeacherId);
                Console.WriteLine("");
                
            }
              
               
        }
    }
 }


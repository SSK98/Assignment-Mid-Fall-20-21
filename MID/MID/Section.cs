using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MID
{
    class Section
    {
        public string Name { get; set; }
        public string ClassDays { get; set; }
        public string ClassTime { get; set; }
        public int WeeklyHours { get; set; }
        public Teacher Teacher { get; set; }
        public Section() { }
        public Section(string name, string classDays, string classTime, int weeklyHours, Teacher teacher)
        {
                if(teacher.AddTeachingHour(weeklyHours))
            {
                Name = name;
                Teacher = teacher;
                ClassDays = classDays;
                ClassTime = classTime;
                WeeklyHours = weeklyHours;
                teacher.AddSection(this);
            }

        }
        public void ShowInfo()
        {
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("ClassDays:" + ClassDays);
            Console.WriteLine("ClassTime:" + ClassTime);
            Console.WriteLine("WeeklyHours:" + WeeklyHours);
            Console.WriteLine("Teacher Name:" + Teacher.Name);

        }
    }
}

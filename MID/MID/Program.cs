using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MID
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("!!!!!!Hello!!!!!!");
            Department d = new Department("Cse"); // Create departments 
            Course c = new Course("C#", "CS2120");
            d.AddCourses(c); //Create course and add them to department
            
            Teacher t = new Teacher("Sadman", d,"101");  //Create Faculty and adding them to section
            Section s1 = new Section("A", "Monday/Wednesday", "1.00 pm - 4.00 pm", 6, t);
            Section s2 = new Section("B", "Monday/Wednesday", "8.00 am - 10.00 am", 4, t);
            Section s3 = new Section("C", "Sunday/Teusday", "2.00 pm - 4.00 pm", 4, t);
            Section s4 = new Section("D", "Sunday/Teusday", "10.00 Am - 1.00 pm", 6, t);
            Section s5 = new Section("E", "Mon/Wed", "2.00 pm - 4.00 pm", 5, t); //this section will exceed the 21Hours limit
            
            c.AddSection(s1, s2, s3, s4);
            c.ShowInfo(); //View section details and faculty from course object. 

            t.ShowInfo(); //View section details from teacher object. 





        }
    }
}

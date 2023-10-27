using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace Disaheim
{
    public class CourseRepository
    {
        private List<Course> courses = new();

        public void AddCourse(Course course)
        {
            courses.Add(course);
        }

        public Course GetCourse(string name)
        {
            return courses.Find(i => i.Name == name);
        }

        public double GetTotalValue()
        {
            Utility utility = new();
            double total = 0.00;
            foreach (Course course in courses)
            {
                total += utility.GetValueOfCourse(course);
            }

            return total;
        }
    }
}

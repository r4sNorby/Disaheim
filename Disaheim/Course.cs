using System.Diagnostics;

namespace Disaheim
{
    public class Course : IValuable
    {
        public static double CourseHourValue = 875.0;
        public string Name { get; set; }
        public int DurationInMinutes { get; set; }

        public Course(string name) : this(name, 0)
        {

        }

        public Course(string name, int durationInMinutes)
        {
            Name = name;
            DurationInMinutes = durationInMinutes;
        }

        public override string ToString()
        {
            return $"Name: {Name}, Duration in Minutes: {DurationInMinutes}, Value: {GetValue()}";
        }

        public double GetValue()
        {
            int hours = (int)Math.Ceiling(DurationInMinutes / 60.00);
            return CourseHourValue * hours;
        }
    }
}

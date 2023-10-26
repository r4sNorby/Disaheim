using Disaheim;

namespace UtilityLib
{
    public class Utility
    {
        public double GetValueOfBook(Book book)
        {
            return book.Price;
        }

        public double GetValueOfAmulet(Amulet amulet)
        {
            return amulet.Quality switch
            {
                Level.low => 12.5,
                Level.medium => 20.0,
                Level.high => 27.5,
                _ => 0,
            };
        }

        public double GetValueOfCourse(Course course)
        {
            int hours = (int)Math.Ceiling(course.DurationInMinutes / 60.00);
            return 875.00 * hours;
        }
    }
}

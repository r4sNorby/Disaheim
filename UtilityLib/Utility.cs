﻿using Disaheim;

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
            switch (amulet.Quality)
            {
                case Level.low:
                    return 12.5;
                case Level.medium:
                    return 20.0;
                case Level.high:
                    return 27.5;
                default:
                    return 0;
            }
        }

        public double GetValueOfCourse(Course course)
        {
            int hours = (int)Math.Ceiling(course.DurationInMinutes / 60.00);
            return 875.00 * hours;
        }
    }
}

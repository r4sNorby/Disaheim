namespace Disaheim
{
    public class Utility
    {
        public double LowQualityValue = 12.5;
        public double MediumQualityValue = 20.0;
        public double HighQualityValue = 27.5;
        public double CourseHourValue = 875.0;
        //public double GetValueOfBook(Book book)
        //{
        //    return book.Price;
        //}

        public double GetValueOfMerchandise(Merchandise merchandise)
        {
            if (merchandise is Amulet)
            {
                Amulet amulet = (Amulet)merchandise;
                return amulet.Quality switch
                {
                    Level.low => LowQualityValue,
                    Level.medium => MediumQualityValue,
                    Level.high => HighQualityValue,
                    _ => 0,
                };
            }
            else if (merchandise is Book)
            {
                Book book = (Book)merchandise;
                return book.Price;
            }
            return 0.0;
        }

        //public double GetValueOfAmulet(Amulet amulet)
        //{
        //    return amulet.Quality switch
        //    {
        //        Level.low => 12.5,
        //        Level.medium => 20.0,
        //        Level.high => 27.5,
        //        _ => 0,
        //    };
        //}

        public double GetValueOfCourse(Course course)
        {
            int hours = (int)Math.Ceiling(course.DurationInMinutes / 60.00);
            return CourseHourValue * hours;
        }
    }
}

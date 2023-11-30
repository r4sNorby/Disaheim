using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Disaheim
{
    public class ValuableRepository : IPersistable
    {
        private List<IValuable> valuables = new();

        public void AddValuable(IValuable valuable)
        {
            valuables.Add(valuable);
        }

        public IValuable GetValuable(string id)
        {
            IValuable found = null;
            foreach (var valuable in valuables)
            {
                if (valuable is Amulet)
                {
                    Amulet amulet = (Amulet)valuable;
                    if (amulet.ItemID == id)
                        found = valuable;
                }
                else if (valuable is Book)
                {
                    Book book = (Book)valuable;
                    if (book.ItemID == id)
                        found = valuable;
                }
                else if (valuable is Course)
                {
                    Course course = (Course)valuable;
                    if (course.Name == id)
                        found = valuable;
                }
            }
            return found;
        }

        public double GetTotalValue(string? type = null)
        {
            double total = 0.00;
            foreach (IValuable valuable in valuables)
            {
                switch (type)
                {
                    case "Amulet":
                        if (valuable is Amulet)
                        {
                            total += valuable.GetValue();
                        }
                        break;
                    case "Book":
                        if (valuable is Book)
                        {
                            total += valuable.GetValue();
                        }
                        break;
                    case "Course":
                        if (valuable is Course)
                        {
                            total += valuable.GetValue();
                        }
                        break;
                    default:
                        total += valuable.GetValue();
                        break;
                }
            }

            return total;
        }

        public int Count()
        {
            return valuables.Count();
        }

        public void Save(string fileName = "ValuableRepository.txt")
        {
            using StreamWriter sw = new StreamWriter(fileName);
            foreach (var valuable in valuables)
            {
                string add = "";
                if (valuable is Amulet)
                {
                    Amulet a = (Amulet)valuable;
                    add = $"AMULET;ID{a.ItemID};{a.Quality};{a.Design}";
                }
                else if (valuable is Book)
                {
                    Book b = (Book)valuable;
                    add = $"BOG;ID{b.ItemID};{b.Title};{b.Price}";
                }
                else if (valuable is Course)
                {
                    Course c = (Course)valuable;
                    add = $"KURSUS;{c.Name};{c.DurationInMinutes}";
                }
                if (add != "")
                    sw.WriteLine(add);
            }
        }

        public void Load(string fileName = "ValuableRepository.txt")
        {
            using StreamReader sr = new StreamReader(fileName);
            string line;
            while ((line = sr.ReadLine()) != null)
            {
                string type = line.Split(';')[0];
                if (type == "AMULET")
                {
                    string id = line.Split(";")[1].Split("ID")[1];
                    Level quality = (Level)Enum.Parse(typeof(Level), line.Split(";")[2]);
                    Amulet a = new(id, quality, line.Split(";")[3]);
                    valuables.Add(a);
                }
                else if (type == "BOG")
                {
                    string id = line.Split(";")[1].Split("ID")[1];
                    Book b = new(id, line.Split(";")[2], double.Parse(line.Split(";")[3]));
                    valuables.Add(b);
                }
                else if (type == "KURSUS")
                {
                    Course c = new(line.Split(";")[1], int.Parse(line.Split(";")[2]));
                    valuables.Add(c);
                }
            }
        }
    }
}

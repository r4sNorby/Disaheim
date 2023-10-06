using Microsoft.VisualBasic.FileIO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BonusProjectSafe
{
    public class Menu
    {
        string title = "";
        List<string> options = new();

        public string Title
        {
            get { return title; }
            set { title = value; }
        }
        public List<string> Options
        {
            get { return options; }
            set { options = value; }
        }

        public void Show(int selectedIndex)
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(title);
            Console.ForegroundColor = ConsoleColor.White;

            foreach (string item in options)
            {
                if (options[selectedIndex] == item)
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write("> ");
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.Write(" ");
                }

                if (item == "Tilbage" || item == "Log ud")
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(item);
                    Console.ForegroundColor = ConsoleColor.White;
                }
                else
                {
                    Console.WriteLine(item);
                }
            }
        }
    }
}

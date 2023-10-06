using System;
using System.Reflection;

namespace BonusProjectSafe
{
    internal class Program
    {
        static SafeState state = SafeState.locked;
        static void Main(string[] args)
        {
            int index = 0;

            while (true)
            {
                // (Re)Create menu
                Menu menu = new();
                
                // Add menu-options depending on safe state
                if (state == SafeState.locked)
                {
                    menu.Options.Add("Unlock");
                }
                else if (state == SafeState.closed)
                {
                    menu.Options.Add("Lock");
                    menu.Options.Add("Open");
                }
                else if (state == SafeState.open)
                {
                    menu.Options.Add("Close");
                }

                // Create title for menu telling the state of the safe
                menu.Title = $"The safe is {state}\n";

                // Display menu and title
                menu.Show(index);

                // Listen for up/down arrows and Enter
                ConsoleKeyInfo keyinfo = Console.ReadKey(true);
                switch (keyinfo.Key)
                {
                    case ConsoleKey.DownArrow:
                        // Move down in menu
                        if (index + 1 < menu.Options.Count) index++;
                        break;
                    case ConsoleKey.UpArrow:
                        // Move up in menu
                        if (index - 1 >= 0) index--;
                        break;
                    case ConsoleKey.Enter:
                        // Select what to do with safe
                        SetState(menu.Options[index]);
                        index = 0;
                        break;
                }
            }
        }

        static void SetState(string chosenAction)
        {
            // Change state depending on what was chosen
            switch (chosenAction)
            {
                case "Unlock":
                    state = SafeState.closed;
                    break;
                case "Lock":
                    state = SafeState.locked;
                    break;
                case "Open":
                    state = SafeState.open;
                    break;
                case "Close":
                    state = SafeState.closed;
                    break;
            }
        }
    }
}
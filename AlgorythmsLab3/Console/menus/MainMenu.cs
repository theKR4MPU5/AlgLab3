using System.Collections.Generic;
using AlgLab3.Console.menus;

namespace AlgLab3.Console
{
    public class MainMenu : Menu
    {
        public MainMenu() : base(title: "", items: new List<MenuItem>()
        {
            new FirstTaskMenu(),
            new FourthTaskMenu(),
            new TestsMenu()
        })
        {
        }
    }
}
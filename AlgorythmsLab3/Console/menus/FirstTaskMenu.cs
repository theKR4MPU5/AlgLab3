using System.Collections.Generic;
using AlgLab3.Console.functions.stack;

namespace AlgLab3.Console.menus
{
    public class FirstTaskMenu : Menu
    {
        public FirstTaskMenu(bool isSelected = false) : base(title: "1 Задание: Стэк", isSelected: isSelected, items: new List<MenuItem>()
        {
            new ConvertFromPostfix(true),
            new ConvertToPostfix()
        })
        {
        }
    }
}
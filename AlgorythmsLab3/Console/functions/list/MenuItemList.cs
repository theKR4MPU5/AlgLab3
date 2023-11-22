using AlgLab3.Structures.LinkedList;

namespace AlgLab3.Console.functions.list
{
    public abstract class MenuItemList : MenuItem
    {
        protected LinkedList<int> List;
        protected MenuItemList(LinkedList<int> list,string title, bool isSelected = false) : base(title, isSelected)
        {
            List = list;
        }
    }
}
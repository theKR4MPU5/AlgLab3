namespace AlgLab3.Console
{
    public abstract class MenuItem
    {
        public readonly string Title;
        public abstract void Execute();
        public bool IsSelected { get; set; }

        public MenuItem(string title, bool isSelected = false)
        {
            Title = title;
            IsSelected = isSelected;
        }
    }
}
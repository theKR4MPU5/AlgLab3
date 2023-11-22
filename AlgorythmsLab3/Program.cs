using AlgLab3.Console;
using AlgLab3.Testing;


namespace AlgLab3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Menu menu = new MainMenu();
            menu.Start();
            
            TestsRun.Tests();
            
        }
    }
}
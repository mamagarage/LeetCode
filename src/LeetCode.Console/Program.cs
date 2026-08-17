namespace LeetCode.Console
{
    class Program
    {
        [STAThread]
        static void Main(string[] args)
        {
            ConsoleMe.ShowMenu(typeof(LeetCode).Assembly);
        }
    }
}

using System;

namespace TodoApp
{
    class Program
    {
        void ListAllTodos()
        {
            Cli.DisplayLine("Called ListAllTodos()");
        }
        void run()
        {
            Cli.DisplayLine("Todo Application");
            var option = DisplayMenu();
            while(option != 0)
            {
                switch (option)
                {
                    case 1:
                        ListAllTodos();
                        break;
                    case 0:
                        return;
                    default:
                        Cli.DisplayLine("Invalid Menu option!!");
                        break;
                }
                option = DisplayMenu();
            }
        }
        int DisplayMenu()
        {
            Cli.DisplayLine("Menu:");
            Cli.DisplayLine("1 : List all Todos");
            Cli.DisplayLine("0 : Exit");
            var option = Cli.Getint("Enter menu number");
            return option;
        }
        static void Main(string[] args)
        {
            var pgm = new Program();
            pgm.run();
        }
    }
}

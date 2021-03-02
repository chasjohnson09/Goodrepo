using System;
using System.Threading.Tasks;
using ToDoLib.Controllers;

namespace TodoApp
{
    class Program
    {
        TodoController todoCtrl = null;
        CategoriesController Catctrl = null;
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
                    case 2:
                        Create();
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
            Cli.DisplayLine("2 : Create New Todo");
            Cli.DisplayLine("1 : List all Todos");
            Cli.DisplayLine("0 : Exit");
            var option = Cli.Getint("Enter menu number");
            return option;
        }
        async Task CreateTodo()
        {
            Cli.DisplayLine("called CreateTodo()");
            Cli.DisplayLine();
            var categories = await carCtrl.GetAll();
            var todo = new ToDoLib
            {

            }
        }
        static void Main(string[] args)
        {
            var pgm = new Program();
            pgm.run();
        }
    }
}

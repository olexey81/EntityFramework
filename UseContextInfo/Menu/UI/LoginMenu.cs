using Library_DAL;
namespace UseContextInfo.Menu.UI
{
    public class LoginMenu
    {
        Loginer log = new();

        [MenuAction("Login as librarian", 1)]
        public void LoginLibrarian()
        {
            if (log.Login(new Librarian()))
            {
                Console.WriteLine("You have successfully logged in");
                // do something
            }

            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        [MenuAction("Login as reader", 2)]                               
        public void LoginReader()
        {
            if (log.Login(new Reader()))
            {
                Console.WriteLine("You have successfully logged in");
                // do something
            }
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        [MenuAction("Back", 0)]
        public void Back() => Menu.DetectMenu<MainMenu>().Process();
    }
}

using Library_DAL;

namespace UseContextInfo.Menu.UI
{
    public class RegistrationMenu
    {
        Registrator reg = new();
        
        [MenuAction("Register a new librarian", 1)]
        public void RegisterLibrarian()
        {
            reg.Registration(new Librarian());
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        [MenuAction("Register a new reader", 2)]
        public void RegisterReader()
        {
            reg.Registration(new Reader());
            Console.WriteLine("Press any key to return to the menu");
            Console.ReadKey();
        }

        [MenuAction("Back", 0)]
        public void Back()
        {
            Menu.DetectMenu<MainMenu>().Process();
        }
    }
}

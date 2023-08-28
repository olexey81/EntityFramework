using Library_DAL;
namespace UseContextInfo
{
    internal class Loginer 
    {
        private HomeWorkContext _context;
        public Loginer()
        {
            _context = new HomeWorkContext();
        }
        public bool Login(Librarian? librarian)
        {
            Console.Clear();
            Console.Write("Enter your login: ");
            librarian = _context.Librarians.Find(Console.ReadLine());

            if (librarian != null)
            {
                Console.Write("Enter your password: ");
                string? password = Console.ReadLine();
                if (password == librarian.Password)
                    return true;
                else
                {
                    Console.WriteLine("Incorrect password");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Incorrect login");
                return false;
            }
        }
        public bool Login(Reader? reader)
        {
            Console.Clear();
            Console.Write("Enter your login: ");
            reader = _context.Readers.Find(Console.ReadLine());

            if (reader != null)
            {
                Console.Write("Enter your password: ");
                string? password = Console.ReadLine();
                if (password == reader.Password)
                    return true;
                else
                {
                    Console.WriteLine("Incorrect password");
                    return false;
                }
            }
            else
            {
                Console.WriteLine("Incorrect login");
                return false;
            }
        }

    }
}

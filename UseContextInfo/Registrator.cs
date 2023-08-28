using Library_DAL;

namespace UseContextInfo
{
    internal class Registrator
    {
        private HomeWorkContext _context;
        private string _login;
        private string _password;
        private string _email;
        private string _firstName;
        private string _lastName;
        private string? _middleName;
        private string _docNumber;
        private int _docType;

        public Registrator()
        {
            _context = new HomeWorkContext();
        }
        public void Registration(Librarian librarian)
        {
            Console.Clear();
            Console.Write("Enter new login: ");
            _login = Console.ReadLine()!;

            if (_context.Librarians.Find(_login) != null)
                Console.WriteLine("This login is already used");
            else
            {
                Console.Write("Enter new password: ");
                _password = Console.ReadLine()!;
                Console.Write("Enter your email: ");
                _email = Console.ReadLine()!;

                var newLibrarian = new Librarian();
                newLibrarian.Login = _login!;
                newLibrarian.Password = _password!;
                newLibrarian.Email = _email!;
                _context.Librarians.Add(newLibrarian);
                _context.SaveChanges();
                Console.WriteLine("New librarian successfully registered!");
            }
        }
        public void Registration(Reader reader)
        {
            Console.Clear();
            Console.Write("Enter new login: ");
            _login = Console.ReadLine()!;

            if (_context.Readers.Find(_login) != null)
                Console.WriteLine("This login is already used");
            else
            {
                Console.Write("Enter new password: ");
                _password = Console.ReadLine()!;
                Console.Write("Enter your email: ");
                _email = Console.ReadLine()!;
                Console.Write("Enter first name: ");
                _firstName = Console.ReadLine()!;
                Console.Write("Enter last name: ");
                _lastName = Console.ReadLine()!;
                Console.Write("Enter middle name: ");
                _middleName = Console.ReadLine();
                Console.Write("Enter document's number: ");
                _docNumber = Console.ReadLine()!;
                Console.Write("Enter document's type (from 1 to 4): ");
                _docType = int.Parse(Console.ReadLine()!);

                var newReader = new Reader();
                newReader.Login = _login!;
                newReader.Password = _password!;
                newReader.Email = _email!;
                newReader.FirstName = _firstName!;
                newReader.LastName = _lastName!;
                newReader.MiddleName = _middleName;
                newReader.DocumentNumber = _docNumber!;
                newReader.DocumentType = _docType!;
                
                _context.Readers.Add(newReader);
                _context.SaveChanges();
                Console.WriteLine("New reader successfully registered!");
            }
        }
    }
}

using UseContextInfo.Menu.UI;

namespace UseContextInfo
{
    internal class Program
    {
        static void Main()
        {
            Menu.Menu.DetectMenu<MainMenu>().Process();
        }
    }
}

namespace UseContextInfo.Menu.UI
{
    public class MainMenu
    {
        [SubMenu("Login", 1)]                               // елементи головного менб - підменю
        public LoginMenu Login { get; set; }


        [SubMenu("Registration", 2)]                               // елементи головного менб - підменю
        public RegistrationMenu Registration { get; set; }


        [MenuAction("Exit", 0)]                             // елементи головного меню - вихід з програми
        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}

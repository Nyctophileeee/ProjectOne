using ProjectOne;

Game();


static void Game()
{
    Console.WriteLine("Please click enter to continue..."); Enter();
    Console.WriteLine("Login To Our Game"); Enter();
    AccountChecker.AcccountChecker();
}

static void Enter()
{
    char enter = Console.ReadKey().KeyChar;
}
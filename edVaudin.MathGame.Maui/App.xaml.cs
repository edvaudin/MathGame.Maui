using edVaudin.MathGame.Maui.Data;

namespace edVaudin.MathGame.Maui;

public partial class App : Application
{
	public static GameRepository GameRepository { get; private set; }
	public App(GameRepository gameRepository)
	{
		InitializeComponent();

		MainPage = new AppShell();
		GameRepository = gameRepository;
	}
}

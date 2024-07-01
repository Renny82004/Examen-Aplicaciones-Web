using IMC.Views;

namespace IMC;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new CalculateIMS();
	}
}

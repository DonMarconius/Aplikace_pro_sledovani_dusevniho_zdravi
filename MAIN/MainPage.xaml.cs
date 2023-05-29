namespace MauiApp1.MAIN;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}
    private async void TestyBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Rozcestnik_testy");
    }
}
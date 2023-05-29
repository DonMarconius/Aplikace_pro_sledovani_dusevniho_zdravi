namespace MauiApp1.MAIN.Rozcestnik.Testy;

public partial class Rozcestnik_testy : ContentPage
{
	public Rozcestnik_testy()
	{
		InitializeComponent();
	}

    private async void DepreseBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("DU");
    }
    private async void UzkostiBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("UU");
    }

    private async void MainBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("MainPage");
    }
}
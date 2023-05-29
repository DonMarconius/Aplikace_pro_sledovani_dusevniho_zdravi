namespace MauiApp1.MAIN.Rozcestnik.Testy.Deprese;

public partial class DU : ContentPage
{
	public DU()
	{
		InitializeComponent();
	}

    private async void PreviousBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Rozcestnik_testy");
    }

    private async void NextBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("D1");
    }
}
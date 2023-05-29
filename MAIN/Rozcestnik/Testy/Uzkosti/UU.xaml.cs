namespace MauiApp1.MAIN.Rozcestnik.Testy.Uzkosti;

public partial class UU : ContentPage
{
	public UU()
	{
		InitializeComponent();
	}

    private async void PreviousBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("Rozcestnik_testy");
    }

    private async void NextBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("U1");
    }
}
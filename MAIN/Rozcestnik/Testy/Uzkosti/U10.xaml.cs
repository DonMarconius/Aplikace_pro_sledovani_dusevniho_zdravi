namespace MauiApp1.MAIN.Rozcestnik.Testy.Uzkosti;

public partial class U10 : ContentPage
{
	public U10()
	{
		InitializeComponent();
	}

    //navigace
    private async void PreviousBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("U9");
    }

    private async void NextBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("U11");
    }

    //zjištìní hodnoty z radiobuttonu

    public static int u10 = 0;

    public void Rb1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb1.IsChecked)
        {
            u10 = 0;
        }
    }

    private void Rb2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb2.IsChecked)
        {
            u10 = 1;
        }
    }

    private void Rb3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb3.IsChecked)
        {
            u10 = 2;
        }
    }

    private void Rb4_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb4.IsChecked)
        {
            u10 = 3;
        }
    }
}
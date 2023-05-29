namespace MauiApp1.MAIN.Rozcestnik.Testy.Uzkosti;

public partial class U11 : ContentPage
{
	public U11()
	{
		InitializeComponent();
	}

    //navigace
    private async void PreviousBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("U10");
    }

    private async void NextBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("U12");
    }

    //zjištìní hodnoty z radiobuttonu

    public static int u11 = 0;

    public void Rb1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb1.IsChecked)
        {
            u11 = 0;
        }
    }

    private void Rb2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb2.IsChecked)
        {
            u11 = 1;
        }
    }

    private void Rb3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb3.IsChecked)
        {
            u11 = 2;
        }
    }

    private void Rb4_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb4.IsChecked)
        {
            u11 = 3;
        }
    }
}
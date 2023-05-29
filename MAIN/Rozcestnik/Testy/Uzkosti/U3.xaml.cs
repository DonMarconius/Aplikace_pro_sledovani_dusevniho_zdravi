namespace MauiApp1.MAIN.Rozcestnik.Testy.Uzkosti;

public partial class U3 : ContentPage
{
	public U3()
	{
		InitializeComponent();
	}

    //navigace
    private async void PreviousBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("U2");
    }

    private async void NextBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("U4");
    }

    //zji�t�n� hodnoty z radiobuttonu

    public static int u3 = 0;

    public void Rb1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb1.IsChecked)
        {
            u3 = 0;
        }
    }

    private void Rb2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb2.IsChecked)
        {
            u3 = 1;
        }
    }

    private void Rb3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb3.IsChecked)
        {
            u3 = 2;
        }
    }

    private void Rb4_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb4.IsChecked)
        {
            u3 = 3;
        }
    }
}
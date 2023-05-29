namespace MauiApp1.MAIN.Rozcestnik.Testy.Deprese;

public partial class D4 : ContentPage
{
	public D4()
	{
		InitializeComponent();
	}

    //navigace
    private async void PreviousBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("D3");
    }

    private async void NextBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("D5");
    }

    //zji�t�n� hodnoty z radiobuttonu

    public static int d4 = 0;

    public void Rb1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb1.IsChecked)
        {
            d4 = 0;
        }
    }

    private void Rb2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb2.IsChecked)
        {
            d4 = 1;
        }
    }

    private void Rb3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb3.IsChecked)
        {
            d4 = 2;
        }
    }

    private void Rb4_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb4.IsChecked)
        {
            d4 = 3;
        }
    }
}
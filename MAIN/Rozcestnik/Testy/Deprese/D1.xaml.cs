namespace MauiApp1.MAIN.Rozcestnik.Testy.Deprese;

public partial class D1 : ContentPage
{
	public D1()
	{
		InitializeComponent();
	}

    //navigace
    private async void PreviousBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("DU");
    }

    private async void NextBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("D2");
    }

    //zjištìní hodnoty z radiobuttonu

    public static int d1 = 0;

    public void Rb1_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb1.IsChecked)
        {
            d1 = 0;
        }
    }

    private void Rb2_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb2.IsChecked)
        {
            d1 = 1;
        }
    }

    private void Rb3_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if (Rb3.IsChecked)
        {
            d1 = 2;
        }
    }

    private void Rb4_CheckedChanged(object sender, CheckedChangedEventArgs e)
    {
        if(Rb4.IsChecked)
        {
            d1 = 3;
        }
    }
}
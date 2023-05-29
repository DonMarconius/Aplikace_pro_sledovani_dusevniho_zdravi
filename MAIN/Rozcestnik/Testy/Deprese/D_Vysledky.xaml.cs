using System.ComponentModel;
using Microsoft.Maui.Controls;


namespace MauiApp1.MAIN.Rozcestnik.Testy.Deprese;

public partial class D_Vysledky : ContentPage
{
    
    public D_Vysledky()
	{
		InitializeComponent();

	}

    //navigace
    private async void UvodBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("DU");
    }

    //promìnné z radiobuttonù
    int d1 = D1.d1;
    int d2 = D2.d2;
    int d3 = D3.d3;
    int d4 = D4.d4;
    int d5 = D5.d5;
    int d6 = D6.d6;
    int d7 = D7.d7;
    int d8 = D8.d8;
    int d9 = D9.d9;
    int d10 = D10.d10;
    int d11 = D11.d11;
    int d12 = D12.d12;
    int d13 = D13.d13;
    int d14 = D14.d14;
    int d15 = D15.d15;
    int d16 = D16.d16;
    int d17 = D17.d17;
    int d18 = D18.d18;
    int d19 = D19.d19;
    int d20 = D20.d20;
    int d21 = D21.d21;

    //výpoèet výsledného skóre
    public int VyslednyVypocet(int d1, int d2, int d3, int d4, int d5, int d6, int d7, int d8, int d9
        , int d10, int d11, int d12, int d13, int d14, int d15, int d16
        , int d17, int d18, int d19, int d20, int d21)
    {

        int Vysledek = d1 + d2 + d3 + d4 + d5 + d6 + d7 + d8 + d9 + d10 + d11 + d12 + d13 + d14 + d15 + d16 + d17 + d18 + d19 + d20 + d21;
        return Vysledek;
    }

    //výpis výsledného skóre
    protected override void OnAppearing()
    {
        base.OnAppearing();
        VysledekLabel.Text = VyslednyVypocet(d1, d2, d3, d4, d5, d6, d7, d8, d9, d10, d11, d12, d13, d14, d15, d16, d17, d18, d19, d20, d21).ToString();
    }
}
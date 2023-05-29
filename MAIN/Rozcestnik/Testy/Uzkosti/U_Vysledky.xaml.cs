namespace MauiApp1.MAIN.Rozcestnik.Testy.Uzkosti;

public partial class U_Vysledky : ContentPage
{
	public U_Vysledky()
	{
		InitializeComponent();
	}

    //navigace
    private async void UvodBtn_Clicked(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync("UU");
    }

    //promìnné z radiobuttonù
    int u1 = U1.u1;
    int u2 = U2.u2;
    int u3 = U3.u3;
    int u4 = U4.u4;
    int u5 = U5.u5;
    int u6 = U6.u6;
    int u7 = U7.u7;
    int u8 = U8.u8;
    int u9 = U9.u9;
    int u10 = U10.u10;
    int u11 = U11.u11;
    int u12 = U12.u12;
    int u13 = U13.u13;
    int u14 = U14.u14;
    int u15 = U15.u15;
    int u16 = U16.u16;
    int u17 = U17.u17;
    int u18 = U18.u18;
    int u19 = U19.u19;
    int u20 = U20.u20;
    int u21 = U21.u21;

    //výpoèet výsledného skóre
    public int VyslednyVypocetU(int u1, int u2, int u3, int u4, int u5, int u6, int u7, int u8, int u9, int u10, int u11, int u12, int u13, int u14, int u15, int u16, int u17, int u18, int u19, int u20, int u21)
    {

        int Vysledek = u1 + u2 + u3 + u4 + u5 + u6 + u7 + u8 + u9 + u10 + u11 + u12 + u13 + u14 + u15 + u16 + u17 + u18 + u19 + u20 + u21;
        return Vysledek;
    }

    //výpis výsledného skóre
    protected override void OnAppearing()
    {
        base.OnAppearing();
        VysledekLabel.Text = VyslednyVypocetU(u1, u2, u3, u4, u5, u6, u7, u8, u9, u10, u11, u12, u13, u14, u15, u16, u17, u18, u19, u20, u21).ToString();
    }
}
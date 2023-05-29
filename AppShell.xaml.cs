using MauiApp1.MAIN.Rozcestnik.Testy.Uzkosti;

namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();

        Routing.RegisterRoute("MainPage", typeof(MAIN.MainPage));

        Routing.RegisterRoute("Rozcestnik_testy", typeof(MAIN.Rozcestnik.Testy.Rozcestnik_testy));

        //Cesty Deprese
        Routing.RegisterRoute("DU", typeof(MAIN.Rozcestnik.Testy.Deprese.DU));

        Routing.RegisterRoute("D1", typeof(MAIN.Rozcestnik.Testy.Deprese.D1));

        Routing.RegisterRoute("D2", typeof(MAIN.Rozcestnik.Testy.Deprese.D2));

        Routing.RegisterRoute("D3", typeof(MAIN.Rozcestnik.Testy.Deprese.D3));

        Routing.RegisterRoute("D4", typeof(MAIN.Rozcestnik.Testy.Deprese.D4));

        Routing.RegisterRoute("D5", typeof(MAIN.Rozcestnik.Testy.Deprese.D5));

        Routing.RegisterRoute("D6", typeof(MAIN.Rozcestnik.Testy.Deprese.D6));

        Routing.RegisterRoute("D7", typeof(MAIN.Rozcestnik.Testy.Deprese.D7));

        Routing.RegisterRoute("D8", typeof(MAIN.Rozcestnik.Testy.Deprese.D8));

        Routing.RegisterRoute("D9", typeof(MAIN.Rozcestnik.Testy.Deprese.D9));

        Routing.RegisterRoute("D10", typeof(MAIN.Rozcestnik.Testy.Deprese.D10));

        Routing.RegisterRoute("D11", typeof(MAIN.Rozcestnik.Testy.Deprese.D11));

        Routing.RegisterRoute("D12", typeof(MAIN.Rozcestnik.Testy.Deprese.D12));

        Routing.RegisterRoute("D13", typeof(MAIN.Rozcestnik.Testy.Deprese.D13));

        Routing.RegisterRoute("D14", typeof(MAIN.Rozcestnik.Testy.Deprese.D14));

        Routing.RegisterRoute("D15", typeof(MAIN.Rozcestnik.Testy.Deprese.D15));

        Routing.RegisterRoute("D16", typeof(MAIN.Rozcestnik.Testy.Deprese.D16));

        Routing.RegisterRoute("D17", typeof(MAIN.Rozcestnik.Testy.Deprese.D17));

        Routing.RegisterRoute("D18", typeof(MAIN.Rozcestnik.Testy.Deprese.D18));

        Routing.RegisterRoute("D19", typeof(MAIN.Rozcestnik.Testy.Deprese.D19));

        Routing.RegisterRoute("D20", typeof(MAIN.Rozcestnik.Testy.Deprese.D20));

        Routing.RegisterRoute("D21", typeof(MAIN.Rozcestnik.Testy.Deprese.D21));


        Routing.RegisterRoute("DV", typeof(MAIN.Rozcestnik.Testy.Deprese.D_Vysledky));


        //Cesty Úzkosti
        Routing.RegisterRoute("UU", typeof(MAIN.Rozcestnik.Testy.Uzkosti.UU));

        Routing.RegisterRoute("U1", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U1));

        Routing.RegisterRoute("U2", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U2));

        Routing.RegisterRoute("U3", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U3));

        Routing.RegisterRoute("U4", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U4));

        Routing.RegisterRoute("U5", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U5));

        Routing.RegisterRoute("U6", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U6));

        Routing.RegisterRoute("U7", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U7));

        Routing.RegisterRoute("U8", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U8));

        Routing.RegisterRoute("U9", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U9));

        Routing.RegisterRoute("U10", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U10));

        Routing.RegisterRoute("U11", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U11));

        Routing.RegisterRoute("U12", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U12));

        Routing.RegisterRoute("U13", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U13));

        Routing.RegisterRoute("U14", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U14));

        Routing.RegisterRoute("U15", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U15));

        Routing.RegisterRoute("U16", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U16));

        Routing.RegisterRoute("U17", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U17));

        Routing.RegisterRoute("U18", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U18));

        Routing.RegisterRoute("U19", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U19));

        Routing.RegisterRoute("U20", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U20));

        Routing.RegisterRoute("U21", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U21));


        Routing.RegisterRoute("U_Vysledky", typeof(MAIN.Rozcestnik.Testy.Uzkosti.U_Vysledky));  
    }
}

using LeonAna_Hamburguesa.Views;
namespace LeonAna_Hamburguesa;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(nameof(BurgerItemPageAL), typeof(BurgerItemPageAL));
        Routing.RegisterRoute(nameof(BurgerListPageAL), typeof(BurgerListPageAL));
    }
}

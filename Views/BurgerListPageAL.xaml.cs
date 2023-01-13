using LeonAna_Hamburguesa.Models;
namespace LeonAna_Hamburguesa.Views;

public partial class BurgerListPageAL : ContentPage
{
    List<BurgerAL> burger;

    public BurgerListPageAL()
	{
        InitializeComponent();
        cargarDatosAL();

    }
    async void OnItemAddedAL(object sender, EventArgs e)
    {
        await Shell.Current.GoToAsync(nameof(BurgerItemPageAL));
    }
    private void cargarDatosAL()
    {
        burger = App.BurgerRepoAL.GetAllBurgers();
        burgerListAL.ItemsSource = burger;
    }
    protected override void OnAppearing()
    {
        cargarDatosAL();
    }
}


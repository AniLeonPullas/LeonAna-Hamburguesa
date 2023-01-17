using LeonAna_Hamburguesa.Models;
namespace LeonAna_Hamburguesa.Views;

public partial class BurgerListPageAL : ContentPage
{
    List<BurgerAL> burger;

    public BurgerListPageAL()
	{
        InitializeComponent();
        cargarDatosAL();
        BindingContext = this;

    }
    public void OnItemAddedAL(object sender, EventArgs e)
    {
       Shell.Current.GoToAsync(nameof(BurgerItemPageAL),true, new Dictionary<string,object>
       {
           ["Item"]=new BurgerAL()
       });
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

    private void SelectedItem(object sender, SelectionChangedEventArgs e)
    {
        if (e.CurrentSelection.FirstOrDefault() is not BurgerAL Item)
            return;

        Shell.Current.GoToAsync(nameof(BurgerItemPageAL), true, new Dictionary<string, object> { ["Item"] = Item });
    }
}


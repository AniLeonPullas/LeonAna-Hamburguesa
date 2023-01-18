using LeonAna_Hamburguesa.Data;
using SQLite;
using LeonAna_Hamburguesa.Models;
namespace LeonAna_Hamburguesa.Views;

[QueryProperty ("Item","Item")]
public partial class BurgerItemPageAL : ContentPage
{
    public BurgerAL Item
    {
        get => BindingContext as BurgerAL;
        set => BindingContext = value;
    }

    public BurgerItemPageAL()
	{
		InitializeComponent();
	}
    
    private void OnSaveClickedAL(object sender, EventArgs e)
    {
        //Item.Name = nameAL.Text;
        //Item.Description = descAL.Text;
        // Item.WithExtraCheese = _flag;

        App.BurgerRepoAL.AddNewBurgerAL(Item);
        Shell.Current.GoToAsync("..");
    }
    private void OnCancelClickedAL(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }


    private async void DeleteButton_ClickedAL(object sender, EventArgs e)
    {
        if (Item.Id == 0)
        {
            return;
        }
        App.BurgerRepoAL.DeleteItemAL(Item);
        await Shell.Current.GoToAsync("..");
    }
}
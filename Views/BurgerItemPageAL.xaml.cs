using LeonAna_Hamburguesa.Data;
using SQLite;
using LeonAna_Hamburguesa.Models;
namespace LeonAna_Hamburguesa.Views;

[QueryProperty ("Item","Item")]
public partial class BurgerItemPageAL : ContentPage
{
    // BurgerAL Item = new BurgerAL();
    bool _flag;

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

        App.BurgerRepoAL.AddNewBurger(Item);
        Shell.Current.GoToAsync("..");
    }
    private void OnCancelClickedAL(object sender, EventArgs e)
    {
        Shell.Current.GoToAsync("..");
    }
   private void OnCheckBoxCheckedChangedAL(object sender,
     CheckedChangedEventArgs e)
        {
            _flag = e.Value;
        }

    private async void DeleteButton_ClickedAL(object sender, EventArgs e)
    {
        if (Item.Id == 0)
        {
            return;
        }
        App.BurgerRepoAL.DeleteItem(Item);
        await Shell.Current.GoToAsync("..");
    }
}
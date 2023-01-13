using LeonAna_Hamburguesa.Data;
using SQLite;
using LeonAna_Hamburguesa.Models;
namespace LeonAna_Hamburguesa.Views;

public partial class BurgerItemPageAL : ContentPage
{
    BurgerAL Item = new BurgerAL();
    bool _flag;

    public BurgerItemPageAL()
	{
		InitializeComponent();
	}
    
    private void OnSaveClickedAL(object sender, EventArgs e)
    {
        Item.Name = nameAL.Text;
        Item.Description = descAL.Text;
        Item.WithExtraCheese = _flag;
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
        if (BindingContext is Models.BurgerAL hambLA)
        {
            // Delete the file.
            if (File.Exists(hambLA.Name))
                File.Delete(hambLA.Name);
        }

        await Shell.Current.GoToAsync("..");
    }
}
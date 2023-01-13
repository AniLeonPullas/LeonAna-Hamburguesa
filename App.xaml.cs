using LeonAna_Hamburguesa.Data;

namespace LeonAna_Hamburguesa;

public partial class App : Application
{
    public static BurgerDatabaseAL BurgerRepoAL { get; private set; }
    public App(BurgerDatabaseAL repo)
    {
        InitializeComponent();

        MainPage = new AppShell();

        // TODO: Initialize the PersonRepository property with the PersonRespository singleton object
        BurgerRepoAL = repo;
    }
}

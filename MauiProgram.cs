using LeonAna_Hamburguesa.Data;
namespace LeonAna_Hamburguesa;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
			});

        string dbPath = FileAccessHelper.GetLocalFilePath("people.db3");
        builder.Services.AddSingleton<BurgerDatabaseAL>(s => ActivatorUtilities.CreateInstance<BurgerDatabaseAL>(s, dbPath));

        return builder.Build();
    }

}

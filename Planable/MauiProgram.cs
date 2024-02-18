using Microsoft.Extensions.Logging;

namespace Planable
{
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
            builder.Services.AddSingleton<MainPage>();

            builder.Services.AddSingleton<PageBudget>();

            builder.Services.AddSingleton<AboutUs>();

            builder.Services.AddSingleton<FinanceCalculator>();

            builder.Services.AddSingleton<LoginPage>();

            builder.Services.AddSingleton<SignUpPage>();
            return builder.Build();
        }
    }
}

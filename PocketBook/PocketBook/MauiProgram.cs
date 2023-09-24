using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;

namespace PocketBook
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var startup = new Startup();
            var builder = MauiApp.CreateBuilder();
            Startup.ConfigureServices(builder.Services);
            builder
                .UseMauiApp<App>()
                // Initialize the .NET MAUI Community Toolkit
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });
            


#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
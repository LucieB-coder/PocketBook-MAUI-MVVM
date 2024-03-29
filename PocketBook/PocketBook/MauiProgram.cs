﻿using Microsoft.Extensions.Logging;
using CommunityToolkit.Maui;
using Microsoft.Extensions.DependencyInjection;
using Stub;
using Model;
using ViewModelWrapper;
using PocketBook.Pages;

namespace PocketBook
{
    public static class MauiProgram
    {
        public static MauiApp CreateMauiApp()
        {
            var builder = MauiApp.CreateBuilder();
            builder
                .UseMauiApp<App>()
                // Initialize the .NET MAUI Community Toolkit
                .UseMauiCommunityToolkit()
                .ConfigureFonts(fonts =>
                {
                    fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
                    fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
                });


            builder.Services.AddSingleton<ILibraryManager, Stub.Stub>();
            builder.Services.AddSingleton<IUserLibraryManager, Stub.Stub>();
            builder.Services.AddSingleton<ManagerViewModel>();
            builder.Services.AddSingleton<BookViewModel>();
            builder.Services.AddSingleton<AllBooksPage>();
            builder.Services.AddSingleton<LibraryPage>();
            builder.Services.AddSingleton<OneBookPage>();
            builder.Services.AddSingleton<FilterPage>();
            builder.Services.AddSingleton<LendBooksPage>();

#if DEBUG
            builder.Logging.AddDebug();
#endif

            return builder.Build();
        }
    }
}
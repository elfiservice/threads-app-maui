using CommunityToolkit.Maui.Markup;
using Microsoft.Extensions.Logging;
using ThreadsApp.Pages;
using ThreadsApp.Plugins.DataStore.InMemory;
using ThreadsApp.UseCases;

namespace ThreadsApp;

public static class MauiProgram
{
	public static MauiApp CreateMauiApp()
	{
		var builder = MauiApp.CreateBuilder();
		builder
			.UseMauiApp<App>()
			.UseMauiCommunityToolkitMarkup()
			.ConfigureFonts(fonts =>
			{
				fonts.AddFont("OpenSans-Regular.ttf", "OpenSansRegular");
				fonts.AddFont("OpenSans-Semibold.ttf", "OpenSansSemibold");
				fonts.AddFont("fa-brands.otf", "FAB");
				fonts.AddFont("fa-regular.otf", "FAR");
				fonts.AddFont("fa-solid.otf", "FAS");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		builder.Services.AddSingleton<IThreadRepository, ThreadsInMemoryRepository>();
		builder.Services.AddSingleton<IUserRepository, UsersInMemoryRepository>();

		builder.Services.AddSingleton<IViewThreadsUseCase, ViewThreadsUseCase>();
		builder.Services.AddSingleton<IViewUsersUseCase, ViewUsersUseCase>();

		builder.Services.AddSingleton<HomePage>();
		builder.Services.AddSingleton<SearchPage>();


		return builder.Build();
	}
}

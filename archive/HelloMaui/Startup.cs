using Microsoft.Maui.Hosting;
using Microsoft.Maui.Controls.Hosting;

namespace HelloMaui
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
					fonts.AddFont("ionicons.ttf", "IonIcons");
				});

			return builder.Build();
		}
	}
}
﻿using Microsoft.Extensions.Logging;

namespace jogojulias;

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
				fonts.AddFont("SmileNice.otf", "SmileNices");
				fonts.AddFont("MondayFiesta.ttf","MondayFiesta");
				fonts.AddFont("Room Handmade.otf", "Room Handmade");
			});

#if DEBUG
		builder.Logging.AddDebug();
#endif

		return builder.Build();
	}
}

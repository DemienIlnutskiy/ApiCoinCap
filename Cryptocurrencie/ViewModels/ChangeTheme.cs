using MaterialDesignThemes.Wpf;
using System;
using System.Windows;

namespace Cryptocurrencie.ViewModels
{
	static class ChangeTheme
	{
		public static void ChangeThemeDark(bool darkMode=true)
		{
			PaletteHelper palette = new PaletteHelper();

			ITheme theme = palette.GetTheme();

			if (darkMode)
			{
				theme.SetBaseTheme(Theme.Dark);
			}
			else
			{
				theme.SetBaseTheme(Theme.Light);
			}
			palette.SetTheme(theme);
		}
	}
}

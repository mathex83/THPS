using System.Collections.Generic;
using System.Windows;
using System.Windows.Controls;
using THPS.Pages;

namespace THPS
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		static Home HomePage = new();
		static Progress progressPage = new();
		private readonly Dictionary<string, Page> PageDirectory = new()
		{
			{ "Home", HomePage },
			{ "Progress", progressPage }
		};
		public MainWindow()
		{
			InitializeComponent();
			viewingWindow.Navigate(HomePage);

			foreach (MenuItem item in TopBar.Items)
			{
				if (item.HasItems)
				{
					foreach (MenuItem childItem in item.Items)
					{
						item.AddHandler(MenuItem.ClickEvent, new RoutedEventHandler(MenuItem_Click));
					}
				}
				else
				{
					item.AddHandler(MenuItem.ClickEvent, new RoutedEventHandler(MenuItem_Click));
				}
			}
		}
		private void MenuItem_Click(object sender, RoutedEventArgs e)
		{
			// Cast event source.
			MenuItem item = e.Source as MenuItem;
			// Change the Title of the window.
			string header = item.Header.ToString();
			this.Title = header;
			try
			{
				viewingWindow.Navigate(PageDirectory[header]);
			}
			catch (System.Exception err)
			{
				MessageBox.Show($"Seems that the page you are trying to reach, could not be reached!\nError: {err.Message}");
			}
		}

		private void Exit_Click(object sender, RoutedEventArgs e)
		{
			Application.Current.Shutdown();
		}
	}
}

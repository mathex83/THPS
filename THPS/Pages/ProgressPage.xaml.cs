using System.Collections.Generic;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using THPS.Models;
using THPS.Models.Maps;
using System;
using System.Windows;

namespace THPS.Pages
{
	/// <summary>
	/// Interaction logic for Progress.xaml
	/// </summary>
	public partial class ProgressPage : Page
	{
		public ProgressPage()
		{
			InitializeComponent();
		}		

		private void TBColorChange_click(object sender, MouseButtonEventArgs e)
		{
			//TextBlock tb = sender as TextBlock;
			Canvas c = sender as Canvas;

			if (c.Background != Brushes.Green)
				c.Background = Brushes.Green;
			else
				c.Background = Brushes.Transparent;
		}
		public void LoadAchievements(string header)
		{
			List<TextBlock> textBlocks = new();
			Warehouse warehouse = new();
			foreach (UIElement item in ThpsGrid.Children)
			{				
				if (item is TextBlock && Grid.GetColumn(item) == 0)
				{
					textBlocks.Add((TextBlock)item);					
				}				
			}

			for (int i = 0; i < warehouse.Achievements.Count - 1; i++)
			{
				textBlocks[i].Text = warehouse.Achievements[i].Name.ToString();
			}

			//MessageBox.Show(textBlocks[19].GetType().ToString());
		}

	}
}

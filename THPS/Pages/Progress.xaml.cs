using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace THPS.Pages
{
	/// <summary>
	/// Interaction logic for Progress.xaml
	/// </summary>
	public partial class Progress : Page
	{
		public Progress()
		{
			InitializeComponent();
		}

		private void TBColorChange_click(object sender, MouseButtonEventArgs e)
		{
			TextBlock tb = sender as TextBlock;

			if (tb.Background != Brushes.Green)
				tb.Background = Brushes.Green;
			else
				tb.Background = Brushes.Transparent;
		}
	}
}

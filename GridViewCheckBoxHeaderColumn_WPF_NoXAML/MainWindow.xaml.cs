using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using Telerik.Windows.Controls.GridView;
using Telerik.Windows.Data;
using Telerik.Windows.Controls;

namespace GridViewCheckBoxHeaderColumn_WPF_NoXAML
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		public MainWindow()
		{
			InitializeComponent();
		}

		public void CheckBox_Unchecked(object sender, RoutedEventArgs e)
		{
			var headerCell = (sender as CheckBox).ParentOfType<GridViewHeaderCell>();
			if (headerCell != null)
			{
				foreach (var item in this.clubsGrid.Items)
				{
					(item as Club).IsChecked = false;
				}
			}
			
		}

		public void CheckBox_Checked(object sender, RoutedEventArgs e)
		{
			var headerCell = (sender as CheckBox).ParentOfType<GridViewHeaderCell>();
			if (headerCell != null)
			{
				foreach (var item in this.clubsGrid.Items)
				{
					(item as Club).IsChecked = true;
				}
			}
		}
	}
}

// Copyright (c) Microsoft Corporation and Contributors.
// Licensed under the MIT License.

using Microsoft.UI.Xaml;
using Microsoft.UI.Xaml.Controls;
using Microsoft.UI.Xaml.Controls.Primitives;
using Microsoft.UI.Xaml.Data;
using Microsoft.UI.Xaml.Input;
using Microsoft.UI.Xaml.Media;
using Microsoft.UI.Xaml.Navigation;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using CommunityToolkit.WinUI.UI.Controls;

// To learn more about WinUI, the WinUI project structure,
// and more about our project templates, see: http://aka.ms/winui-project-info.

namespace DataGridExample
{
	/// <summary>
	/// An empty window that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class MainWindow : Window
	{
		public List<Customer> Customers => Customer.Customers();
		public MainWindow()
		{
			this.InitializeComponent();
			DataGrid dataGrid1 = new DataGrid();
			LayoutRoot.Children.Add(dataGrid1);
			//List<Customer> MyCustomers = Customer.Customers();			// Get the list of customers. 
		}

		private void myButton_Click(object sender, RoutedEventArgs e)
		{
			myButton.Content = "Clicked";
		}
	}
}

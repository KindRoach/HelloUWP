using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace HamburgerHeaven
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
            framHamburger.Navigate(typeof(FinancialPage));
            TextBlocktittle.Text = "Financial";
        }

        private void hamburgerBUtton_Click(object sender, RoutedEventArgs e)
        {
            hamburgerView.IsPaneOpen = !hamburgerView.IsPaneOpen;
        }

        private void listHamburger_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (itemFinancial.IsSelected)
            {
                framHamburger.Navigate(typeof(FinancialPage));
                TextBlocktittle.Text = "Financial";
                hamburgerView.IsPaneOpen = false;
            }
            else if (itemFood.IsSelected)
            {
                framHamburger.Navigate(typeof(FoodPage));
                TextBlocktittle.Text = "Food";
                hamburgerView.IsPaneOpen = false;
            }
        }
    }
}

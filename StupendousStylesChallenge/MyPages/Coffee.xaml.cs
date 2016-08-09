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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace StupendousStylesChallenge.MyPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Coffee : Page
    {
        public Coffee()
        {
            this.InitializeComponent();
        }

        private void itemRoastNone_Click(object sender, RoutedEventArgs e)
        {
            textRoast.Text = "None";
            textCream.Text = "";
            textSweetener.Text = "";
        }

        private void itemRoastDark_Click(object sender, RoutedEventArgs e)
        {
            textRoast.Text = (sender as MenuFlyoutItem).Text;
        }

        private void itemRoastMedium_Click(object sender, RoutedEventArgs e)
        {
            textRoast.Text = (sender as MenuFlyoutItem).Text;
        }

        private void itemSweetenerNone_Click(object sender, RoutedEventArgs e)
        {
            textSweetener.Text = " + " + (sender as MenuFlyoutItem).Text;
        }

        private void itemSweetenerSugar_Click(object sender, RoutedEventArgs e)
        {
            textSweetener.Text = " + " + (sender as MenuFlyoutItem).Text;
        }

        private void itemCreamNone_Click(object sender, RoutedEventArgs e)
        {
            textCream.Text= " + " + (sender as MenuFlyoutItem).Text;
        }

        private void itemCream2pMilk_Click(object sender, RoutedEventArgs e)
        {
            textCream.Text = " + " + (sender as MenuFlyoutItem).Text;
        }

        private void itemCreamWhole_Click(object sender, RoutedEventArgs e)
        {
            textCream.Text = " + " + (sender as MenuFlyoutItem).Text;
        }
    }
}

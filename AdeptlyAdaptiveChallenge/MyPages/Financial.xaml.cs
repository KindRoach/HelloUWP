using AdeptlyAdaptiveChallenge.MyClasses;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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

namespace AdeptlyAdaptiveChallenge.MyPages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class Financial : Page
    {
        public ObservableCollection<NewsItem> NewsItems;
        public Financial()
        {
            this.InitializeComponent();
            NewsItems = new ObservableCollection<MyClasses.NewsItem>();
            NewsFactory.GetNewsWithCategory(NewsItem.categoryType.Financial, NewsItems);
        }
    }
}

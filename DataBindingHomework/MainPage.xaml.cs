using DataBindingHomework.MyClass;
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

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace DataBindingHomework
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private MainPageViewModel mv;
        public MainPage()
        {
            this.InitializeComponent();
            mv = new MainPageViewModel();
            mv.Icons = new List<Icon>();
            mv.Icons.Add(new MyClass.Icon() { IconSource = @"MyIcons/female-01.png" }); //MyIcons/male-01.png
            mv.Icons.Add(new MyClass.Icon() { IconSource = @"MyIcons/female-02.png" });
            mv.Icons.Add(new MyClass.Icon() { IconSource = @"MyIcons/female-03.png" });
            mv.Icons.Add(new MyClass.Icon() { IconSource = @"MyIcons/male-01.png" });
            mv.Icons.Add(new MyClass.Icon() { IconSource = @"MyIcons/male-02.png" });
            mv.Icons.Add(new MyClass.Icon() { IconSource = @"MyIcons/male-03.png" });
            mv.Contects = new ObservableCollection<Contect>();
            mv.Contects.Add(new MyClass.Contect() { Name = "Zhang", Age = 18, Icon = "MyIcons/male-01.png" });
        }

        private void AddContect(object sender, RoutedEventArgs e)
        {
            if (NameText.Text!=null && AgeText.Text!=null && IconText.SelectedIndex!=-1)
            {
                mv.Contects.Add(new MyClass.Contect() { Name = NameText.Text, Age = Convert.ToInt32(AgeText.Text), Icon = (IconText.SelectedItem as Icon).IconSource });
                NameText.Text = "";
                AgeText.Text = "";
                IconText.SelectedIndex = -1;
            }
        }
    }

    public class MainPageViewModel
    {
        public ObservableCollection<Contect> Contects { get; set; }
        public List<Icon> Icons { get; set; }
    }
}

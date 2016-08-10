using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace DataBindExampleNew
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private Student st;

        public MainPage()
        {
            this.InitializeComponent();
            st = new Student() { Age = 18 };
        }

        private void AddAge(object sender, RoutedEventArgs e)
        {
            st.Age++;
        }

        private void ShowAge(object sender, RoutedEventArgs e)
        {
            showAgeTextBox.Text = $"{st.Age}";
        }
    }

    public class Student : INotifyPropertyChanged
    {
        private int age;

        public int Age
        {
            get { return age; }
            set
            {
                age = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(nameof(Age)));
            }
        }


        public event PropertyChangedEventHandler PropertyChanged;
    }
}

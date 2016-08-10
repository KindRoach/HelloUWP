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

namespace DataBindingExampleOld
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
            mv.Students = new ObservableCollection<Student>();
            for (int i = 0; i < 20; i++)
            {
                mv.Students.Add(new Student() { Age = i + 1 });
            }
            DataContext = mv;
        }

        private void DeleteStudent(object sender, RoutedEventArgs e)
        {
            if (mv.SelectedStudent != null)
            {
                mv.Students.Remove(mv.SelectedStudent);
            }
        }

        private void AddStudent(object sender, RoutedEventArgs e)
        {
            mv.Students.Add(new Student() { Age = mv.Students.Count + 1 });
        }
    }

    public class MainPageViewModel
    {
        public ObservableCollection<Student> Students { get; set; }
        public Student SelectedStudent { get; set; }
    }

    public class Student
    {
        public int Age { get; set; }
    }
}

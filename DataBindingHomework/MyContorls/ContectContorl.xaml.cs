using DataBindingHomework.MyClass;
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

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace DataBindingHomework.MyContorls
{
    public sealed partial class ContectContorl : UserControl
    {
        public Contect contectData { get { return DataContext as Contect; } }
        public ContectContorl()
        {
            this.InitializeComponent();
            DataContextChanged += (s, e) => CorrectIconPath();
            DataContextChanged += (s, e) => Bindings.Update();            
        }
        public void CorrectIconPath()
        {
            if (contectData != null)
                if (!contectData.Icon.StartsWith(".."))
                    contectData.Icon = "../" + contectData.Icon;

        }
    }
}

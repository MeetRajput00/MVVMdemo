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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace sample
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void nextPage(object sender, RoutedEventArgs e)
        {
            if (userName.Text == "admin" && passWord.Password == "admin")
                this.Frame.Navigate(typeof(BlankPage1));
            else
                popUp.Visibility = Visibility.Visible;
        }

        private void clearTextBox(object sender, RoutedEventArgs e)
        {
            userName.Text = "";
            passWord.Password = "";
            popUp.Visibility = Visibility.Collapsed;
        }
    }
}

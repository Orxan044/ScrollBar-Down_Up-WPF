using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Down_Up_WPF
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

        private void ScrollBar_PreviewMouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }
        private void ScrollBar_PreviewMouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            e.Handled = true;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (Barmen.Value != 1) { Barmen.Value += 0.1; about.Content = "Down Or Up Click"; }
            else { about.Content = "Max Value"; }
        }

        private void Button_Click2(object sender, RoutedEventArgs e)
        {
            if (Barmen.Value != 0) { Barmen.Value -= 0.1; about.Content = "Down Or Up Click"; }
            else { about.Content = "Minumum Value"; }

        }


    }
}

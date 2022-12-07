using System;
using System.Collections.Generic;
using System.Diagnostics;
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

namespace WPFPortfolio
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
        private void Hyperlink_RequestNavigate(object sender, RequestNavigateEventArgs e)
        {
            Process.Start(new ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }

        private void btntool_Click_1(object sender, RoutedEventArgs e)
        {


            ProcessStartInfo startInfo = new ProcessStartInfo("https://github.com/Ouakhila");
            startInfo.UseShellExecute = true; 
            Process.Start(startInfo);

        }
        private void btnHireMe_Click(object sender, RoutedEventArgs e)
        {

        }
        private void btnvrgame_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}

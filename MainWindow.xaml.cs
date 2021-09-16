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

namespace R20
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

        private void BTN_plus(object sender, RoutedEventArgs e)
        {
            int x, y, result;

            x = int.Parse(tb_X.Text);
            y = int.Parse(tb_Y.Text);
            result = x + y;
            tb_RES.Text = result + "";
        }
        private void BTN_divide(object sender, RoutedEventArgs e)
        {
            double x, y, result;

            x = double.Parse(tb_X.Text);
            y = double.Parse(tb_Y.Text);
            result = x / y;
            tb_RES.Text = result + "";
        }

        private void BTN_minus(object sender, RoutedEventArgs e)
        {
            int x, y, result;

            x = int.Parse(tb_X.Text);
            y = int.Parse(tb_Y.Text);
            result = x - y;
            tb_RES.Text = result + "";
        }

        private void BTN_multi(object sender, RoutedEventArgs e)
        {
            int x, y, result;

            x = int.Parse(tb_X.Text);
            y = int.Parse(tb_Y.Text);
            result = x * y;
            tb_RES.Text = result + "";
        }

        private void BTN_XX(object sender, RoutedEventArgs e)
        {
            int x, result;

            x = int.Parse(tb_X.Text);
            result = x * x;
            tb_RES.Text = result + "";
        }

        private void XPwrY(object sender, RoutedEventArgs e)
        {
            double x, y, result;

            x = double.Parse(tb_X.Text);
            y = double.Parse(tb_Y.Text);
            result = Math.Pow(x, y);
            tb_RES.Text = result + "";
        }

  

        private void BTN_sqrt(object sender, RoutedEventArgs e)
        {
            double x, result;

            x = double.Parse(tb_X.Text);
            result = Math.Sqrt(x);
            tb_RES.Text = result + "";
        }

        private void BTN_Cos(object sender, RoutedEventArgs e)
        {
            double x, result;

            x = double.Parse(tb_X.Text);
            result = Math.Cos(x*Math.PI/180.0);
            tb_RES.Text = result + "";
        }

        private void BTN_Sin(object sender, RoutedEventArgs e)
        {
            double x, result;

            x = double.Parse(tb_X.Text);
            result = Math.Sin(x * Math.PI / 180.0);
            tb_RES.Text = result + "";
        }

        private void BTN_recipr(object sender, RoutedEventArgs e)
        {
            double x, result;

            x = int.Parse(tb_X.Text);
            result = 1 / x;
            tb_RES.Text = result + "";
        }
    }
}

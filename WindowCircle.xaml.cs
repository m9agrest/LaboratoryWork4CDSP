using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LaboratoryWork4CDSP
{
    /// <summary>
    /// Логика взаимодействия для WindowCircle.xaml
    /// </summary>
    public partial class WindowCircle : Window
    {
        Circle Circle;
        public WindowCircle(Circle circle)
        {
            InitializeComponent();
            Circle = circle;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x, y, r;
            if(
                double.TryParse(X.Text, out x) && 
                double.TryParse(Y.Text, out y) && 
                double.TryParse(R.Text, out r))
            {
                Circle.X = x;
                Circle.Y = y;
                Circle.R = r;
                Close();
            }
            else
            {
                LabelError.Visibility = Visibility.Visible;
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e) => Close();

        private void TextChanged(object sender, TextChangedEventArgs e) => LabelError.Visibility = Visibility.Hidden;
    }
}

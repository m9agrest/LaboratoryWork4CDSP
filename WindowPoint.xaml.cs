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
using System.Windows.Shapes;

namespace LaboratoryWork4CDSP
{
    public partial class WindowPoint : Window
    {
        Point Point;
        public WindowPoint(Point point)
        {
            InitializeComponent();
            Point = point;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x, y;
            if (
                double.TryParse(X.Text, out x) &&
                double.TryParse(Y.Text, out y))
            {
                Point.X = x;
                Point.Y = y;
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

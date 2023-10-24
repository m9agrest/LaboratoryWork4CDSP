using System.Windows;
using System.Windows.Controls;

namespace LaboratoryWork4CDSP
{
    public partial class WindowPoint : Window
    {
        Point Point;
        public WindowPoint(Point point)
        {
            InitializeComponent();
            Point = point;
            X.Text = Point.X.ToString();
            Y.Text = Point.Y.ToString();
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

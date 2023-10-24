using System.Windows;
using System.Windows.Controls;

namespace LaboratoryWork4CDSP
{
    public partial class WindowCircle : Window
    {
        Circle Circle;
        public WindowCircle(Circle circle)
        {
            InitializeComponent();
            Circle = circle;
            X.Text = Circle.X.ToString();
            Y.Text = Circle.Y.ToString();
            R.Text = Circle.R.ToString();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            double x, y, r;
            if(
                double.TryParse(X.Text, out x) && 
                double.TryParse(Y.Text, out y) && 
                double.TryParse(R.Text, out r) && 
                r > 0)
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

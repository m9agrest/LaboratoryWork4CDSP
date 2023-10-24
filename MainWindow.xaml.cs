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
using System.Windows.Media.Media3D;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LaboratoryWork4CDSP
{
    public partial class MainWindow : Window
    {
        Circle Circle1 = new Circle(-25, 30, 25);
        Circle Circle2 = new Circle(35, 35, 10);
        Point Point = new Point(10, 25);

        public MainWindow()
        {
            InitializeComponent();
            UpdateInfo();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window w = new WindowPoint(Point);
            w.ShowDialog();
            UpdateInfo();
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window w = new WindowCircle(Circle1);
            w.ShowDialog();
            UpdateInfo();
        }
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window w = new WindowCircle(Circle2);
            w.ShowDialog();
            UpdateInfo();
        }
        void UpdateInfo()
        {
            if(Circle1.isBorder(Point))
            {
                Info1.Content = "Точка находится на границе круга 1";
            }
            else if(Circle1.isInside(Point))
            {
                Info1.Content = "Точка находится внутри круга 1";
            }
            else
            {
                Info1.Content = "Точка находится вне круга 1";
            }


            if (Circle2.isBorder(Point))
            {
                Info2.Content = "Точка находится на границе круга 2";
            }
            else if (Circle2.isInside(Point))
            {
                Info2.Content = "Точка находится внутри круга 2";
            }
            else
            {
                Info2.Content = "Точка находится вне круга 2";
            }

            canvas.Children.Clear();
            Ellipse ellipse1 = new Ellipse();
            ellipse1.Width = ellipse1.Height = Circle1.R * 2;
            ellipse1.Fill = Brushes.Green;
            canvas.Children.Add(ellipse1);
            Canvas.SetLeft(ellipse1, Circle1.X + Width / 2 - Circle1.R);
            Canvas.SetTop(ellipse1, Circle1.Y + Height / 2 - Circle1.R);

            Ellipse ellipse2 = new Ellipse();
            ellipse2.Width = ellipse2.Height = Circle2.R * 2;
            ellipse2.Fill = Brushes.Red;
            canvas.Children.Add(ellipse2);
            Canvas.SetLeft(ellipse2, Circle2.X + Width / 2 - Circle2.R);
            Canvas.SetTop(ellipse2, Circle2.Y + Height / 2 - Circle2.R);

            Ellipse ellipse3 = new Ellipse();
            ellipse3.Width = ellipse3.Height = 10;
            ellipse3.Fill = Brushes.Black;
            canvas.Children.Add(ellipse3);
            Canvas.SetLeft(ellipse3, Point.X + Width / 2 - 5);
            Canvas.SetTop(ellipse3, Point.Y + Height / 2 - 5);


        }
    }
}

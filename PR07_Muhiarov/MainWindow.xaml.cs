using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace PR07_Muhiarov
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public static int p = 3;
        public MainWindow()
        {
            InitializeComponent();
            lb.Content = "3";
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            p++;
            lb.Content = p;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            p--;
            lb.Content = p;
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            grid1.Children.Clear();
            Create(-1);
        }
        public void Create(int i)
        {
            if (i < p)
            {
                Rectangle rectangle = new Rectangle();
                rectangle.Stroke = Brushes.Gold;
                if (i == -1)
                {
                    rectangle.Width = 30;
                    rectangle.Height = 25;
                    rectangle.Margin = new Thickness(-518, (400 - p * 50), 0, 0);
                    rectangle.Fill = Brushes.Gold;
                    grid1.Children.Add(rectangle);
                    i++;
                    Create(i);
                }
                else
                {
                    rectangle.Width = i * 50;
                    rectangle.Height = 25;
                    rectangle.Margin = new Thickness(-518, (400 - p * 50) + i * 50, 0, 0);
                    rectangle.Fill = Brushes.Gold;
                    grid1.Children.Add(rectangle);
                    i++;
                    Create(i);
                }
            }
        }
        public void Moving()
        {
            if (grid1.Children[0].IsMouseCaptureWithin)
            {
                
            };
        }
    }
}

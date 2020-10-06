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

namespace Part1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int speed = Int32.Parse(speedText.Text);
            int speedLimit = Int32.Parse(speedLimitText.Text);
            
            if (speed <= speedLimit)
            {
                statusText.Text = "Legal speed";
                statusCanvas.Background = Brushes.Green;
            }
            else if (speed <= speedLimit + 5)
            {
                statusText.Text = "Speeding no penalty";
                statusCanvas.Background = Brushes.Yellow;
            }
            else
            {
                statusText.Text = "Speeding penalty";
                statusCanvas.Background = Brushes.Red;
            }
        }
    }
}

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

namespace WeatherForecast
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var r = new DataWeather("Москва");
            lvWeather.ItemsSource = r.Data;
        }
        private void btnUpdate_Click(object sender, RoutedEventArgs e)
        {
            var r = new DataWeather(cbCity.Text);
            lvWeather.ItemsSource = r.Data;
        }
    }
}

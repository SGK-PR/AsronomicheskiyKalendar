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

namespace AsronomicheskiyKalendar.Forms
{
    /// <summary>
    /// Логика взаимодействия для MenuForm.xaml
    /// </summary>
    public partial class MenuForm : Window
    {
        public MenuForm()
        {
            InitializeComponent();
            this.Title = "Привет, гость";
        }

        private void btStarfalls_Click(object sender, RoutedEventArgs e)
        {
            Forms.StarfallsForm starfalls = new StarfallsForm();
            starfalls.Show();
            this.Close();
        }

        private void btMoonType_Click(object sender, RoutedEventArgs e)
        {
            Forms.MoonTypeForm moonType = new MoonTypeForm();
            moonType.Show();
            this.Close();
        }

        private void btEclipses_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btPlanet_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btLenghtDayNight_Click(object sender, RoutedEventArgs e)
        {

        }

        private void btAstronomicalObservation_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

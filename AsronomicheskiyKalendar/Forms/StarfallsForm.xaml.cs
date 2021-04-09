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
    /// Логика взаимодействия для StarfallsForm.xaml
    /// </summary>
    public partial class StarfallsForm : Window
    {
        public StarfallsForm()
        {
            InitializeComponent();
            DB.DashaEntities1 entities = new DB.DashaEntities1();
            mainGrid.ItemsSource = entities.Starfalls.ToList();

        }

        private void btHome_Click(object sender, RoutedEventArgs e)
        {
            Forms.MenuForm menuForm = new MenuForm();
            menuForm.Show();
            this.Close();
        }
    }
}

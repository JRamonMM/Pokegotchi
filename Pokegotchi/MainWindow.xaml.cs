using System;
using System.Collections.Generic;
using System.Linq;
using System.Media;
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

namespace Pokegotchi
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {

        SoundPlayer player = new SoundPlayer("pokegotchiIntro.wav");

        public MainWindow()
        {
            InitializeComponent();
            player.PlayLooping();
        }

        private void destacarBordes(object sender, MouseEventArgs e)
        {
            lblJugar.BorderThickness = new Thickness(4.0);
        }

        private void ocultarBordes(object sender, MouseEventArgs e)
        {
            lblJugar.BorderThickness = new Thickness(0.0);
        }

        private void btnQuieroJugarAhora(object sender, MouseButtonEventArgs e)
        {
            player.Stop();
            Avatar pikachu = new Avatar();
            pikachu.Show();
            Close();
        }
    }
}

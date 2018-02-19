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
using System.Windows.Shapes;

namespace Pokegotchi
{
    /// <summary>
    /// Lógica de interacción para Raichu.xaml
    /// </summary>
    public partial class Raichu : Window
    {
        SoundPlayer player = new SoundPlayer("pokegotchiWin.wav");

        public Raichu()
        {
            InitializeComponent();
            player.PlayLooping();
        }

        private void destacarBordes(object sender, MouseEventArgs e)
        {
            lblTerminar.BorderThickness = new Thickness(4.0);
        }

        private void ocultarBordes(object sender, MouseEventArgs e)
        {
            lblTerminar.BorderThickness = new Thickness(0.0);
        }

        private void terminar(object sender, MouseButtonEventArgs e)
        {
            Close();
        }
    }
}

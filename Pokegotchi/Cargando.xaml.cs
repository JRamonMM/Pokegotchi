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
using System.Windows.Threading;

namespace Pokegotchi
{
    /// <summary>
    /// Lógica de interacción para Cargando.xaml
    /// </summary>
    public partial class Cargando : Window
    {

        private DispatcherTimer t1 = new DispatcherTimer();
        SoundPlayer player = new SoundPlayer("pokegotchiEvolucion.wav");

        public Cargando()
        {
            InitializeComponent();
            t1.Interval = TimeSpan.FromSeconds(1.0);
            t1.Tick += new EventHandler(timer);
            t1.Start();
            player.PlayLooping();
        }

        private void timer(object sender, EventArgs e)
        {
            pbLoad.Value += 10;
            if (pbLoad.Value == 100)
            {
                t1.Stop();
                player.Stop();
                Raichu r = new Raichu();
                r.Show();
                Close();
            }
        }
    }
}

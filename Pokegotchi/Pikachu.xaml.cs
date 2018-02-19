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
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using System.Windows.Threading;

namespace Pokegotchi
{
    /// <summary>
    /// Lógica de interacción para Pikachu.xaml
    /// </summary>
    public partial class Avatar : Window
    {

        Avatar_Pikachu pikachu = new Avatar_Pikachu(100, 100, 100, 0, 1);
        private DispatcherTimer t1 = new DispatcherTimer();
        SoundPlayer player = new SoundPlayer("pokegotchiTheme.wav");

        public Avatar()
        {
            InitializeComponent();
            player.PlayLooping();
            t1.Interval = TimeSpan.FromSeconds(1.0);
            t1.Tick += new EventHandler(timer);
            t1.Start();
        }

        private void timer(object sender, EventArgs e)
        {
            lblLvlUp.Visibility = System.Windows.Visibility.Hidden;
            Random r = new Random();
            pikachu.Energia -= r.Next(15);
            pbEnergia.Value = pikachu.Energia;
            pikachu.Apetito -= r.Next(15);
            pbApetito.Value = pikachu.Apetito;
            pikachu.Diversion -= r.Next(15);
            pbDiversion.Value = pikachu.Diversion;
            if (pikachu.Energia > 50 && pikachu.Apetito > 50 && pikachu.Diversion > 50)
                pikachu.Felicidad += 2;
            pbEvolucionar.Value = pikachu.Felicidad;
            accionesSueño();
            accionesHambre();
            accionesAburrido();
            morir();
            subirNivel();
            evolucionar();
        }

        private void accionesSueño()
        {
            Storyboard cerrarOjoIzq = (Storyboard)this.ojoIzquierdo.Resources["cerrarOjoIzqKey"];
            Storyboard cerrarPupilaIzq = (Storyboard)this.pupilaIzquierda.Resources["cerrarPupilaIzqKey"];
            Storyboard cerrarOjoDer = (Storyboard)this.ojoDerecho.Resources["cerrarOjoDerKey"];
            Storyboard cerrarPupilaDer = (Storyboard)this.pupilaDerecha.Resources["cerrarPupilaDerKey"];
            Storyboard abrirOjoIzq = (Storyboard)this.ojoIzquierdo.Resources["abrirOjoIzqKey"];
            Storyboard abrirPupilaIzq = (Storyboard)this.ojoDerecho.Resources["abrirOjoDerKey"];
            Storyboard abrirOjoDer = (Storyboard)this.pupilaIzquierda.Resources["abrirPupilaIzqKey"];
            Storyboard abrirPupilaDer = (Storyboard)this.pupilaDerecha.Resources["abrirPupilaDerKey"];
            if(pbEnergia.Value < 30)
            {
                cerrarOjoIzq.Begin();
                cerrarPupilaIzq.Begin();
                cerrarOjoDer.Begin();
                cerrarPupilaDer.Begin();
                lblZ.Visibility = System.Windows.Visibility.Visible;
                if(pikachu.Felicidad >= 0)
                    pikachu.Felicidad -= 2;
            }else
            {
                abrirOjoIzq.Begin();
                abrirPupilaIzq.Begin();
                abrirOjoDer.Begin();
                abrirPupilaDer.Begin();
                lblZ.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void accionesHambre()
        {
            if (pbApetito.Value < 30)
            {
                pensamientoHambre.Visibility = System.Windows.Visibility.Visible;
                lblBurger.Visibility = System.Windows.Visibility.Visible;
                if (pikachu.Felicidad >= 0)
                    pikachu.Felicidad -= 2;
            }
            else
            {
                pensamientoHambre.Visibility = System.Windows.Visibility.Hidden;
                lblBurger.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void accionesAburrido()
        {
            if (pbDiversion.Value < 30)
            {
                pensamientoJugar.Visibility = System.Windows.Visibility.Visible;
                lblAburrido.Visibility = System.Windows.Visibility.Visible;
                if (pikachu.Felicidad >= 0)
                    pikachu.Felicidad -= 2;
            }
            else
            {
                pensamientoJugar.Visibility = System.Windows.Visibility.Hidden;
                lblAburrido.Visibility = System.Windows.Visibility.Hidden;
            }
        }

        private void subirNivel()
        {
            if(pikachu.Felicidad == 20)
            {
                pikachu.Nivel++;
                lblLvlUp.Visibility = System.Windows.Visibility.Visible;
                lblNv1.Visibility = System.Windows.Visibility.Hidden;
                lblNv2.Visibility = System.Windows.Visibility.Visible;
                lblNv3.Visibility = System.Windows.Visibility.Hidden;
                lblNv4.Visibility = System.Windows.Visibility.Hidden;
                lblNv5.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (pikachu.Felicidad == 40)
            {
                pikachu.Nivel++;
                lblLvlUp.Visibility = System.Windows.Visibility.Visible;
                lblNv1.Visibility = System.Windows.Visibility.Hidden;
                lblNv2.Visibility = System.Windows.Visibility.Hidden;
                lblNv3.Visibility = System.Windows.Visibility.Visible;
                lblNv4.Visibility = System.Windows.Visibility.Hidden;
                lblNv5.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (pikachu.Felicidad == 60)
            {
                pikachu.Nivel++;
                lblLvlUp.Visibility = System.Windows.Visibility.Visible;
                lblNv1.Visibility = System.Windows.Visibility.Hidden;
                lblNv2.Visibility = System.Windows.Visibility.Hidden;
                lblNv3.Visibility = System.Windows.Visibility.Hidden;
                lblNv4.Visibility = System.Windows.Visibility.Visible;
                lblNv5.Visibility = System.Windows.Visibility.Hidden;
            }
            else if (pikachu.Felicidad == 80)
            {
                pikachu.Nivel++;
                lblLvlUp.Visibility = System.Windows.Visibility.Visible;
                lblNv1.Visibility = System.Windows.Visibility.Hidden;
                lblNv2.Visibility = System.Windows.Visibility.Hidden;
                lblNv3.Visibility = System.Windows.Visibility.Hidden;
                lblNv4.Visibility = System.Windows.Visibility.Hidden;
                lblNv5.Visibility = System.Windows.Visibility.Visible;
            }
        }

        private void evolucionar()
        {
            if(pikachu.Felicidad >= 100)
            {
                t1.Stop();
                player.Stop();
                if (MessageBox.Show("Pikachu ha alcanzado el nivel maximo de felicidad y va a evolucionar", "¡Enhorabuena!", MessageBoxButton.OK, MessageBoxImage.Information) == MessageBoxResult.OK)
                {
                    player.Stop();
                    Cargando c = new Cargando();
                    c.Show();
                    Close();
                }
            }
        }

        private void destacarBordesDormir(object sender, MouseEventArgs e)
        {
            lblDormir.BorderThickness = new Thickness(2.0);
        }

        private void ocultarBordesDormir(object sender, MouseEventArgs e)
        {
            lblDormir.BorderThickness = new Thickness(0.0);
        }

        private void destacarBordesComer(object sender, MouseEventArgs e)
        {
            lblComer.BorderThickness = new Thickness(2.0);
        }

        private void ocultarBordesComer(object sender, MouseEventArgs e)
        {
            lblComer.BorderThickness = new Thickness(0.0);
        }

        private void destacarBordesJugar(object sender, MouseEventArgs e)
        {
            lblJugar.BorderThickness = new Thickness(2.0);
        }

        private void ocultarBordesJugar(object sender, MouseEventArgs e)
        {
            lblJugar.BorderThickness = new Thickness(0.0);
        }

        private void dormir(object sender, MouseButtonEventArgs e)
        {
            Random r = new Random();
            if(pikachu.Energia <= 100)
                pikachu.Energia += r.Next(15);
            pbEnergia.Value = pikachu.Energia;
        }

        private void comer(object sender, MouseButtonEventArgs e)
        {
            Random r = new Random();
            if(pikachu.Apetito <= 100)
                pikachu.Apetito += r.Next(15);
            pbApetito.Value = pikachu.Apetito;
        }

        private void jugar(object sender, MouseButtonEventArgs e)
        {
            Random r = new Random();
            if(pikachu.Diversion <= 100)
                pikachu.Diversion += r.Next(15);
            pbDiversion.Value = pikachu.Diversion;
        }

        private void morir()
        {
            if(pikachu.Energia <= 0 || pikachu.Apetito <= 0 || pikachu.Diversion <= 0)
            {
                t1.Stop();
                player.Stop();
                if (MessageBox.Show("Pikachu ha muerto debido a que alguna de sus caracteristicas vitales ha llegado a 0.", "Esto es embarazoso...", MessageBoxButton.OK, MessageBoxImage.Error) == MessageBoxResult.OK)
                {
                    GameOver g = new GameOver();
                    g.Show();
                    Close();
                }
            }
        }
    }
}

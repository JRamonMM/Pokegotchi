using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pokegotchi
{
    class Avatar_Pikachu
    {
        int energia;
        int apetito;
        int diversion;
        int felicidad;
        int nivel;

        public Avatar_Pikachu(int e, int a, int d, int f, int n)
        {
            energia = e;
            apetito = a;
            Diversion = d;
            Felicidad = f;
        }

        public int Energia
        {
            get
            {
                return energia;
            }
            set
            {
                energia = value;
            }
        }

        public int Apetito
        {
            get
            {
                return apetito;
            }
            set
            {
                apetito = value;
            }
        }

        public int Diversion
        {
            get
            {
                return diversion;
            }

            set
            {
                diversion = value;
            }
        }

        public int Felicidad
        {
            get
            {
                return felicidad;
            }

            set
            {
                felicidad = value;
            }
        }

        public int Nivel
        {
            get
            {
                return nivel;
            }

            set
            {
                nivel = value;
            }
        }
    }
}

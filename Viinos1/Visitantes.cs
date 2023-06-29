using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinos1;

namespace Vinos1
{
    internal class Visitantes
    {


        private Visitante[] t_Visitantes;
        private int _limite;
        private Random _rnd;
        private int _numVisitantes;


        public Visitantes(int limite)
        {
            this.t_Visitantes = new Visitante[limite];
            _limite = limite;
            _numVisitantes = 0;
            _rnd = new Random();

        }


        public Visitante sortearVisitantes()
        {

            return (t_Visitantes[_rnd.Next(_numVisitantes)]);

        }



        public void sumarCantvisitantes()
        {

            _numVisitantes++;

        }
        public void restarCantVisitasntes()
        {

            _numVisitantes--;

        }

        public void mostrarVisitntea()
        {
            Visitante pGanado = sortearVisitantes();
            System.Console.WriteLine(pGanado.ToString());

        }

        public void aniadirVisitante(Visitante vis)
        {
            if (vis != null && _numVisitantes < t_Visitantes.Length)
            {
                t_Visitantes[_numVisitantes] = vis;
                _numVisitantes++;
            }
        }

        public void mostrarVisitantes()
        {
            for (int i = 0; i < _numVisitantes; i++)
            {
                Console.WriteLine(t_Visitantes[i].ToString());
            }
        }

        public void vaciarVisitante()
        {
            this.t_Visitantes = new Visitante[_limite];
            _numVisitantes = 0;
        }

        public void eliminarVisitante(Visitante v)
        {
            if (v != null && _numVisitantes != 0)
            {

                int posicion = -1;
                for (int i = 0; i < _numVisitantes; i++)
                {
                    if (v.CodigoReserva == t_Visitantes[i].CodigoReserva)
                    {
                        posicion = i;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("No existe el palabra");
                }
                else
                {
                    t_Visitantes[posicion] = null;

                    for (int i = posicion; i < _numVisitantes; i++)
                    {
                        t_Visitantes[i] = t_Visitantes[i + 1];

                    }
                    t_Visitantes[_numVisitantes] = null;
                    _numVisitantes--;

                }

            }
        }
        public Visitante buscarVisitante(int codVisita)
        {
            if (_numVisitantes != 0)
            {

                int posicion = -1;
                for (int i = 0; i < _numVisitantes; i++)
                {
                    if (codVisita == t_Visitantes[i].CodigoReserva)
                    {
                        posicion = i;
                    }
                }

                if (posicion == -1)
                {
                    Console.WriteLine("No existe el palabra");
                    return null;
                }
                else
                {
                    return (t_Visitantes[posicion]);


                }

            }
            else
            {//No hay palabras en el array de palabras

                return null;

            }
        }

    }
}

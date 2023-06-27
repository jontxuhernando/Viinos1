using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinos1;

namespace Vinos1
{
    internal class Visitas
    {



        private Visita[] t_Visitas;
        private int _limite;
        private Random _rnd;
        private int _numVisitas;
                  

        public Visitas(int limite)
        {
            this.t_Visitas = new Visita[limite];
            _limite = limite;
            _numVisitas = 0;
            _rnd = new Random();

        }


        public Visita sortearVisita()
        {

            return (t_Visitas[_rnd.Next(_numVisitas)]);

        }



        public void sumarCantPalabras()
        {

            _numVisitas++;

        }
        public void restarCantVisitass()
        {

            _numVisitas--;

        }

        public void mostrarVisita()
        {
            Visita pGanado = sortearVisita();
            System.Console.WriteLine(pGanado.ToString());

        }

        public void aniadirVisita(Visita v)
        {
            if (v != null && _numVisitas < t_Visitas.Length)
            {
                t_Visitas[_numVisitas] = v;
                _numVisitas++;
            }
        }

        public void mostrarVisitas()
        {
            for (int i = 0; i < _numVisitas; i++)
            {
                Console.WriteLine(t_Visitas[i].ToString());
            }
        }

        public void vaciarVisitas()
        {
            this.t_Visitas = new Visita[_limite];
            _numVisitas = 0;
        }

        public void eliminaVisita(Visita v)
        {
            if (v != null && _numVisitas != 0)
            {

                int posicion = -1;
                for (int i = 0; i < _numVisitas; i++)
                {
                    if (v.CodVisita == t_Visitas[i].CodVisita)
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
                    t_Visitas[posicion] = null;

                    for (int i = posicion; i < _numVisitas; i++)
                    {
                        t_Visitas[i] = t_Visitas[i + 1];

                    }
                    t_Visitas[_numVisitas] = null;
                    _numVisitas--;

                }

            }
        }
        public Visita buscarVisita(int codVisita)
        {
            if (_numVisitas != 0)
            {

                int posicion = -1;
                for (int i = 0; i < _numVisitas; i++)
                {
                    if (codVisita == t_Visitas[i].CodVisita)
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
                    return (t_Visitas[posicion]);


                }

            }
            else
            {//No hay palabras en el array de palabras

                return null;

            }
        }


    }
}

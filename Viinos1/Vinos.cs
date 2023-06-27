using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vinos1
{
     public class Vinos
    {
        private Vino[] _tVinos;
        private int _limite;
        private Random _rnd;
        private int _numVinos;


        public Vinos(int limite)
        {
            this._tVinos= new Vino[limite];
            _limite = limite;
            _numVinos   = 0;    
            _rnd= new Random(); 

        }


        public void sumarCantVinos()
        {

            _numVinos++;

        }
        public void restarCantPalabras()
        {

            _numVinos--;

        }


        public Vino sortearVino()
        {

            return (_tVinos[_rnd.Next(_numVinos)]);

        }

            public void mostrarVino()
        {
            Vino pGanado = sortearVino();
            System.Console.WriteLine(pGanado.ToString());

        }

        public void aniadirVino(Vino vp)
        {
            if (vp != null && _numVinos < _tVinos.Length)
            {
                _tVinos[_numVinos] = vp;
                _numVinos++;
            }
        }

        public void mostrarVinos()
        {
            for (int i = 0; i < _numVinos; i++)
            {
                Console.WriteLine(_tVinos[i].ToString());
            }
        }

        public void vaciarVino()
        {
            this._tVinos = new Vino[_limite];
            _numVinos = 0;
        }

        public void eliminarVino(Vino vi)
        {
            if (vi != null && _numVinos != 0)
            {

                int posicion = -1;
                for (int i = 0; i < _numVinos; i++)
                {
                    if (vi.CodVino == _tVinos[i].CodVino)
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
                    _tVinos[posicion] = null;

                    for (int i = posicion; i < _numVinos; i++)
                    {
                        _tVinos[i] = _tVinos[i + 1];

                    }
                    _tVinos[_numVinos] = null;
                    _numVinos--;

                }

            }
        }
        public Vino buscarVino(int id)
        {
            if (_numVinos != 0)
            {

                int posicion = -1;
                for (int i = 0; i < _numVinos; i++)
                {
                    if (id == _tVinos[i].CodVino)
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
                    return (_tVinos[posicion]);


                }

            }
            else
            {//No hay palabras en el array de palabras

                return null;

            }
        }


    }
}

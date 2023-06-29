using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinos1;

namespace Vinos1
{
    internal class Clientes
    {


        private Cliente[] _tClientes;
        private int _limite;
        private Random _rnd;
        private int _numClientes;


        public Clientes(int limite)
        {
            this._tClientes = new Cliente[limite];
            _limite = limite;
            _numClientes = 0;
            _rnd = new Random();

        }


        public Cliente sortearCliente()
        {

            return (_tClientes[_rnd.Next(_numClientes)]);

        }



        public void sumarCantPalabras()
        {

            _numClientes++;

        }
        public void restarCantClientes()
        {

            _numClientes--;

        }

        public void mostrarCliente()
        {
            Cliente pGanado = sortearCliente();
            System.Console.WriteLine(pGanado.ToString());

        }

        public void aniadirCliente(Cliente c)
        {
            if (c != null && _numClientes < _tClientes.Length)
            {
                _tClientes[_numClientes] = c;
                _numClientes++;
            }
        }

        public void mostrarClientes()
        {
            for (int i = 0; i < _numClientes; i++)
            {
                Console.WriteLine(_tClientes[i].ToString());
            }
        }

        public void vaciarClientes()
        {
            this._tClientes = new Cliente[_limite];
            _numClientes = 0;
        }

        public void eliminarCliente(Cliente c)
        {
            if (c != null && _numClientes != 0)
            {

                int posicion = -1;
                for (int i = 0; i < _numClientes; i++)
                {
                    if (c.NifCliente == _tClientes[i].NifCliente)
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
                    _tClientes[posicion] = null;

                    for (int i = posicion; i < _numClientes; i++)
                    {
                        _tClientes[i] = _tClientes[i + 1];

                    }
                    _tClientes[_numClientes] = null;
                    _numClientes--;

                }

            }
        }
        public Cliente buscarCliente(int nif)
        {
            if (_numClientes != 0)
            {

                int posicion = -1;
                for (int i = 0; i < _numClientes; i++)
                {
                    if (nif == _tClientes[i].NifCliente)
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
                    return (_tClientes[posicion]);


                }

            }
            else
            {//No hay palabras en el array de palabras

                return null;

            }
        }



    }
}

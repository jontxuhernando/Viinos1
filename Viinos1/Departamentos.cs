using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Vinos1;

namespace Viinos1
{
    internal class Departamentos
    {



        private Departamento[] _tDepartamentos;
        private int _limite;
        private Random _rnd;
        private int _numDepartamentos;


        public Departamentos(int limite)
        {
            this._tDepartamentos = new Departamento[limite];
            _limite = limite;
            _numDepartamentos = 0;
            _rnd = new Random();

        }


        public Departamento sortearDepartamentos()
        {

            return (_tDepartamentos[_rnd.Next(_numDepartamentos)]);

        }



        public void sumarCantDepartamentos()
        {

            _numDepartamentos++;

        }
        public void restarCantDepartamentos()
        {

            _numDepartamentos--;

        }

        public void mostrarDepartamento()
        {
            Departamento pGanado = sortearDepartamentos();
            System.Console.WriteLine(pGanado.ToString());

        }

        public void aniadirDepartamento(Departamento d)
        {
            if (d != null && _numDepartamentos < _tDepartamentos.Length)
            {
                _tDepartamentos[_numDepartamentos] = d;
                _numDepartamentos++;
            }
        }

        public void mostrarDepartameto()
        {
            for (int i = 0; i < _numDepartamentos; i++)
            {
                Console.WriteLine(_tDepartamentos[i].ToString());
            }
        }

        public void vaciarDepartamentos()
        {
            this._tDepartamentos = new Departamento[_limite];
            _numDepartamentos = 0;
        }

        public void eliminarDepartamento(Departamento d)
        {
            if (d != null && _numDepartamentos != 0)
            {

                int posicion = -1;
                for (int i = 0; i < _numDepartamentos; i++)
                {
                    if (d.CodDepartamento == _tDepartamentos[i].CodDepartamento)
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
                    _tDepartamentos[posicion] = null;

                    for (int i = posicion; i < _numDepartamentos; i++)
                    {
                        _tDepartamentos[i] = _tDepartamentos[i + 1];

                    }
                    _tDepartamentos[_numDepartamentos] = null;
                    _numDepartamentos--;

                }

            }
        }
        public Departamento buscarDepartamento(int cod)
        {
            if (_numDepartamentos != 0)
            {

                int posicion = -1;
                for (int i = 0; i < _numDepartamentos; i++)
                {
                    if (cod == _tDepartamentos[i].CodDepartamento)
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
                    return (_tDepartamentos[posicion]);


                }

            }
            else
            {//No hay palabras en el array de palabras

                return null;

            }
        }



    }
}

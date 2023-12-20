using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_POO
{
    public class Persona
    {
        private string _nombre;
        private string _apellido;
        private int _edad;
        private string _direccion;
        private string _genero;

        public string Nombre
        {
            get { return _nombre; }
            set { _nombre = value; }
        }
        public string Apellido
        {
            get { return _apellido; }
            set { _apellido = value; }
        }
        public int Edad
        {
            get { return _edad; }
            set { _edad = value; }
        }
        public string Direccion
        {
            get { return _direccion; }
            set { _direccion = value; }
        }
        public string Genero
        {
            get { return _genero; }
            set { _genero = value; }
        }
    }
}

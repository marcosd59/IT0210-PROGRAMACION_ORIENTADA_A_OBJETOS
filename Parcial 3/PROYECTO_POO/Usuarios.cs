using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_POO
{
    internal class Usuarios
    {
        private string _usuario;
        private string _contrasena;

        public string Usuario
        {
            get { return _usuario; }
            set { _usuario = value; }
        }
        public string Contrasena
        {
            get { return _contrasena; }
            set { _contrasena = value; }
        }
    }
}

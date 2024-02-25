using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_POO
{
    internal class ObjCliente
    {
        private int _id;
        private string _nombreCliente;
        private string _apellidoCliente;
        private string _telefonoCliente;
        private string _correoCliente;

        public int Id
        {
            get { return _id; }
            set { _id = value;}
        }
        public string NombreCliente
        {
            get { return _nombreCliente; }
            set { _nombreCliente = value; }
        }
        public string ApellidoCliente
        {
            get { return _apellidoCliente;}
            set { _apellidoCliente = value;}
        }
        public string TelefonoCliente
        {
            get { return _telefonoCliente;}
            set { _telefonoCliente = value;}
        }
        public string CorreoCliente
        {
            get { return _correoCliente;}
            set { _correoCliente = value;}
        }
    }
}

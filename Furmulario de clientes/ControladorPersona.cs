using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace PROYECTO_POO
{
    public class ControladorPersona
    {
        private List<Persona> ListadoPersona;
        public ControladorPersona()
        {
            ListadoPersona = new List<Persona>();
        }

        public void AdicionarPersona(Persona persona)
        {
            ListadoPersona.Add(persona);
        }

        public List<Persona> listadoPersona() 
        {
            return ListadoPersona;
        }

        public void BorrarPersona(Persona persona) 
        {
            ListadoPersona.Remove(persona);
        }
    }
}

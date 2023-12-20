using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_POO
{
    public partial class ListaClientes : Form
    {
        private List<Persona> ListadoPersona;
        public ListaClientes()
        {
            InitializeComponent();
            ListadoPersona= new List<Persona>();
        }

        public List<Persona> ListadoPersonas
        {
            get { return ListadoPersona; }
            set { ListadoPersona = value; }
        }

        private void ListaClientes_Load(object sender, EventArgs e)
        {
            foreach(Persona persona in ListadoPersona)
            {
                int n = dataGridViewPersona.Rows.Add();
                dataGridViewPersona.Rows[n].Cells[0].Value = persona.Nombre;
                dataGridViewPersona.Rows[n].Cells[1].Value = persona.Apellido;
                dataGridViewPersona.Rows[n].Cells[2].Value = persona.Edad;
                dataGridViewPersona.Rows[n].Cells[3].Value = persona.Direccion;
                dataGridViewPersona.Rows[n].Cells[4].Value = persona.Genero;
            }
        }

        private void button5Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

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
    public partial class Informacion : Form
    {
        private Persona pers;
        public Informacion()
        {
            InitializeComponent();
            pers = new Persona();
        }

        public Persona Pers
        {
            get { return pers; }
            set { pers = value; }
        }

        private void Informacion_Load(object sender, EventArgs e)
        {
            label6Nombre.Text = pers.Nombre;
            label7Apellido.Text = pers.Apellido;
            label8Edad.Text = Convert.ToString(pers.Edad);
            label9Dirreccion.Text = pers.Direccion;
            label10Genero.Text = pers.Genero;
        }

        private void button5Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

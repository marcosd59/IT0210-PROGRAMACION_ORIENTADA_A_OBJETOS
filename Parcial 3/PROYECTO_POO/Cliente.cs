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
    public partial class Cliente : Form
    {
        public Cliente()
        {
            InitializeComponent();
            cp = new ControladorPersona();
            perso = new Persona();
            ListadoPersona = new List<Persona>();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Cliente_Load(object sender, EventArgs e)
        {

        }

        private ControladorPersona cp;
        private Persona perso;
        private List<Persona> ListadoPersona;

        private void button1Insertar_Click(object sender, EventArgs e)
        {
            Persona persona = new Persona();
            persona.Nombre = textBox1Nombre.Text;
            persona.Apellido = textBox2Apellido.Text;
            persona.Edad = int.Parse(textBox3Edad.Text);
            persona.Direccion = textBox5Dirreccion.Text;
            persona.Genero = Convert.ToString(comboBox1Genero.Items[comboBox1Genero.SelectedIndex]);

            perso = persona;
            cp.AdicionarPersona(persona);
            ListadoPersona = cp.listadoPersona();

            MessageBox.Show("Bienvenido al sistema " + textBox1Nombre.Text + " " + textBox2Apellido.Text);
        }

        private void button2Limpiar_Click(object sender, EventArgs e)
        {
            textBox1Nombre.Text = " ";
            textBox2Apellido.Text = " ";
            textBox3Edad.Text = " ";
            textBox5Dirreccion.Text = " ";
            comboBox1Genero.Text= " ";
        }

        private void button5Salir_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3UActual_Click(object sender, EventArgs e)
        {
            Informacion pd = new Informacion();
            pd.Pers = perso;
            pd.Show();
        }

        private void button4ULista_Click(object sender, EventArgs e)
        {
            ListaClientes pp = new ListaClientes();
            pp.ListadoPersonas = this.ListadoPersona;
            pp.ShowDialog();
        }
    }
}

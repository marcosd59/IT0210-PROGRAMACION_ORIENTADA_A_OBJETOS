using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_POO
{
    public partial class Log : Form
    {
        public Log()
        {
            InitializeComponent();
        }

        private bool CargarUsuarios()
        {
            StreamReader r = new StreamReader("C:\\Users\\Marco\\source\\repos\\PROYECTO_POO\\database\\usuarios.json");
            string jsonString = r.ReadToEnd();
            List<Usuarios> Usuarioss  = JsonConvert.DeserializeObject<List<Usuarios>>(jsonString);

            foreach (var item in Usuarioss) 
            {
                if((textBoxUsuario.Text == item.Usuario) && textBoxContrasena.Text == item.Contrasena)
                {
                    return true;
                }
            }
            return false;
        }

        private void buttonLogin_Click(object sender, EventArgs e)
        {
            if(CargarUsuarios() == true)
             {
                frmBienvenida frmBienvenida = new frmBienvenida();
                frmBienvenida.Show();
                this.Hide();
            }
    
        }
    }
}

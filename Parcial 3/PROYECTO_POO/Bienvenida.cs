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
    public partial class frmBienvenida : Form
    {
        public frmBienvenida()
        {
            InitializeComponent();
            CargarClientes();
            CargarProductos();

            //cp = new ControladorPersona();
            //perso = new Persona();
            //ListadoPersona = new List<Persona>();
        }

        private void frmBienvenida_Load(object sender, EventArgs e)
        {

        }

        public void CargarClientes()
        {
            StreamReader r = new StreamReader("C:\\Users\\Marco\\source\\repos\\PROYECTO_POO\\database\\clientes.json");
            string jsonString = r.ReadToEnd();
            List<ObjCliente> objClientes = JsonConvert.DeserializeObject<List<ObjCliente>>(jsonString);

            DataTable dt = new DataTable();
            dt.Columns.Add("Id");
            dt.Columns.Add("Nombre");
            dt.Columns.Add("Apellido");
            dt.Columns.Add("Telefono");
            dt.Columns.Add("Correo");

            foreach (var item in objClientes)
            {
                DataRow row = dt.NewRow();
                row["Id"] = item.Id;
                row["Nombre"] = item.NombreCliente;
                row["Apellido"] = item.ApellidoCliente;
                row["Telefono"] = item.TelefonoCliente;
                row["Correo"] = item.CorreoCliente;

                dt.Rows.Add(row);
            }
            grdClientes.DataSource = dt;
        }

        public void CargarProductos()
        {
            StreamReader r1 = new StreamReader("C:\\Users\\Marco\\source\\repos\\PROYECTO_POO\\database\\productos.json");
            string jsonString = r1.ReadToEnd();
            List<ObjProducto> objProductos = JsonConvert.DeserializeObject<List<ObjProducto>>(jsonString);

            DataTable dt1 = new DataTable();
            dt1.Columns.Add("Id");
            dt1.Columns.Add("Producto");
            dt1.Columns.Add("Descripcion");
            dt1.Columns.Add("Precio");

            foreach (var item in objProductos)
            {
                DataRow row = dt1.NewRow();
                row["Id"] = item.Id;
                row["Producto"] = item.NombreProd;
                row["Descripcion"] = item.DescripcionProd;
                row["Precio"] = item.PrecioVenta;

                dt1.Rows.Add(row);
            }
            grdProductos.DataSource = dt1;
        }

        private void grdClientes_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        //private ControladorPersona cp;
        //private Persona perso;
        //private List<Persona> ListadoPersona;

        private void button1_Click(object sender, EventArgs e)
        {
            Cliente Cliente = new Cliente();
            Cliente.Show();
            this.Hide();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}

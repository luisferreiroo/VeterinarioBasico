using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace VeterinarioBasico
{
    public partial class VentanaLogin : Form
    {
        private MySqlConnection conexion;
        private static MySqlCommand comando;
        private String consulta;
        private MySqlDataReader resultado;
        private DataTable datos = new DataTable;
        public VentanaLogin()
        {
            InitializeComponent();
            conexion = new MySqlConnection("Server = 192.168.1.38; Database = test; Uid = root; Pwd =; Port = 3306");
            conexion.Open();

            comando = new MySqlCommand("SELECT * FROM veterinario", conexion);
            resultado = comando.ExecuteReader();
            datos.Load(resultado);
            conexion.Close();
            Dara
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nombre, contraseña;
            nombre = Usuario.Text;
            contraseña = Contraseña.Text;


        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}

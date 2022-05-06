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
        Conexion conexion = new Conexion();
        
        public VentanaLogin()
        {
            InitializeComponent();
            VentanaPrincipal v = new VentanaPrincipal();
            v.Show();

            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            String resultado = conexion.loginVeterinario(Usuario.Text, Contraseña.Text);
            MessageBox.Show(resultado);
            //VentanaPrincipal v = new VentanaPrincipal();
            //v.Show();

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void VentanaLogin_Load(object sender, EventArgs e)
        {

        }
    }
}

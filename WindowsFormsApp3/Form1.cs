using System.Data.SqlClient;

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PROYECTO_MAD;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace WindowsFormsApp3
{
    public partial class LOG_IN : Form
    {
        public LOG_IN()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void contrasena_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string correo = usuario.Text.Trim();
            string contraseña = contrasena.Text.Trim();

            using (SqlConnection conn = BDConexion.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM USUARIO WHERE correo = @correo AND contraseña = @contraseña";

                using (SqlCommand cmd = new SqlCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("@correo", correo);
                    cmd.Parameters.AddWithValue("@contraseña", contraseña);

                    int count = (int)cmd.ExecuteScalar();

                    if (count > 0)
                    {
                        MessageBox.Show("Inicio de sesión exitoso");
                        // Aquí podrías abrir otra ventana o mostrar un panel
                    }
                    else
                    {
                        MessageBox.Show("Correo o contraseña incorrectos");
                    }
                }
            }
        }

        private void usuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}

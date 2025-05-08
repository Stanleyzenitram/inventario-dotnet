using System;
using System.Data.SqlClient;
using System.Windows.Forms;
using utilidades;

namespace inventario
{
    public partial class login : Form
    {
        SqlConnection Conexion = new SqlConnection("Server=DESKTOP-DRS9K1M\\SQLEXPRESS;Database=inventario;Trusted_Connection=True;");


        public login()
        {
            InitializeComponent();

        }

        

        private void boton1_Click(object sender, EventArgs e)
        {

           
        }

        private void btnEntrar_Click(object sender, EventArgs e)
        {

            // conectar a sql validacion
            Conexion.Open();
            if (utilidad.ValidaForm(this, errorProvider1))
            {
                MessageBox.Show("Debe llenar todos los campos");
                Conexion.Close();
                return;
            }
            string clave = utilidad.Encriptar(txtClave.Text);

            string cmd = "select * from Usuarios where usuario = '" + txtUser.Text + "' and clave = '" + clave + "'";

            SqlCommand comando = new SqlCommand(cmd, Conexion);
            SqlDataReader lector;
            lector = comando.ExecuteReader();


            if (lector.HasRows == true)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
            else
            {
                MessageBox.Show("Usuario o contraseña incorrecta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Conexion.Close();

           
        }

        private void btnEntrar_MouseHover(object sender, EventArgs e)
        {
            
            Cursor = Cursors.Hand;
        }

        private void btnEntrar_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnSalir_MouseHover(object sender, EventArgs e)
        {
            Cursor = Cursors.Hand;
        }

        private void btnSalir_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }

        private void txtClave_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                DialogResult = DialogResult.OK;
                Close();
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                txtClave.UseSystemPasswordChar = true;
            }
            else {
                txtClave.UseSystemPasswordChar = false ;
            }

        }
    }
}

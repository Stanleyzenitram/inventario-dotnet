using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            
            if (string.IsNullOrEmpty(textBox1.Text.Trim())) // si esta vacio
            {
                MessageBox.Show("Debe indicar un numero");
                return;
            }

            int n = Convert.ToInt32(textBox1.Text.Trim());
            // 5/2 5/3 5/4

            int i = 0;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }

            if (i >= n)
                MessageBox.Show("Es primo");
            else
                MessageBox.Show("no es primo");

        }

        private void button3_Click(object sender, EventArgs e)
        {

            if (string.IsNullOrEmpty(textBox1.Text.Trim())) // si esta vacio
            {
                MessageBox.Show("Debe indicar un numero");
                return;
            }

            int n = Convert.ToInt32(textBox1.Text.Trim());


            if (utilidades.utilidad.Primo(n))
                MessageBox.Show("Es primo");
            else
                MessageBox.Show("no es primo");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim())) // si esta vacio
            {
                MessageBox.Show("Debe indicar un numero");
                return;
            }

            int n = Convert.ToInt32(textBox1.Text.Trim());
            if (utilidades.utilidad.Par(n))
                MessageBox.Show("Es par");
            else
                MessageBox.Show("no es par");
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int cp = 0, n = 0;
            richTextBox1.Text = "";

            while (cp < 100)
            {
                n++;
                if (utilidades.utilidad.Primo(n))
                {
                    cp++;
                    richTextBox1.Text += n.ToString() + "\t";
                }
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim())) // si esta vacio
            {
                MessageBox.Show("Debe indicar un numero");
                return;
            }


            Int64 n = Convert.ToInt64(textBox1.Text.Trim());

            richTextBox1.Text = utilidades.utilidad.ConvierteLetras(n);
            //MessageBox.Show(cn);
        }

        private void button7_Click(object sender, EventArgs e)
        {
           
            int[,] m = new int[5, 5];
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (f == c) m[f, c] = 1;// d. principal
                    else
                        if (f + c == 4) m[f, c] = 2; // d sec.
                    else
                    {
                        if (f < c)
                        {
                            if (f + c < 5)
                                m[f, c] = 3;
                            else
                                m[f, c] = 4;
                        }
                        else
                        {
                            if (f + c < 5)
                                m[f, c] = 6;
                            else
                                m[f, c] = 5;
                        }
                    }
                }
            }
            
            richTextBox1.Text = utilidades.utilidad.imprimatriz(m);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text.Trim())) // si esta vacio
            {
                MessageBox.Show("Debe indicar un numero");
                return;
            }


            Int64 n = Convert.ToInt64(textBox1.Text.Trim());
            richTextBox1.Text = utilidades.utilidad.ConvierteLetras(n);
            // convertir@el texto a un arreglo
            // quiniento cuarenta y dos 


            // c:\sonido\quiniento.wav
            // cuarenta 
            // y .wav y.wav
            // dos 


            string[] vletras = richTextBox1.Text.Split(' ');
            //WindowsMediaPlayer wplayer = new WindowsMediaPlayer();
            foreach (string item in vletras)
            {
                string archivo = @"c:\hidalsoft\audio\" + item.Trim() + ".wav";
                MessageBox.Show(archivo);
                if (System.IO.File.Exists(archivo))
                {
                    using (var soundPlayer = new SoundPlayer(archivo))
                    {
                        soundPlayer.Play(); // can also use soundPlayer.PlaySync()
                    }
                }
                
            }
            

        }

        private void button9_Click(object sender, EventArgs e)
        {
            int[,] m = new int[5, 5];
            int cp = 0;
            int s = 0;
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (f % 2 == 0)
                        m[f, c] = f - c;
                    else
                        m[f, c] = (f+1)* (f + 1);

                    if (f == c)
                        s += m[f, c]; // sumatoria dp
                    if (utilidades.utilidad.Primo(m[f, c]))
                        cp++; // cantidad de primo


                }
            }
            richTextBox1.Text = utilidades.utilidad.imprimatriz(m);

        }

        private void button10_Click(object sender, EventArgs e)
        {
            //pubnto i ,valor 3
            int cp=0;
            int[,] m = new int[5, 5];
            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    if (c % 2 == 0)
                        m[f, c] = f - c;
                    else
                        m[f, c] = (f + c )* (f + c);

                    if (utilidades.utilidad.Primo(m[f, c])) // punto 5 cantidad primo valor=2
                        cp++;
                }
            }
            richTextBox1.Text= utilidades.utilidad.imprimatriz(m);
            double x = Math.Pow(cp, m[1, 1]);

            textbox9.Text = cp.ToString();
            textBox1.Text = x.ToString();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            utilidades.utilidad.CreaArchivo("EscribeTexto.txt", richTextBox1.Text.Trim());

        }

        private void button12_Click(object sender, EventArgs e)
        {
            richTextBox1.Text=utilidades.utilidad.LeerArchivo(@"EscribeTexto.txt");
        }

        private void button13_Click(object sender, EventArgs e)
        {
  

            dataGridView1.DataSource = utilidades.utilidad.ejecuta("select * from clientes").Tables[0];
            dataGridView2.AutoGenerateColumns = false;
            dataGridView2.DataSource = utilidades.utilidad.ejecuta("select * from clientes").Tables[0];
        }

        private void button14_Click(object sender, EventArgs e)
        {
           
            // recorrido a la matriz de controles del formulario
            foreach (Control item in Controls)
            {
                if (item is utilidades.textbox)
                {
                    utilidades.textbox obj = (utilidades.textbox)item;
                    
                    
                    if (obj.Validar==true)
                    {
                        errorProvider1.SetError(obj, (string.IsNullOrEmpty(obj.Text.Trim())) ? "Campo obligatorio" : "");

                        /*
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                            errorProvider1.SetError(obj, "Campo obligatorio");
                        else
                            errorProvider1.SetError(obj, "");
                        */

                    }

                }
            }
        }

        private void button15_Click(object sender, EventArgs e)
        {
         
            if (utilidades.utilidad.ValidaForm(this, errorProvider1))
                MessageBox.Show("Hay errores");
            else
                MessageBox.Show("No hay errores");
        }

        private void button16_Click(object sender, EventArgs e)
        {
            FormBase obj = new FormBase();
            obj.Show();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            //ddddddd
            FormBase obj = new FormBase();
            obj.Show();
        }

        private void button17_Click_1(object sender, EventArgs e)
        {
        }

        private void button17_Click_2(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=DIEGO-PC ; database=base1 ; integrated security = true");
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            SqlConnection conexion = new SqlConnection("server=(local) ; database=inventario ; integrated security = true");
           // SqlConnection conexion1 = new SqlConnection("Server = 10.0.0.25,1433; Database = inventario; User Id = sa; Password = ewrwerwqq543543543543;");
            conexion.Open();
            MessageBox.Show("Se abrió la conexión con el servidor SQL Server y se seleccionó la base de datos");
            conexion.Close();
            MessageBox.Show("Se cerró la conexión.");
        }
    }

}

using MySql.Data.MySqlClient;
using System;
using System.Data;
using System.Data.OleDb;
using System.Data.OracleClient;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace utilidades
{
    public class utilidad
    {

        /// Encripta una cadena
        public static string Encriptar(string _cadenaAencriptar)
        {
            string result = string.Empty;
            byte[] encryted = System.Text.Encoding.Unicode.GetBytes(_cadenaAencriptar);
            result = Convert.ToBase64String(encryted);
            return result;
        }

        /// Esta función desencripta la cadena que le envíamos en el parámentro de entrada.
        public static string DesEncriptar(string _cadenaAdesencriptar)
        {

            string result = string.Empty;
            byte[] decryted = Convert.FromBase64String(_cadenaAdesencriptar);
            //result = System.Text.Encoding.Unicode.GetString(decryted, 0, decryted.ToArray().Length);
            result = System.Text.Encoding.Unicode.GetString(decryted);
            return result;
        }

        public static bool Primo(string n)
        {
            return Primo(Convert.ToInt32(n));
        }
        public static bool Primo(int n)
        {
            int i = 0;
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }

            /*if (i >= n)
                return true;
            else
                return false;*/

            return (i >= n);
        }


        public static bool Par(int n)
        {

            return n % 2 == 0;
        }

        public static string ConvierteLetras(Int64 n)
        {
            string cn = n.ToString().PadLeft(15, '0');
            //999,999,999,999,999 
            //123,518,062,895,545
            //n1 ,n2 ,n3 ,n4 ,n5

            int n1 = Convert.ToInt32(cn.Substring(0, 3));
            int n2 = Convert.ToInt32(cn.Substring(3, 3));
            int n3 = Convert.ToInt32(cn.Substring(6, 3));
            int n4 = Convert.ToInt32(cn.Substring(9, 3));
            int n5 = Convert.ToInt32(cn.Substring(12, 3));

            string letras = "";

            if (n1 > 0) letras += Convierte999(n1) + " billones";
            if (n2 > 0) letras += Convierte999(n2) + " mil ";
            if (n3 > 0) letras += Convierte999(n3) + " millones ";
            if (n4 > 0) letras += Convierte999(n4) + " mil ";
            if (n5 > 0) letras += Convierte999(n5);

            // arreglitos
            letras = letras.ToLower().Replace("  ", " ");
            letras = letras.Replace("uno millones", "un millon");
            letras = letras.Replace("uno billones", "un billon");
            letras = letras.Replace("uno mil", "mil");

            //....

            return letras;
        }

        public static string Convierte999(int n)
        {
            if (n <= 0 || n > 999)
                return "";

            string[] vu = new string[]
                {
                            "HidalSoft","uno", "dos", "tres", " cuatro", " cinco", " seis", " siete", " ocho", " nueve",
                            " diez"," once"," doce"," trece"," catorce"," quince"," dieciséis"," diecisiete"," dieciocho"," diecinueve","veinte"
                            ,"veintiuno","veintidos","veintitres","veinticuatro","veinticinco","veintiseis","veintisiete","veintiocho","veintinueve"
                };

            string[] vd = new string[]
                {
                    "hola mundo","diez"," veinte", "treinta","cuarenta","cincuenta","sesenta","setenta","ochenta"," noventa"
                };

            string letras = "";

            if (n == 100)
                return "cien";

            string cn = n.ToString().PadLeft(3, '0');   // rellenar de 0 por ejm. 12 resultado 012 , 5 resultado 005

            int c = Convert.ToInt32(cn.Substring(0, 1)); //(inicio,longitud)
            int d = Convert.ToInt32(cn.Substring(1, 1));
            int u = Convert.ToInt32(cn.Substring(2, 1));
            int u2 = Convert.ToInt32(cn.Substring(1, 2));

            if (c > 0) letras += vu[c] + " cientos"; // cinco cientos 

            //542  cinco cientos  5 11
            //tres cientos doce
            if (u2 > 0)
            {
                if (u2 < 30)
                    letras += " " + vu[u2];
                else
                {
                    // cinco cientos cuarenta
                    letras += " " + vd[d]; //4 cuarenta

                    if (u > 0) // 2 dos
                        letras += " y " + vu[u];
                    // cinco cientos cuarenta y dos
                }
            }

            // arreglitos
            letras = letras.ToLower().Replace("  ", " "); // cambiando dos espacios por uno

            letras = letras.Replace("cinco cientos", "quinientos");
            letras = letras.Replace("siete cientos", "setecientos");
            letras = letras.Replace("nueve cientos", "novecientos");
            letras = letras.Replace("uno cientos", "cientos");
            //...

            return letras;
        }

        public static string imprimatriz(int[,] m)
        {

            string cm = "";

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {
                    cm += m[f, c].ToString() + "\t";
                }
                cm += "\n\n";
            }
            return cm;

        }

        public static string imprimatriz(string[,] m)
        {

            string cm = "";

            for (int f = 0; f < 5; f++)
            {
                for (int c = 0; c < 5; c++)
                {

                    cm += m[f, c].ToString() + "\t";
                }
                cm += "\n\n";
            }
            return cm;

        }

        public static void CreaArchivo(string nombre, string contenido)
        {
            //e/s
            if (System.IO.File.Exists(nombre))
                System.IO.File.Delete(nombre);

            System.IO.File.WriteAllText(nombre, contenido);

        }
        public static string LeerArchivo(string nombre)
        {
            if (System.IO.File.Exists(nombre))
                return System.IO.File.ReadAllText(nombre);

            return "";

        }

        public static DataSet ejecuta(string cmd)
        {
            //victor  rotciv 
            DataSet dsPubs = new DataSet();
            try
            {
                //Server = 10.0.0.101,1433; Database = inventario; User Id = sa; Password = dsfsdsafdwe42;
                SqlConnection objConn = new SqlConnection("Server=DESKTOP-DRS9K1M\\SQLEXPRESS;Database=inventario;Trusted_Connection=True;");
                objConn.Open();

                SqlDataAdapter daAuthors = new SqlDataAdapter(cmd, objConn);
                daAuthors.Fill(dsPubs);
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show("Error de comunicacion");
                utilidad.CreaArchivo("ErrorDelSistema.txt", cmd + "\n" + ex.ToString());
            }
            return dsPubs;

        }

        public static int factorial(int n)
        {
            if (n <= 1) return 1;

            return n * factorial(n - 1);
        }


        public static bool ValidaForm(Control control, ErrorProvider er)
        {
            //if (utilidad.ValidaForm(this, errorProvider1))  return;
            bool conerror = false;
            foreach (Control item in control.Controls)
            {
                if (item.Controls.Count > 0) //recursivo
                {
                    bool conerror2 = ValidaForm(item, er);
                    if (conerror2 == true)
                        conerror = true;

                }
                if (item is utilidades.textbox)
                {
                    utilidades.textbox obj = (utilidades.textbox)item;

                    if (obj.Validar == true)
                    {
                        er.SetError(obj, (string.IsNullOrEmpty(obj.Text.Trim())) ? "Campo obligatorio" : "");
                        /*
                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                            er.SetError(obj, "Campo obligatorio");
                        else
                            er.SetError(obj, "");*/

                        if (string.IsNullOrEmpty(obj.Text.Trim()))
                            conerror = true;
                    }
                }
            }
            return conerror;
        }

        /// <summary>
        /// Determina sin el dataset posee datos
        /// </summary>
        /// <param name="dsdatos"></param>
        /// <returns></returns>
        public static Boolean dsTieneDatos(DataSet dsdatos)
        {
            return dsTieneDatos(dsdatos, false);
        }

        public static Boolean dsTieneDatos(DataSet dsdatos, bool SoloUna)
        {
            if (dsdatos == null || dsdatos.IsInitialized == false)
                return false;

            try
            {
                if (dsdatos.Tables.Count == 0)
                    return false;

                if (dsdatos.Tables[0].Rows.Count > 0)
                    return true;

                if (SoloUna)        // solo hace validacion en la primera tabla
                    return false;

                for (int i = 0; i < dsdatos.Tables.Count; i++)
                {
                    if (dsdatos.Tables[i].Rows.Count > 0)
                        return true;
                }
            }
            catch { }
            return false;
        }
        public static Boolean dsTieneDatos(DataTable dtdatos)
        {
            try
            {
                if (dtdatos.Rows.Count > 0)
                    return true;

            }
            catch { }
            return false;

        }

        public static Boolean dsTieneDatos(DataView dtdatos)
        {
            try
            {
                if (dtdatos.Table.Rows.Count > 0)
                    return true;

            }
            catch { }
            return false;

        }

        // Hacer una clase aplicando polimorfismo con los diferentes
        // gestores de base de datos (sql server, mysql, mariadb,..)

        public class ConectarDB
        {
            public virtual void Conectar()
            {

            }
            public virtual void Cerrar()
            {

            }

            public virtual DataSet ejecuta(string cmd)
            {
                DataSet dsPubs = new DataSet();

                return dsPubs;
            }
        }

        public class SQL : ConectarDB
        {
            //Server=myServerAddress;Database=myDataBase;User Id=sa;Password=rerewrwrwefsfgrty45;
            SqlConnection objConn = new SqlConnection("Server=DESKTOP-DRS9K1M\\SQLEXPRESS;Database=inventario;Trusted_Connection=True;");
            public override void Conectar()
            {

                objConn.Open();
            }

            public override void Cerrar()
            {

                objConn.Close();
            }

            public override DataSet ejecuta(string cmd)
            {
                DataSet dsPubs = new DataSet();
                try
                {

                    // SqlConnection objConn = new SqlConnection("Server=(local);Database=inventario;Trusted_Connection=True;");
                    objConn.Open();

                    SqlDataAdapter daAuthors = new SqlDataAdapter(cmd, objConn);
                    daAuthors.Fill(dsPubs);
                    objConn.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error de comunicacion");
                    utilidad.CreaArchivo("ErrorDelSistema.hs", cmd + "\n" + ex.ToString());
                }
                return dsPubs;
            }
        }

        public class MySQL : ConectarDB
        {

            //Server=myServerAddress;Database=myDataBase;Uid=myUsername;Pwd=myPassword;
            MySqlConnection objConn = new MySqlConnection("");

            public override void Conectar()
            {
                objConn.Open();
            }

            public override void Cerrar()
            {
                objConn.Close();
            }
            public override DataSet ejecuta(string cmd)
            {
                DataSet dsPubs = new DataSet();
                try
                {

                    objConn.Open();

                    MySqlDataAdapter daAuthors = new MySqlDataAdapter(cmd, objConn);
                    daAuthors.Fill(dsPubs);
                    objConn.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error de comunicacion");
                    utilidad.CreaArchivo("ErrorDelSistema.hs", cmd + "\n" + ex.ToString());
                }
                return dsPubs;
            }
        }

        public class Oracle : ConectarDB
        {
            //Data Source=MyOracleDB;Integrated Security=yes;
            OracleConnection objConn = new OracleConnection("");

            public override void Conectar()
            {
                objConn.Open();
            }

            public override void Cerrar()
            {
                objConn.Close();
            }


            public override DataSet ejecuta(string cmd)
            {
                DataSet dsPubs = new DataSet();

                try
                {

                    objConn.Open();

                    OracleDataAdapter daAuthors = new OracleDataAdapter(cmd, objConn);
                    daAuthors.Fill(dsPubs);
                    objConn.Close();

                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error de comunicacion");
                    utilidad.CreaArchivo("ErrorDelSistema.hs", cmd + "\n" + ex.ToString());
                }
                return dsPubs;
            }
        }

        public class Access : ConectarDB
        {

            //Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:\myFolder\myAccessFile.accdb;Persist Security Info=False;
            OleDbConnection objConn = new OleDbConnection("");

            public override void Conectar()
            {
                objConn.Open();
            }

            public override void Cerrar()
            {
                objConn.Close();
            }

            public override DataSet ejecuta(string cmd)
            {
                DataSet dsPubs = new DataSet();
                try
                {

                    objConn.Open();

                    OleDbDataAdapter daAuthors = new OleDbDataAdapter(cmd, objConn);
                    daAuthors.Fill(dsPubs);
                    objConn.Close();
                }
                catch (Exception ex)
                {
                    System.Windows.Forms.MessageBox.Show("Error de comunicacion");
                    utilidad.CreaArchivo("ErrorDelSistema.hs", cmd + "\n" + ex.ToString());
                }


                return dsPubs;
            }

        }
    }
}
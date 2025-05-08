using inventario.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;
using System.Windows.Forms;
using utilidades;

namespace inventario
{
    public partial class mantenimientoclientes : mantenimientos
    {
        public mantenimientoclientes()
        {
            InitializeComponent();
        }

        private void txtcodigo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtcodigo.Text.Trim()))
                return;

            ds = utilidad.ejecuta("select * from clientes where codcli='" + txtcodigo.Text.Trim() + "'");

            if (ds.Tables.Count > 0 && ds.Tables[0].Rows.Count > 0)
            {
                txtnombre.Text = ds.Tables[0].Rows[0]["nomcli"].ToString().Trim();
                ckestado.Checked = Convert.ToBoolean(ds.Tables[0].Rows[0]["status"]);
                txtemail.Text = ds.Tables[0].Rows[0]["email"].ToString().Trim();
                txtdireccion.Text = ds.Tables[0].Rows[0]["direccion"].ToString().Trim();
                //codcli, nomcli, email, direccion, status
                //insert update select delete from 

                
            }
            else
            {
                txtnombre.Text = "";
                ckestado.Checked = false;
                txtemail.Text = "";
                txtdireccion.Text = "";
            }
        }

        public override void Salvar()
        {
            if (utilidad.ValidaForm(this, errorProvider1))
                return;

            string cmd = string.Format("exec clienteActualiza '{0}','{1}','{2}','{3}','{4}'",
                txtcodigo.Text.Trim(), txtnombre.Text.Trim(),txtemail.Text.Trim(),txtdireccion.Text.Trim(),
                ckestado.Checked);

            ds = utilidad.ejecuta(cmd);
            Limpiar();
            MessageBox.Show("Datos guardados correctamente");
        }

        public override void Limpiar()
        {
            base.Limpiar();
            txtcodigo.Text = "";
            txtnombre.Text = "";
            ckestado.Checked = false;
            txtemail.Text = "";
            txtdireccion.Text = "";
            txtcodigo.Focus();

        }

        public override void Eliminar()
        {
            ds = utilidad.ejecuta("exec departamentoselimina '" + txtcodigo.Text.Trim() + "'");
            Limpiar();
            MessageBox.Show("Datos eliminados correctamente");
        }

        public override void Consultar()
        {
            consultaClientes obj = new consultaClientes();
            if (obj.ShowDialog() == DialogResult.OK)
            {
                //posicion del cursor o registro activo

                int pos = obj.dataGridView1.CurrentCell.RowIndex;

                txtcodigo.Text = obj.dataGridView1.Rows[pos].Cells[0].Value.ToString().Trim();

                txtcodigo.Focus();
                SendKeys.Send("{tab}");
            }
            obj.Dispose();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string url = "https://localhost:44320/api/clientes";

            ClienteRequest oCliente = new ClienteRequest();
            oCliente.codcli = int.Parse(txtcodigo.Text);
            oCliente.nomcli = txtnombre.Text;
            oCliente.email = txtemail.Text;
            oCliente.direccion = txtdireccion.Text;
            oCliente.status = ckestado.Checked;

            string resultado = Send<ClienteRequest>(url, oCliente, "POST");
            Limpiar();
            if(resultado == "true")
            {
                MessageBox.Show("Datos guardados exitosamente");
            }
            else
            {
                MessageBox.Show("Ha ocurrido un error");
            }
        }

        private void mantenimientoclientes_Load(object sender, EventArgs e)
        {

        }

        public string Send<T>(string url, T objectRequest, string method = "POST")
        {
            string result = "";
            try
            {
               

                JavaScriptSerializer js = new JavaScriptSerializer();

                //serializamos el objeto
                string json = Newtonsoft.Json.JsonConvert.SerializeObject(objectRequest);

                //peticion
                WebRequest request = WebRequest.Create(url);
                //headers
                request.Method = method;
                request.PreAuthenticate = true;
                request.ContentType = "application/json;charset=utf-8'";
                request.Timeout = 10000; //esto es opcional

                using (var streamWriter = new StreamWriter(request.GetRequestStream()))
                {
                    streamWriter.Write(json);
                    streamWriter.Flush();
                }

                var httpResponse = (HttpWebResponse)request.GetResponse();
                using (var streamReader = new StreamReader(httpResponse.GetResponseStream()))
                {
                    result = streamReader.ReadToEnd();
                }
              
            }
            catch (Exception e)
            {


                result = e.Message;

            }

            return result;
        }
    }
}

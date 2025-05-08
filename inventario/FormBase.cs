using System;
using System.Data;
using System.Windows.Forms;

namespace inventario
{
    public partial class FormBase : Form
    {
        public DataSet ds = new DataSet();
   
        public bool PuedeSalvar { set; get; }
        public bool PuedeImprimir { set; get; }
        public bool PuedeConsultar { set; get; }
        public bool PuedeEliminar { set; get; }

        public FormBase()
        {
            InitializeComponent();
        }

        private void boton1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void cmdcerrar_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Desea cerrar el formularoo", "Aviso", MessageBoxButtons.YesNo) == DialogResult.Yes)
                Close();

        }

        public virtual void Salvar()
        {
            MessageBox.Show("Salvando...");
        }

        public virtual void Eliminar()
        {
            MessageBox.Show("Eliminando...");
        }

        public virtual void Consultar()
        {
            MessageBox.Show("Consultando...");
        }
        public virtual void Limpiar()
        {
           
        }

       

        public virtual void Imprimir()
        {
            MessageBox.Show("Imprimiendo...");
        }
    }
}

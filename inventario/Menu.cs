using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace inventario
{
    public partial class Menu : Form
    {
        private int childFormNumber = 0;

        public Menu()
        {
            InitializeComponent();
            //Controls.OfType<MdiClient>().FirstOrDefault().BackColor = Color.GreenYellow;
        }

        private void ShowNewForm(object sender, EventArgs e)
        {
            Form childForm = new Form();
            childForm.MdiParent = this;
            childForm.Text = "Window " + childFormNumber++;
            childForm.Show();
        }

        private void OpenFile(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            openFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (openFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = openFileDialog.FileName;
            }
        }

        private void SaveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Personal);
            saveFileDialog.Filter = "Text Files (*.txt)|*.txt|All Files (*.*)|*.*";
            if (saveFileDialog.ShowDialog(this) == DialogResult.OK)
            {
                string FileName = saveFileDialog.FileName;
            }
        }

        private void ExitToolsStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CutToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void PasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void ToolBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStrip.Visible = toolBarToolStripMenuItem.Checked;
        }

        private void StatusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusStrip.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void CascadeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.Cascade);
        }

        private void TileVerticalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileVertical);
        }

        private void TileHorizontalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.TileHorizontal);
        }

        private void ArrangeIconsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LayoutMdi(MdiLayout.ArrangeIcons);
        }

        private void CloseAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form childForm in MdiChildren)
            {
                childForm.Close();
            }
        }

        private void clientesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantenimientoclientes obj = new mantenimientoclientes();
            obj.MdiParent = this;
            obj.Show();

        }

        private void suplidoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
        }

        private void eJEMPLOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.MdiParent = this;
            obj.Show();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase) // formulario que esta activo
            {
                FormBase obj = (FormBase)ActiveMdiChild;
               
                obj.Salvar();
            }
        }

        private void printToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase)
            {
                FormBase obj = (FormBase)ActiveMdiChild;
                obj.Imprimir();


            }
        }

        private void Menu_MdiChildActivate(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase)
            {
                FormBase obj = (FormBase)ActiveMdiChild;
     
                printPreviewToolStripButton.Enabled = obj.PuedeConsultar;
                printToolStripButton.Enabled = obj.PuedeImprimir;
                saveToolStripButton.Enabled = obj.PuedeSalvar;
                toolStripButtoneliminar.Enabled = obj.PuedeEliminar;

            }
        }

        private void toolStripButtoneliminar_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase)
            {
                FormBase obj = (FormBase)ActiveMdiChild;
                obj.Eliminar();


            }
        }

        private void productosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
        }

        private void printPreviewToolStripButton_Click(object sender, EventArgs e)
        {
            if (ActiveMdiChild is FormBase) // formulario que esta activo
            {
                FormBase obj = (FormBase)ActiveMdiChild;
                //int a = (int)b;

                obj.Consultar();


            }
        }

        private void departamentosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            matenimientodepartamentos obj = new matenimientodepartamentos();
            obj.MdiParent = this;
            obj.Show();
        }

        private void departamentosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultadepartamentos obj = new consultadepartamentos();
            obj.MdiParent = this;
            obj.Show();
        }

        private void ventasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ventas obj = new ventas();
            obj.MdiParent = this;
            obj.Show();
        }

        private void form1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.MdiParent = this;
            obj.Show();

        }

        private void examen1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            examenp1 obj = new examenp1();
            obj.MdiParent = this;
            obj.Show();
        }

        private void fhfhToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void unidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {

            matenimientounidades obj = new matenimientounidades();
            obj.MdiParent = this;
            obj.Show();
        }

        private void comprasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            compras obj = new compras();
            obj.MdiParent = this;
            obj.Show();


        }

        private void clientesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            consultaClientes obj = new consultaClientes();
            obj.MdiParent = this;
            obj.Show();
        }


        private void unidadesToolStripMenuItem_Click_2(object sender, EventArgs e)
        {
            consultaunidades obj = new consultaunidades();
            obj.MdiParent = this;
            obj.Show();
        }

        private void unidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mantUnidades obj = new mantUnidades();
            obj.MdiParent = this;
            obj.Show();
        }

        private void suplidoresToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            consultaSuplidores obj = new consultaSuplidores();
            obj.MdiParent = this;
            obj.Show();
        }

        private void suplidoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mantSuplidores obj = new mantSuplidores();
            obj.MdiParent = this;
            obj.Show();
        }

        private void productosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            consultaProductos obj = new consultaProductos();
            obj.MdiParent = this;
            obj.Show();
        }

        private void productosToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            mantProducto obj = new mantProducto();
            obj.MdiParent = this;
            obj.Show();
        }

        private void reporteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 obj = new Form1();
            obj.MdiParent = this;
            obj.Show();
        }

        private void usuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mantUsuarios obj = new mantUsuarios();
            obj.MdiParent = this;
            obj.Show();
        }

        
    }
}

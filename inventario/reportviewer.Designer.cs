
namespace inventario
{
    partial class reportviewer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            this.facturas1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.inventarioDataSet = new inventario.inventarioDataSet();
            this.detalles1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.unidades1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.suplidor1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.productos1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentos1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientes1BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.departamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clientesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.facturas1TableAdapter = new inventario.inventarioDataSetTableAdapters.facturas1TableAdapter();
            this.clientes1TableAdapter = new inventario.inventarioDataSetTableAdapters.clientes1TableAdapter();
            this.departamentos1TableAdapter = new inventario.inventarioDataSetTableAdapters.departamentos1TableAdapter();
            this.productos1TableAdapter = new inventario.inventarioDataSetTableAdapters.productos1TableAdapter();
            this.suplidor1TableAdapter = new inventario.inventarioDataSetTableAdapters.suplidor1TableAdapter();
            this.unidades1TableAdapter = new inventario.inventarioDataSetTableAdapters.unidades1TableAdapter();
            this.detalles1TableAdapter = new inventario.inventarioDataSetTableAdapters.detalles1TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturas1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalles1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidades1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidor1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentos1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes1BindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbutones
            // 
            this.panelbutones.Location = new System.Drawing.Point(1038, 0);
            this.panelbutones.Size = new System.Drawing.Size(114, 735);
            // 
            // facturas1BindingSource
            // 
            this.facturas1BindingSource.DataMember = "facturas1";
            this.facturas1BindingSource.DataSource = this.inventarioDataSet;
            // 
            // inventarioDataSet
            // 
            this.inventarioDataSet.DataSetName = "inventarioDataSet";
            this.inventarioDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // detalles1BindingSource
            // 
            this.detalles1BindingSource.DataMember = "detalles1";
            this.detalles1BindingSource.DataSource = this.inventarioDataSet;
            // 
            // unidades1BindingSource
            // 
            this.unidades1BindingSource.DataMember = "unidades1";
            this.unidades1BindingSource.DataSource = this.inventarioDataSet;
            // 
            // suplidor1BindingSource
            // 
            this.suplidor1BindingSource.DataMember = "suplidor1";
            this.suplidor1BindingSource.DataSource = this.inventarioDataSet;
            // 
            // productos1BindingSource
            // 
            this.productos1BindingSource.DataMember = "productos1";
            this.productos1BindingSource.DataSource = this.inventarioDataSet;
            // 
            // departamentos1BindingSource
            // 
            this.departamentos1BindingSource.DataMember = "departamentos1";
            this.departamentos1BindingSource.DataSource = this.inventarioDataSet;
            // 
            // clientes1BindingSource
            // 
            this.clientes1BindingSource.DataMember = "clientes1";
            this.clientes1BindingSource.DataSource = this.inventarioDataSet;
            // 
            // departamentosBindingSource
            // 
            this.departamentosBindingSource.DataMember = "departamentos";
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.departamentos1BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "inventario.ReporteDeptos.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1038, 735);
            this.reportViewer1.TabIndex = 5;
            // 
            // facturas1TableAdapter
            // 
            this.facturas1TableAdapter.ClearBeforeFill = true;
            // 
            // clientes1TableAdapter
            // 
            this.clientes1TableAdapter.ClearBeforeFill = true;
            // 
            // departamentos1TableAdapter
            // 
            this.departamentos1TableAdapter.ClearBeforeFill = true;
            // 
            // productos1TableAdapter
            // 
            this.productos1TableAdapter.ClearBeforeFill = true;
            // 
            // suplidor1TableAdapter
            // 
            this.suplidor1TableAdapter.ClearBeforeFill = true;
            // 
            // unidades1TableAdapter
            // 
            this.unidades1TableAdapter.ClearBeforeFill = true;
            // 
            // detalles1TableAdapter
            // 
            this.detalles1TableAdapter.ClearBeforeFill = true;
            // 
            // reportviewer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1152, 735);
            this.Controls.Add(this.reportViewer1);
            this.Name = "reportviewer";
            this.Text = "reportviewer";
            this.Load += new System.EventHandler(this.reportviewer_Load);
            this.Controls.SetChildIndex(this.panelbutones, 0);
            this.Controls.SetChildIndex(this.reportViewer1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.facturas1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.inventarioDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.detalles1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.unidades1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.suplidor1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productos1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentos1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientes1BindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.departamentosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clientesBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
      
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        public System.Windows.Forms.BindingSource clientesBindingSource;
        public System.Windows.Forms.BindingSource departamentosBindingSource;
        private System.Windows.Forms.BindingSource facturas1BindingSource;
        private inventarioDataSet inventarioDataSet;
        private inventarioDataSetTableAdapters.facturas1TableAdapter facturas1TableAdapter;
        private System.Windows.Forms.BindingSource clientes1BindingSource;
        private inventarioDataSetTableAdapters.clientes1TableAdapter clientes1TableAdapter;
        private System.Windows.Forms.BindingSource departamentos1BindingSource;
        private inventarioDataSetTableAdapters.departamentos1TableAdapter departamentos1TableAdapter;
        private System.Windows.Forms.BindingSource productos1BindingSource;
        private inventarioDataSetTableAdapters.productos1TableAdapter productos1TableAdapter;
        private System.Windows.Forms.BindingSource suplidor1BindingSource;
        private inventarioDataSetTableAdapters.suplidor1TableAdapter suplidor1TableAdapter;
        private System.Windows.Forms.BindingSource unidades1BindingSource;
        private inventarioDataSetTableAdapters.unidades1TableAdapter unidades1TableAdapter;
        private System.Windows.Forms.BindingSource detalles1BindingSource;
        private inventarioDataSetTableAdapters.detalles1TableAdapter detalles1TableAdapter;
    }
}
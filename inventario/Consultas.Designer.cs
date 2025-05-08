namespace inventario
{
    partial class Consultas
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
            this.cmdbuscar = new utilidades.boton();
            this.cmdimprimir = new utilidades.boton();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbutones
            // 
            this.panelbutones.Controls.Add(this.cmdimprimir);
            this.panelbutones.Controls.Add(this.cmdbuscar);
            this.panelbutones.Controls.SetChildIndex(this.cmdbuscar, 0);
            this.panelbutones.Controls.SetChildIndex(this.cmdimprimir, 0);
            // 
            // cmdbuscar
            // 
            this.cmdbuscar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdbuscar.Location = new System.Drawing.Point(0, 340);
            this.cmdbuscar.Name = "cmdbuscar";
            this.cmdbuscar.Size = new System.Drawing.Size(91, 50);
            this.cmdbuscar.TabIndex = 1;
            this.cmdbuscar.Text = "Buscar";
            this.cmdbuscar.UseVisualStyleBackColor = true;
            this.cmdbuscar.Click += new System.EventHandler(this.cmdbuscar_Click);
            // 
            // cmdimprimir
            // 
            this.cmdimprimir.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.cmdimprimir.Location = new System.Drawing.Point(0, 290);
            this.cmdimprimir.Name = "cmdimprimir";
            this.cmdimprimir.Size = new System.Drawing.Size(91, 50);
            this.cmdimprimir.TabIndex = 2;
            this.cmdimprimir.Text = "Imprimir";
            this.cmdimprimir.UseVisualStyleBackColor = true;
            this.cmdimprimir.Click += new System.EventHandler(this.cmdimprimir_Click);
            // 
            // Consultas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Name = "Consultas";
            this.PuedeConsultar = true;
            this.PuedeImprimir = true;
            this.Text = "Consultas";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelbutones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private utilidades.boton cmdbuscar;
        public utilidades.boton cmdimprimir;
    }
}
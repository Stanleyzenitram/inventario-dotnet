namespace inventario
{
    partial class mantenimientos
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
            this.boton1 = new utilidades.boton();
            this.boton2 = new utilidades.boton();
            this.boton3 = new utilidades.boton();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelbutones
            // 
            this.panelbutones.Controls.Add(this.boton3);
            this.panelbutones.Controls.Add(this.boton2);
            this.panelbutones.Controls.Add(this.boton1);
            this.panelbutones.Location = new System.Drawing.Point(708, 0);
            this.panelbutones.Size = new System.Drawing.Size(101, 444);
            this.panelbutones.Controls.SetChildIndex(this.boton1, 0);
            this.panelbutones.Controls.SetChildIndex(this.boton2, 0);
            this.panelbutones.Controls.SetChildIndex(this.boton3, 0);
            // 
            // boton1
            // 
            this.boton1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.boton1.Location = new System.Drawing.Point(0, 334);
            this.boton1.Name = "boton1";
            this.boton1.Size = new System.Drawing.Size(101, 50);
            this.boton1.TabIndex = 2;
            this.boton1.Text = "Salvar";
            this.boton1.UseVisualStyleBackColor = true;
            this.boton1.Click += new System.EventHandler(this.boton1_Click);
            // 
            // boton2
            // 
            this.boton2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.boton2.Location = new System.Drawing.Point(0, 284);
            this.boton2.Name = "boton2";
            this.boton2.Size = new System.Drawing.Size(101, 50);
            this.boton2.TabIndex = 1;
            this.boton2.Text = "Eliminar";
            this.boton2.UseVisualStyleBackColor = true;
            this.boton2.Click += new System.EventHandler(this.boton2_Click);
            // 
            // boton3
            // 
            this.boton3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.boton3.Location = new System.Drawing.Point(0, 208);
            this.boton3.Name = "boton3";
            this.boton3.Size = new System.Drawing.Size(101, 76);
            this.boton3.TabIndex = 0;
            this.boton3.Text = "Consultar";
            this.boton3.UseVisualStyleBackColor = true;
            this.boton3.Click += new System.EventHandler(this.boton3_Click);
            // 
            // mantenimientos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(809, 444);
            this.Name = "mantenimientos";
            this.PuedeConsultar = true;
            this.PuedeEliminar = true;
            this.PuedeImprimir = true;
            this.PuedeSalvar = true;
            this.Text = "mantenimientos";
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelbutones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        public utilidades.boton boton1;
        public utilidades.boton boton3;
        public utilidades.boton boton2;
    }
}
namespace inventario
{
    partial class mantenimientoclientes
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
            this.txtdireccion = new utilidades.textbox(this.components);
            this.label4 = new utilidades.label(this.components);
            this.txtemail = new utilidades.textbox(this.components);
            this.label3 = new utilidades.label(this.components);
            this.ckestado = new System.Windows.Forms.CheckBox();
            this.txtnombre = new utilidades.textbox(this.components);
            this.label2 = new utilidades.label(this.components);
            this.txtcodigo = new utilidades.textbox(this.components);
            this.label1 = new utilidades.label(this.components);
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(0, 252);
            this.boton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boton1.Size = new System.Drawing.Size(105, 62);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(0, 128);
            this.boton3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boton3.Size = new System.Drawing.Size(105, 62);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(0, 190);
            this.boton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.boton2.Size = new System.Drawing.Size(105, 62);
            // 
            // panelbutones
            // 
            this.panelbutones.Controls.Add(this.button1);
            this.panelbutones.Location = new System.Drawing.Point(778, 0);
            this.panelbutones.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panelbutones.Size = new System.Drawing.Size(105, 389);
            this.panelbutones.TabIndex = 8;
            this.panelbutones.Controls.SetChildIndex(this.boton1, 0);
            this.panelbutones.Controls.SetChildIndex(this.boton2, 0);
            this.panelbutones.Controls.SetChildIndex(this.boton3, 0);
            this.panelbutones.Controls.SetChildIndex(this.button1, 0);
            // 
            // txtdireccion
            // 
            this.txtdireccion.Location = new System.Drawing.Point(191, 288);
            this.txtdireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtdireccion.Name = "txtdireccion";
            this.txtdireccion.Size = new System.Drawing.Size(447, 26);
            this.txtdireccion.Solonumero = false;
            this.txtdireccion.TabIndex = 7;
            this.txtdireccion.Validar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(110, 291);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Direccion";
            // 
            // txtemail
            // 
            this.txtemail.Location = new System.Drawing.Point(191, 201);
            this.txtemail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtemail.Name = "txtemail";
            this.txtemail.Size = new System.Drawing.Size(447, 26);
            this.txtemail.Solonumero = false;
            this.txtemail.TabIndex = 5;
            this.txtemail.Validar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(138, 205);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email";
            // 
            // ckestado
            // 
            this.ckestado.AutoSize = true;
            this.ckestado.Location = new System.Drawing.Point(556, 38);
            this.ckestado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckestado.Name = "ckestado";
            this.ckestado.Size = new System.Drawing.Size(86, 24);
            this.ckestado.TabIndex = 9;
            this.ckestado.Text = "Estado";
            this.ckestado.UseVisualStyleBackColor = true;
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(191, 130);
            this.txtnombre.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(447, 26);
            this.txtnombre.Solonumero = false;
            this.txtnombre.TabIndex = 3;
            this.txtnombre.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(120, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(191, 69);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(112, 26);
            this.txtcodigo.Solonumero = false;
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.Validar = false;
            this.txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodigo_Validating);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(127, 72);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // button1
            // 
            this.button1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.button1.Location = new System.Drawing.Point(0, 38);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(105, 90);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar con web api";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mantenimientoclientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(883, 389);
            this.Controls.Add(this.txtdireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtemail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckestado);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "mantenimientoclientes";
            this.Text = "mantenimientoclietnes";
            this.Load += new System.EventHandler(this.mantenimientoclientes_Load);
            this.Controls.SetChildIndex(this.panelbutones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtnombre, 0);
            this.Controls.SetChildIndex(this.ckestado, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtemail, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtdireccion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelbutones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private utilidades.textbox txtdireccion;
        private utilidades.label label4;
        private utilidades.textbox txtemail;
        private utilidades.label label3;
        private System.Windows.Forms.CheckBox ckestado;
        private utilidades.textbox txtnombre;
        private utilidades.label label2;
        private utilidades.textbox txtcodigo;
        private utilidades.label label1;
        private System.Windows.Forms.Button button1;
    }
}
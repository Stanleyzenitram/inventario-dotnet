namespace inventario
{
    partial class matenimientodepartamentos
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
            this.label1 = new utilidades.label(this.components);
            this.txtcodigo = new utilidades.textbox(this.components);
            this.txtnombre = new utilidades.textbox(this.components);
            this.label2 = new utilidades.label(this.components);
            this.ckestado = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(0, 171);
            this.boton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(0, 14);
            this.boton3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(0, 109);
            this.boton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // panelbutones
            // 
            this.panelbutones.Location = new System.Drawing.Point(661, 0);
            this.panelbutones.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panelbutones.Size = new System.Drawing.Size(114, 308);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 61);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtcodigo
            // 
            this.txtcodigo.Location = new System.Drawing.Point(126, 57);
            this.txtcodigo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtcodigo.Name = "txtcodigo";
            this.txtcodigo.Size = new System.Drawing.Size(112, 26);
            this.txtcodigo.Solonumero = false;
            this.txtcodigo.TabIndex = 1;
            this.txtcodigo.Validar = false;
            this.txtcodigo.Validating += new System.ComponentModel.CancelEventHandler(this.textbox1_Validating);
            // 
            // txtnombre
            // 
            this.txtnombre.Location = new System.Drawing.Point(126, 119);
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
            this.label2.Location = new System.Drawing.Point(45, 122);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // ckestado
            // 
            this.ckestado.AutoSize = true;
            this.ckestado.Location = new System.Drawing.Point(126, 201);
            this.ckestado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckestado.Name = "ckestado";
            this.ckestado.Size = new System.Drawing.Size(86, 24);
            this.ckestado.TabIndex = 5;
            this.ckestado.Text = "Estado";
            this.ckestado.UseVisualStyleBackColor = true;
            // 
            // matenimientodepartamentos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(775, 308);
            this.Controls.Add(this.ckestado);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtcodigo);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "matenimientodepartamentos";
            this.Text = "Registro departamentos";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtcodigo, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtnombre, 0);
            this.Controls.SetChildIndex(this.ckestado, 0);
            this.Controls.SetChildIndex(this.panelbutones, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelbutones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private utilidades.label label1;
        private utilidades.textbox txtcodigo;
        private utilidades.textbox txtnombre;
        private utilidades.label label2;
        private System.Windows.Forms.CheckBox ckestado;
    }
}
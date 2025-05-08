namespace inventario
{
    partial class mantSuplidores
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
            this.txtCod = new utilidades.textbox(this.components);
            this.txtNom = new utilidades.textbox(this.components);
            this.label2 = new utilidades.label(this.components);
            this.ckestado = new System.Windows.Forms.CheckBox();
            this.txtEmail = new utilidades.textbox(this.components);
            this.label3 = new utilidades.label(this.components);
            this.txtDireccion = new utilidades.textbox(this.components);
            this.label4 = new utilidades.label(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(0, 274);
            this.boton1.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(0, 117);
            this.boton3.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(0, 212);
            this.boton2.Margin = new System.Windows.Forms.Padding(3, 5, 3, 5);
            // 
            // panelbutones
            // 
            this.panelbutones.Location = new System.Drawing.Point(687, 0);
            this.panelbutones.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.panelbutones.Size = new System.Drawing.Size(114, 411);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(49, 69);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(130, 65);
            this.txtCod.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(112, 26);
            this.txtCod.Solonumero = false;
            this.txtCod.TabIndex = 1;
            this.txtCod.Validar = false;
            this.txtCod.Validating += new System.ComponentModel.CancelEventHandler(this.txtCod_Validating);
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(130, 127);
            this.txtNom.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(447, 26);
            this.txtNom.Solonumero = false;
            this.txtNom.TabIndex = 3;
            this.txtNom.Validar = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Nombre";
            // 
            // ckestado
            // 
            this.ckestado.AutoSize = true;
            this.ckestado.Location = new System.Drawing.Point(130, 346);
            this.ckestado.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ckestado.Name = "ckestado";
            this.ckestado.Size = new System.Drawing.Size(86, 24);
            this.ckestado.TabIndex = 5;
            this.ckestado.Text = "Estado";
            this.ckestado.UseVisualStyleBackColor = true;
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(130, 199);
            this.txtEmail.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(447, 26);
            this.txtEmail.Solonumero = false;
            this.txtEmail.TabIndex = 7;
            this.txtEmail.Validar = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(49, 203);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 20);
            this.label3.TabIndex = 6;
            this.label3.Text = "Email";
            // 
            // txtDireccion
            // 
            this.txtDireccion.Location = new System.Drawing.Point(130, 279);
            this.txtDireccion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDireccion.Name = "txtDireccion";
            this.txtDireccion.Size = new System.Drawing.Size(447, 26);
            this.txtDireccion.Solonumero = false;
            this.txtDireccion.TabIndex = 9;
            this.txtDireccion.Validar = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(49, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 20);
            this.label4.TabIndex = 8;
            this.label4.Text = "Direccion";
            // 
            // mantSuplidores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(801, 411);
            this.Controls.Add(this.txtDireccion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ckestado);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(3, 6, 3, 6);
            this.Name = "mantSuplidores";
            this.Text = "Registro suplidores";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtNom, 0);
            this.Controls.SetChildIndex(this.ckestado, 0);
            this.Controls.SetChildIndex(this.panelbutones, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtEmail, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtDireccion, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelbutones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private utilidades.label label1;
        private utilidades.textbox txtCod;
        private utilidades.textbox txtNom;
        private utilidades.label label2;
        private System.Windows.Forms.CheckBox ckestado;
        private utilidades.textbox txtEmail;
        private utilidades.label label3;
        private utilidades.textbox txtDireccion;
        private utilidades.label label4;
    }
}
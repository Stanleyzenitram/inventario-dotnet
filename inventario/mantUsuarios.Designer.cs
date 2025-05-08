
namespace inventario
{
    partial class mantUsuarios
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
            this.label2 = new utilidades.label(this.components);
            this.txtUser = new utilidades.textbox(this.components);
            this.label3 = new utilidades.label(this.components);
            this.label4 = new utilidades.label(this.components);
            this.txtNom = new utilidades.textbox(this.components);
            this.txtClave = new utilidades.textbox(this.components);
            this.ckestado1 = new utilidades.ckestado(this.components);
            this.cmbNiv = new utilidades.combobox(this.components);
            this.label5 = new utilidades.label(this.components);
            this.boton4 = new utilidades.boton();
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(0, 246);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(0, 89);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(0, 184);
            // 
            // panelbutones
            // 
            this.panelbutones.Controls.Add(this.boton4);
            this.panelbutones.Location = new System.Drawing.Point(678, 0);
            this.panelbutones.Size = new System.Drawing.Size(114, 383);
            this.panelbutones.Controls.SetChildIndex(this.boton1, 0);
            this.panelbutones.Controls.SetChildIndex(this.boton2, 0);
            this.panelbutones.Controls.SetChildIndex(this.boton3, 0);
            this.panelbutones.Controls.SetChildIndex(this.boton4, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(104, 46);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(100, 26);
            this.txtCod.Solonumero = false;
            this.txtCod.TabIndex = 6;
            this.txtCod.Validar = false;
            this.txtCod.Validating += new System.ComponentModel.CancelEventHandler(this.txtCod_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Usuario";
            // 
            // txtUser
            // 
            this.txtUser.Location = new System.Drawing.Point(104, 107);
            this.txtUser.Name = "txtUser";
            this.txtUser.Size = new System.Drawing.Size(100, 26);
            this.txtUser.Solonumero = false;
            this.txtUser.TabIndex = 8;
            this.txtUser.Validar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Nombre";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(27, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(92, 20);
            this.label4.TabIndex = 10;
            this.label4.Text = "Contraseña";
            // 
            // txtNom
            // 
            this.txtNom.Location = new System.Drawing.Point(104, 150);
            this.txtNom.Name = "txtNom";
            this.txtNom.Size = new System.Drawing.Size(198, 26);
            this.txtNom.Solonumero = false;
            this.txtNom.TabIndex = 11;
            this.txtNom.Validar = false;
            // 
            // txtClave
            // 
            this.txtClave.Location = new System.Drawing.Point(129, 229);
            this.txtClave.Name = "txtClave";
            this.txtClave.Size = new System.Drawing.Size(196, 26);
            this.txtClave.Solonumero = false;
            this.txtClave.TabIndex = 12;
            this.txtClave.Validar = false;
            // 
            // ckestado1
            // 
            this.ckestado1.AutoSize = true;
            this.ckestado1.Location = new System.Drawing.Point(404, 246);
            this.ckestado1.Name = "ckestado1";
            this.ckestado1.Size = new System.Drawing.Size(86, 24);
            this.ckestado1.TabIndex = 13;
            this.ckestado1.Text = "Estado";
            this.ckestado1.UseVisualStyleBackColor = true;
            // 
            // cmbNiv
            // 
            this.cmbNiv.FormattingEnabled = true;
            this.cmbNiv.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5"});
            this.cmbNiv.Location = new System.Drawing.Point(108, 285);
            this.cmbNiv.Name = "cmbNiv";
            this.cmbNiv.Size = new System.Drawing.Size(121, 28);
            this.cmbNiv.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(36, 293);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(42, 20);
            this.label5.TabIndex = 15;
            this.label5.Text = "Nivel";
            // 
            // boton4
            // 
            this.boton4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.boton4.Location = new System.Drawing.Point(0, 39);
            this.boton4.Name = "boton4";
            this.boton4.Size = new System.Drawing.Size(114, 50);
            this.boton4.TabIndex = 3;
            this.boton4.Text = "Elevar";
            this.boton4.UseVisualStyleBackColor = true;
            this.boton4.Click += new System.EventHandler(this.boton4_Click);
            // 
            // mantUsuarios
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(792, 383);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.cmbNiv);
            this.Controls.Add(this.ckestado1);
            this.Controls.Add(this.txtClave);
            this.Controls.Add(this.txtNom);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtUser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Name = "mantUsuarios";
            this.Text = "mantUsuarios";
            this.Controls.SetChildIndex(this.panelbutones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtUser, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtNom, 0);
            this.Controls.SetChildIndex(this.txtClave, 0);
            this.Controls.SetChildIndex(this.ckestado1, 0);
            this.Controls.SetChildIndex(this.cmbNiv, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelbutones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private utilidades.label label1;
        private utilidades.textbox txtCod;
        private utilidades.label label2;
        private utilidades.textbox txtUser;
        private utilidades.label label3;
        private utilidades.label label4;
        private utilidades.textbox txtNom;
        private utilidades.textbox txtClave;
        private utilidades.ckestado ckestado1;
        private utilidades.combobox cmbNiv;
        private utilidades.label label5;
        private utilidades.boton boton4;
    }
}
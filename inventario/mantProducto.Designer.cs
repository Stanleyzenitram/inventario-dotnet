
namespace inventario
{
    partial class mantProducto
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
            this.txtnomProd = new utilidades.textbox(this.components);
            this.txtpreVen = new utilidades.textbox(this.components);
            this.label3 = new utilidades.label(this.components);
            this.label4 = new utilidades.label(this.components);
            this.txtpreCompra = new utilidades.textbox(this.components);
            this.label5 = new utilidades.label(this.components);
            this.txtexiPro = new utilidades.textbox(this.components);
            this.label6 = new utilidades.label(this.components);
            this.txtpunReo = new utilidades.textbox(this.components);
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.txtcodDep = new utilidades.textbox(this.components);
            this.ckestado = new utilidades.ckestado(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(0, 339);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(0, 211);
            this.boton3.Size = new System.Drawing.Size(114, 66);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(0, 277);
            // 
            // panelbutones
            // 
            this.panelbutones.Location = new System.Drawing.Point(609, 0);
            this.panelbutones.Size = new System.Drawing.Size(114, 476);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 49);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código: ";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(209, 47);
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
            this.label2.Location = new System.Drawing.Point(66, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(136, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre producto:";
            // 
            // txtnomProd
            // 
            this.txtnomProd.Location = new System.Drawing.Point(209, 99);
            this.txtnomProd.Name = "txtnomProd";
            this.txtnomProd.Size = new System.Drawing.Size(345, 26);
            this.txtnomProd.Solonumero = false;
            this.txtnomProd.TabIndex = 8;
            this.txtnomProd.Validar = false;
            // 
            // txtpreVen
            // 
            this.txtpreVen.Location = new System.Drawing.Point(209, 158);
            this.txtpreVen.Name = "txtpreVen";
            this.txtpreVen.Size = new System.Drawing.Size(129, 26);
            this.txtpreVen.Solonumero = false;
            this.txtpreVen.TabIndex = 10;
            this.txtpreVen.Validar = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(102, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 9;
            this.label3.Text = "Precio venta:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(88, 199);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(114, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio compra:";
            // 
            // txtpreCompra
            // 
            this.txtpreCompra.Location = new System.Drawing.Point(209, 199);
            this.txtpreCompra.Name = "txtpreCompra";
            this.txtpreCompra.Size = new System.Drawing.Size(129, 26);
            this.txtpreCompra.Solonumero = false;
            this.txtpreCompra.TabIndex = 12;
            this.txtpreCompra.Validar = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(51, 253);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(152, 20);
            this.label5.TabIndex = 13;
            this.label5.Text = "Existencia producto:";
            // 
            // txtexiPro
            // 
            this.txtexiPro.Location = new System.Drawing.Point(209, 250);
            this.txtexiPro.Name = "txtexiPro";
            this.txtexiPro.Size = new System.Drawing.Size(255, 26);
            this.txtexiPro.Solonumero = false;
            this.txtexiPro.TabIndex = 14;
            this.txtexiPro.Validar = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(139, 300);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 20);
            this.label6.TabIndex = 15;
            this.label6.Text = "punreo:";
            // 
            // txtpunReo
            // 
            this.txtpunReo.Location = new System.Drawing.Point(209, 294);
            this.txtpunReo.Name = "txtpunReo";
            this.txtpunReo.Size = new System.Drawing.Size(255, 26);
            this.txtpunReo.Solonumero = false;
            this.txtpunReo.TabIndex = 16;
            this.txtpunReo.Validar = false;
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(35, 359);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(167, 20);
            this.linkLabel1.TabIndex = 17;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Codigo departamento:";
            this.linkLabel1.Click += new System.EventHandler(this.linkLabel1_Click);
            // 
            // txtcodDep
            // 
            this.txtcodDep.Location = new System.Drawing.Point(209, 356);
            this.txtcodDep.Name = "txtcodDep";
            this.txtcodDep.Size = new System.Drawing.Size(129, 26);
            this.txtcodDep.Solonumero = false;
            this.txtcodDep.TabIndex = 18;
            this.txtcodDep.Validar = false;
            this.txtcodDep.Validating += new System.ComponentModel.CancelEventHandler(this.txtcodDep_Validating);
            // 
            // ckestado
            // 
            this.ckestado.AutoSize = true;
            this.ckestado.Location = new System.Drawing.Point(209, 401);
            this.ckestado.Name = "ckestado";
            this.ckestado.Size = new System.Drawing.Size(86, 24);
            this.ckestado.TabIndex = 19;
            this.ckestado.Text = "Estado";
            this.ckestado.UseVisualStyleBackColor = true;
            // 
            // mantProducto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(723, 476);
            this.Controls.Add(this.ckestado);
            this.Controls.Add(this.txtcodDep);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.txtpunReo);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtexiPro);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtpreCompra);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtpreVen);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtnomProd);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Name = "mantProducto";
            this.Text = "mantProducto";
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtnomProd, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.txtpreVen, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.Controls.SetChildIndex(this.txtpreCompra, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.txtexiPro, 0);
            this.Controls.SetChildIndex(this.label6, 0);
            this.Controls.SetChildIndex(this.txtpunReo, 0);
            this.Controls.SetChildIndex(this.linkLabel1, 0);
            this.Controls.SetChildIndex(this.txtcodDep, 0);
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
        private utilidades.textbox txtCod;
        private utilidades.label label2;
        private utilidades.textbox txtnomProd;
        private utilidades.textbox txtpreVen;
        private utilidades.label label3;
        private utilidades.label label4;
        private utilidades.textbox txtpreCompra;
        private utilidades.label label5;
        private utilidades.textbox txtexiPro;
        private utilidades.label label6;
        private utilidades.textbox txtpunReo;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private utilidades.textbox txtcodDep;
        private utilidades.ckestado ckestado;
    }
}
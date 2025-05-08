
namespace inventario
{
    partial class mantUnidades
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
            this.textbox1 = new utilidades.textbox(this.components);
            this.label2 = new utilidades.label(this.components);
            this.textbox2 = new utilidades.textbox(this.components);
            this.ckestado = new utilidades.ckestado(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(0, 142);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(0, 11);
            this.boton3.Size = new System.Drawing.Size(114, 69);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(0, 80);
            // 
            // panelbutones
            // 
            this.panelbutones.Location = new System.Drawing.Point(598, 0);
            this.panelbutones.Size = new System.Drawing.Size(114, 279);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Código: ";
            // 
            // textbox1
            // 
            this.textbox1.Location = new System.Drawing.Point(107, 41);
            this.textbox1.Name = "textbox1";
            this.textbox1.Size = new System.Drawing.Size(113, 26);
            this.textbox1.Solonumero = false;
            this.textbox1.TabIndex = 6;
            this.textbox1.Validar = false;
            this.textbox1.Validating += new System.ComponentModel.CancelEventHandler(this.textbox1_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // textbox2
            // 
            this.textbox2.Location = new System.Drawing.Point(109, 132);
            this.textbox2.Name = "textbox2";
            this.textbox2.Size = new System.Drawing.Size(225, 26);
            this.textbox2.Solonumero = false;
            this.textbox2.TabIndex = 8;
            this.textbox2.Validar = false;
            // 
            // ckestado
            // 
            this.ckestado.AutoSize = true;
            this.ckestado.Location = new System.Drawing.Point(109, 200);
            this.ckestado.Name = "ckestado";
            this.ckestado.Size = new System.Drawing.Size(86, 24);
            this.ckestado.TabIndex = 9;
            this.ckestado.Text = "Estado";
            this.ckestado.UseVisualStyleBackColor = true;
            // 
            // mantUnidades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 279);
            this.Controls.Add(this.ckestado);
            this.Controls.Add(this.textbox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textbox1);
            this.Controls.Add(this.label1);
            this.Name = "mantUnidades";
            this.Text = "mantUnidades";
            this.Controls.SetChildIndex(this.panelbutones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.textbox1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.textbox2, 0);
            this.Controls.SetChildIndex(this.ckestado, 0);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).EndInit();
            this.panelbutones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private utilidades.label label1;
        private utilidades.textbox textbox1;
        private utilidades.label label2;
        private utilidades.textbox textbox2;
        private utilidades.ckestado ckestado;
    }
}
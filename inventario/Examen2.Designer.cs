
namespace inventario
{
    partial class Examen2
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
            this.txtDesc = new utilidades.textbox(this.components);
            this.ckestado1 = new utilidades.ckestado(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ds)).BeginInit();
            this.panelbutones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // boton1
            // 
            this.boton1.Location = new System.Drawing.Point(0, 149);
            // 
            // boton3
            // 
            this.boton3.Location = new System.Drawing.Point(0, 24);
            this.boton3.Size = new System.Drawing.Size(114, 63);
            // 
            // boton2
            // 
            this.boton2.Location = new System.Drawing.Point(0, 87);
            // 
            // panelbutones
            // 
            this.panelbutones.Location = new System.Drawing.Point(482, 0);
            this.panelbutones.Size = new System.Drawing.Size(114, 286);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 5;
            this.label1.Text = "Codigo";
            // 
            // txtCod
            // 
            this.txtCod.Location = new System.Drawing.Point(109, 68);
            this.txtCod.Name = "txtCod";
            this.txtCod.Size = new System.Drawing.Size(137, 26);
            this.txtCod.Solonumero = false;
            this.txtCod.TabIndex = 6;
            this.txtCod.Validar = false;
            this.txtCod.Validating += new System.ComponentModel.CancelEventHandler(this.txtCod_Validating);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(43, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Nombre";
            // 
            // txtDesc
            // 
            this.txtDesc.Location = new System.Drawing.Point(112, 123);
            this.txtDesc.Name = "txtDesc";
            this.txtDesc.Size = new System.Drawing.Size(137, 26);
            this.txtDesc.Solonumero = false;
            this.txtDesc.TabIndex = 8;
            this.txtDesc.Validar = false;
            // 
            // ckestado1
            // 
            this.ckestado1.AutoSize = true;
            this.ckestado1.Location = new System.Drawing.Point(109, 203);
            this.ckestado1.Name = "ckestado1";
            this.ckestado1.Size = new System.Drawing.Size(86, 24);
            this.ckestado1.TabIndex = 9;
            this.ckestado1.Text = "Estado";
            this.ckestado1.UseVisualStyleBackColor = true;
            // 
            // Examen2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(596, 286);
            this.Controls.Add(this.ckestado1);
            this.Controls.Add(this.txtDesc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtCod);
            this.Controls.Add(this.label1);
            this.Name = "Examen2";
            this.Text = "Examen2";
            this.Controls.SetChildIndex(this.panelbutones, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.txtCod, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.txtDesc, 0);
            this.Controls.SetChildIndex(this.ckestado1, 0);
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
        private utilidades.textbox txtDesc;
        private utilidades.ckestado ckestado1;
    }
}
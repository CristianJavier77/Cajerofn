namespace Cajerofn
{
    partial class Cajerobi
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.txtmil = new System.Windows.Forms.TextBox();
            this.txtquiniento = new System.Windows.Forms.TextBox();
            this.txtdociento = new System.Windows.Forms.TextBox();
            this.txtcien = new System.Windows.Forms.TextBox();
            this.btnCalcula = new System.Windows.Forms.Button();
            this.btnlimpiar = new System.Windows.Forms.Button();
            this.btnsalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(86, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ingrese cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "billetes de mil";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 173);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "billetes de quiniento";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(44, 239);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(98, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "billetes de dociento";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 306);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(77, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "billetes de cien";
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(187, 48);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 5;
            // 
            // txtmil
            // 
            this.txtmil.Location = new System.Drawing.Point(187, 116);
            this.txtmil.Name = "txtmil";
            this.txtmil.Size = new System.Drawing.Size(100, 20);
            this.txtmil.TabIndex = 6;
            // 
            // txtquiniento
            // 
            this.txtquiniento.Location = new System.Drawing.Point(187, 173);
            this.txtquiniento.Name = "txtquiniento";
            this.txtquiniento.Size = new System.Drawing.Size(100, 20);
            this.txtquiniento.TabIndex = 7;
            // 
            // txtdociento
            // 
            this.txtdociento.Location = new System.Drawing.Point(187, 239);
            this.txtdociento.Name = "txtdociento";
            this.txtdociento.Size = new System.Drawing.Size(100, 20);
            this.txtdociento.TabIndex = 8;
            // 
            // txtcien
            // 
            this.txtcien.Location = new System.Drawing.Point(187, 306);
            this.txtcien.Name = "txtcien";
            this.txtcien.Size = new System.Drawing.Size(100, 20);
            this.txtcien.TabIndex = 9;
            // 
            // btnCalcula
            // 
            this.btnCalcula.Location = new System.Drawing.Point(630, 143);
            this.btnCalcula.Name = "btnCalcula";
            this.btnCalcula.Size = new System.Drawing.Size(75, 43);
            this.btnCalcula.TabIndex = 10;
            this.btnCalcula.Text = "Calcula";
            this.btnCalcula.UseVisualStyleBackColor = true;
            this.btnCalcula.Click += new System.EventHandler(this.BtnCalcula_Click);
            // 
            // btnlimpiar
            // 
            this.btnlimpiar.Location = new System.Drawing.Point(630, 211);
            this.btnlimpiar.Name = "btnlimpiar";
            this.btnlimpiar.Size = new System.Drawing.Size(75, 40);
            this.btnlimpiar.TabIndex = 11;
            this.btnlimpiar.Text = "Limpiar";
            this.btnlimpiar.UseVisualStyleBackColor = true;
            this.btnlimpiar.Click += new System.EventHandler(this.Btnlimpiar_Click);
            // 
            // btnsalir
            // 
            this.btnsalir.Location = new System.Drawing.Point(630, 282);
            this.btnsalir.Name = "btnsalir";
            this.btnsalir.Size = new System.Drawing.Size(75, 43);
            this.btnsalir.TabIndex = 12;
            this.btnsalir.Text = "Salir";
            this.btnsalir.UseVisualStyleBackColor = true;
            this.btnsalir.Click += new System.EventHandler(this.Btnsalir_Click);
            // 
            // Cajerobi
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsalir);
            this.Controls.Add(this.btnlimpiar);
            this.Controls.Add(this.btnCalcula);
            this.Controls.Add(this.txtcien);
            this.Controls.Add(this.txtdociento);
            this.Controls.Add(this.txtquiniento);
            this.Controls.Add(this.txtmil);
            this.Controls.Add(this.txtCantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Cajerobi";
            this.Text = "CajeroBi";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.TextBox txtmil;
        private System.Windows.Forms.TextBox txtquiniento;
        private System.Windows.Forms.TextBox txtdociento;
        private System.Windows.Forms.TextBox txtcien;
        private System.Windows.Forms.Button btnCalcula;
        private System.Windows.Forms.Button btnlimpiar;
        private System.Windows.Forms.Button btnsalir;
    }
}


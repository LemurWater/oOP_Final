namespace p_colegio.Forms
{
    partial class F_Acceso
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
            this.label_clave = new System.Windows.Forms.Label();
            this.label_nombre = new System.Windows.Forms.Label();
            this.rtb_clave = new System.Windows.Forms.RichTextBox();
            this.rtb_nombre = new System.Windows.Forms.RichTextBox();
            this.label_colegio = new System.Windows.Forms.Label();
            this.pb_escudo_colegio = new System.Windows.Forms.PictureBox();
            this.boton_acceder = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pb_escudo_colegio)).BeginInit();
            this.SuspendLayout();
            // 
            // label_clave
            // 
            this.label_clave.AutoSize = true;
            this.label_clave.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_clave.Location = new System.Drawing.Point(254, 336);
            this.label_clave.Name = "label_clave";
            this.label_clave.Size = new System.Drawing.Size(50, 31);
            this.label_clave.TabIndex = 11;
            this.label_clave.Text = "ID:";
            // 
            // label_nombre
            // 
            this.label_nombre.AutoSize = true;
            this.label_nombre.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_nombre.Location = new System.Drawing.Point(186, 251);
            this.label_nombre.Name = "label_nombre";
            this.label_nombre.Size = new System.Drawing.Size(118, 31);
            this.label_nombre.TabIndex = 10;
            this.label_nombre.Text = "Nombre:";
            // 
            // rtb_clave
            // 
            this.rtb_clave.Font = new System.Drawing.Font("Consolas", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_clave.Location = new System.Drawing.Point(335, 336);
            this.rtb_clave.Name = "rtb_clave";
            this.rtb_clave.Size = new System.Drawing.Size(332, 46);
            this.rtb_clave.TabIndex = 9;
            this.rtb_clave.Text = "Clave0de1prueba2";
            this.rtb_clave.TextChanged += new System.EventHandler(this.rtb_clave_TextChanged);
            this.rtb_clave.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtb_clave_MouseDown);
            // 
            // rtb_nombre
            // 
            this.rtb_nombre.Font = new System.Drawing.Font("Simplex", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtb_nombre.Location = new System.Drawing.Point(335, 251);
            this.rtb_nombre.Name = "rtb_nombre";
            this.rtb_nombre.Size = new System.Drawing.Size(332, 46);
            this.rtb_nombre.TabIndex = 8;
            this.rtb_nombre.Text = "Nombre De Prueba";
            this.rtb_nombre.TextChanged += new System.EventHandler(this.rtb_nombre_TextChanged);
            this.rtb_nombre.MouseDown += new System.Windows.Forms.MouseEventHandler(this.rtb_nombre_MouseDown);
            // 
            // label_colegio
            // 
            this.label_colegio.AutoSize = true;
            this.label_colegio.Font = new System.Drawing.Font("CommercialScript BT", 32F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_colegio.Location = new System.Drawing.Point(291, 37);
            this.label_colegio.Name = "label_colegio";
            this.label_colegio.Size = new System.Drawing.Size(435, 62);
            this.label_colegio.TabIndex = 7;
            this.label_colegio.Text = "[Nombre del colegio]";
            // 
            // pb_escudo_colegio
            // 
            this.pb_escudo_colegio.BackColor = System.Drawing.Color.Fuchsia;
            this.pb_escudo_colegio.Location = new System.Drawing.Point(60, 37);
            this.pb_escudo_colegio.Name = "pb_escudo_colegio";
            this.pb_escudo_colegio.Size = new System.Drawing.Size(150, 150);
            this.pb_escudo_colegio.TabIndex = 6;
            this.pb_escudo_colegio.TabStop = false;
            // 
            // boton_acceder
            // 
            this.boton_acceder.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boton_acceder.Location = new System.Drawing.Point(335, 413);
            this.boton_acceder.Name = "boton_acceder";
            this.boton_acceder.Size = new System.Drawing.Size(125, 46);
            this.boton_acceder.TabIndex = 12;
            this.boton_acceder.Text = "Acceder";
            this.boton_acceder.UseVisualStyleBackColor = true;
            this.boton_acceder.Click += new System.EventHandler(this.boton_acceder_Click);
            // 
            // F_Acceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 482);
            this.Controls.Add(this.boton_acceder);
            this.Controls.Add(this.label_clave);
            this.Controls.Add(this.label_nombre);
            this.Controls.Add(this.rtb_clave);
            this.Controls.Add(this.rtb_nombre);
            this.Controls.Add(this.label_colegio);
            this.Controls.Add(this.pb_escudo_colegio);
            this.Name = "F_Acceso";
            this.Text = "Acceso";
            ((System.ComponentModel.ISupportInitialize)(this.pb_escudo_colegio)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_clave;
        private System.Windows.Forms.Label label_nombre;
        private System.Windows.Forms.RichTextBox rtb_clave;
        private System.Windows.Forms.RichTextBox rtb_nombre;
        private System.Windows.Forms.Label label_colegio;
        private System.Windows.Forms.PictureBox pb_escudo_colegio;
        private System.Windows.Forms.Button boton_acceder;
    }
}
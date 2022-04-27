namespace p_colegio.Forms
{
    partial class FMenu
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
            this.trackBar_tamanoTexto = new System.Windows.Forms.TrackBar();
            this.label_opciones = new System.Windows.Forms.Label();
            this.label_tamanoTexto = new System.Windows.Forms.Label();
            this.label_pequeno = new System.Windows.Forms.Label();
            this.label_mediano = new System.Windows.Forms.Label();
            this.label_grande = new System.Windows.Forms.Label();
            this.checkBox_temas = new System.Windows.Forms.CheckBox();
            this.checkBox_color = new System.Windows.Forms.CheckBox();
            this.comboBox_idioma = new System.Windows.Forms.ComboBox();
            this.label_idioma = new System.Windows.Forms.Label();
            this.label_gui = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_tamanoTexto)).BeginInit();
            this.SuspendLayout();
            // 
            // trackBar_tamanoTexto
            // 
            this.trackBar_tamanoTexto.LargeChange = 1;
            this.trackBar_tamanoTexto.Location = new System.Drawing.Point(260, 200);
            this.trackBar_tamanoTexto.Maximum = 3;
            this.trackBar_tamanoTexto.Minimum = 1;
            this.trackBar_tamanoTexto.Name = "trackBar_tamanoTexto";
            this.trackBar_tamanoTexto.Size = new System.Drawing.Size(314, 56);
            this.trackBar_tamanoTexto.SmallChange = 2;
            this.trackBar_tamanoTexto.TabIndex = 0;
            this.trackBar_tamanoTexto.TickFrequency = 2;
            this.trackBar_tamanoTexto.Value = 2;
            this.trackBar_tamanoTexto.Scroll += new System.EventHandler(this.trackBar_tamanoTexto_Scroll);
            // 
            // label_opciones
            // 
            this.label_opciones.AutoSize = true;
            this.label_opciones.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_opciones.Location = new System.Drawing.Point(25, 25);
            this.label_opciones.Name = "label_opciones";
            this.label_opciones.Size = new System.Drawing.Size(141, 36);
            this.label_opciones.TabIndex = 1;
            this.label_opciones.Text = "Opciones";
            // 
            // label_tamanoTexto
            // 
            this.label_tamanoTexto.AutoSize = true;
            this.label_tamanoTexto.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_tamanoTexto.Location = new System.Drawing.Point(82, 200);
            this.label_tamanoTexto.Name = "label_tamanoTexto";
            this.label_tamanoTexto.Size = new System.Drawing.Size(165, 25);
            this.label_tamanoTexto.TabIndex = 2;
            this.label_tamanoTexto.Text = "Tamano de texto:";
            // 
            // label_pequeno
            // 
            this.label_pequeno.AutoSize = true;
            this.label_pequeno.Location = new System.Drawing.Point(242, 232);
            this.label_pequeno.Name = "label_pequeno";
            this.label_pequeno.Size = new System.Drawing.Size(62, 16);
            this.label_pequeno.TabIndex = 3;
            this.label_pequeno.Text = "Pequeno";
            // 
            // label_mediano
            // 
            this.label_mediano.AutoSize = true;
            this.label_mediano.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mediano.Location = new System.Drawing.Point(376, 232);
            this.label_mediano.Name = "label_mediano";
            this.label_mediano.Size = new System.Drawing.Size(88, 25);
            this.label_mediano.TabIndex = 4;
            this.label_mediano.Text = "Mediano";
            // 
            // label_grande
            // 
            this.label_grande.AutoSize = true;
            this.label_grande.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_grande.Location = new System.Drawing.Point(504, 232);
            this.label_grande.Name = "label_grande";
            this.label_grande.Size = new System.Drawing.Size(114, 36);
            this.label_grande.TabIndex = 5;
            this.label_grande.Text = "Grande";
            // 
            // checkBox_temas
            // 
            this.checkBox_temas.AutoSize = true;
            this.checkBox_temas.Checked = true;
            this.checkBox_temas.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_temas.Location = new System.Drawing.Point(272, 323);
            this.checkBox_temas.Name = "checkBox_temas";
            this.checkBox_temas.Size = new System.Drawing.Size(98, 20);
            this.checkBox_temas.TabIndex = 6;
            this.checkBox_temas.Text = "Usar temas";
            this.checkBox_temas.UseVisualStyleBackColor = true;
            this.checkBox_temas.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // checkBox_color
            // 
            this.checkBox_color.AutoSize = true;
            this.checkBox_color.Checked = true;
            this.checkBox_color.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox_color.Location = new System.Drawing.Point(466, 322);
            this.checkBox_color.Name = "checkBox_color";
            this.checkBox_color.Size = new System.Drawing.Size(93, 20);
            this.checkBox_color.TabIndex = 7;
            this.checkBox_color.Text = "Usar Color";
            this.checkBox_color.UseVisualStyleBackColor = true;
            this.checkBox_color.CheckedChanged += new System.EventHandler(this.checkBox2_CheckedChanged);
            // 
            // comboBox_idioma
            // 
            this.comboBox_idioma.FormattingEnabled = true;
            this.comboBox_idioma.Items.AddRange(new object[] {
            "Espanol",
            "English",
            "한글이"});
            this.comboBox_idioma.Location = new System.Drawing.Point(272, 114);
            this.comboBox_idioma.Name = "comboBox_idioma";
            this.comboBox_idioma.Size = new System.Drawing.Size(262, 24);
            this.comboBox_idioma.TabIndex = 8;
            this.comboBox_idioma.Text = "Espanol";
            this.comboBox_idioma.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label_idioma
            // 
            this.label_idioma.AutoSize = true;
            this.label_idioma.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_idioma.Location = new System.Drawing.Point(82, 110);
            this.label_idioma.Name = "label_idioma";
            this.label_idioma.Size = new System.Drawing.Size(76, 25);
            this.label_idioma.TabIndex = 9;
            this.label_idioma.Text = "Idioma:";
            // 
            // label_gui
            // 
            this.label_gui.AutoSize = true;
            this.label_gui.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gui.Location = new System.Drawing.Point(82, 317);
            this.label_gui.Name = "label_gui";
            this.label_gui.Size = new System.Drawing.Size(52, 25);
            this.label_gui.TabIndex = 10;
            this.label_gui.Text = "GUI:";
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(706, 24);
            this.menuStrip1.TabIndex = 11;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // F_Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(706, 397);
            this.Controls.Add(this.label_gui);
            this.Controls.Add(this.label_idioma);
            this.Controls.Add(this.comboBox_idioma);
            this.Controls.Add(this.checkBox_color);
            this.Controls.Add(this.checkBox_temas);
            this.Controls.Add(this.label_grande);
            this.Controls.Add(this.label_mediano);
            this.Controls.Add(this.label_pequeno);
            this.Controls.Add(this.label_tamanoTexto);
            this.Controls.Add(this.label_opciones);
            this.Controls.Add(this.trackBar_tamanoTexto);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "F_Menu";
            this.Text = "Opciones";
            ((System.ComponentModel.ISupportInitialize)(this.trackBar_tamanoTexto)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar trackBar_tamanoTexto;
        private System.Windows.Forms.Label label_opciones;
        private System.Windows.Forms.Label label_tamanoTexto;
        private System.Windows.Forms.Label label_pequeno;
        private System.Windows.Forms.Label label_mediano;
        private System.Windows.Forms.Label label_grande;
        private System.Windows.Forms.CheckBox checkBox_temas;
        private System.Windows.Forms.CheckBox checkBox_color;
        private System.Windows.Forms.ComboBox comboBox_idioma;
        private System.Windows.Forms.Label label_idioma;
        private System.Windows.Forms.Label label_gui;
        private System.Windows.Forms.MenuStrip menuStrip1;
    }
}
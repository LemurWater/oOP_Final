using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using p_colegio.Sistema;


namespace p_colegio.Forms
{
    public partial class F_Menu : Form
    {
        public F_Menu()
        {
            InitializeComponent();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            try
            {
                switch (trackBar1.Value)
                {
                    case 1:
                        Opciones.Cambiar_Tamano_Texto(TamanoTexto_Type.Pequeno);
                        break;

                    case 2:
                        Opciones.Cambiar_Tamano_Texto(TamanoTexto_Type.Mediano);
                        break;

                    case 3:
                        Opciones.Cambiar_Tamano_Texto(TamanoTexto_Type.Grande);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Form: F_Menu - Metodo: trackBar1_Scroll() = " + ex);
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox1.SelectedIndex)
                {
                    case 1:
                        Opciones.Cambiar_Idioma(Language_Type.Espanol);
                        break;

                    case 2:
                        Opciones.Cambiar_Idioma(Language_Type.English);
                        break;

                    case 3:
                        Opciones.Cambiar_Idioma(Language_Type.한국어);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Form: F_Menu - Metodo: comboBox1_SelectedIndexChanged() = " + ex);
            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                switch(checkBox1.Checked)
                {
                    case true:
                        Opciones.Cambiar_Tema(true);
                        break;

                    case false:
                        Opciones.Cambiar_Tema(false);
                        break;

                    default:
                        Opciones.Cambiar_Tema(true);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Form: F_Menu - Metodo: checkBox1_CheckedChanged() = " + ex);
            }
        }

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {
            try
            {
                foreach(Form form in l_forms)
                {

                }
            }
            catch (Exception ex)
            {
                throw new Exception("Form: F_Menu - Metodo: checkBox2_CheckedChanged() = " + ex);
            }
        }
    }
}

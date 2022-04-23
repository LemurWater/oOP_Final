using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
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
        //Constructores
        public F_Menu()
        {
            InitializeComponent();

            Text = Text + Opcione.Marca_de_la_empresa;
        }




        //Metodos Forms

        public void menu_Click(object sender, EventArgs e)
        {
            try
            {
                switch (sender.ToString())
                {
                    case "Reiniciar":
                        MessageBox.Show("Reiniciar");
                        break;

                    case "Informacion":
                        MessageBox.Show("Informacion");
                        break;

                    case "Temas":
                        Form F_Tema = new F_Tema();
                        F_Tema.Show();
                        break;

                    case "Opciones":
                        Form form_menu = new F_Menu();
                        form_menu.Show();
                        break;

                    case "Registro":
                        foreach (var variable in Opcione.Directorio.GetFiles("*.exe"))
                        {
                            Process.Start(variable.FullName);
                            break;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Forms: F_Imagen - Metodo: menu_Click" + ex);
            }
        }



        //Metodos
        private void trackBar_tamanoTexto_Scroll(object sender, EventArgs e)
        {
            try
            {
                switch (trackBar_tamanoTexto.Value)
                {
                    case 1:
                        Opcione.Cambiar(TamanoTexto_Type.Pequeno);
                        break;

                    case 2:
                        Opcione.Cambiar(TamanoTexto_Type.Mediano);
                        break;

                    case 3:
                        Opcione.Cambiar(TamanoTexto_Type.Grande);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Form: F_Menu - Metodo: trackBar_tamanoTexto_Scroll() = " + ex);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox_idioma.SelectedIndex)
                {
                    case 1:
                        Opcione.Cambiar(Language_Type.Espanol);
                        break;

                    case 2:
                        Opcione.Cambiar(Language_Type.English);
                        break;

                    case 3:
                        Opcione.Cambiar(Language_Type.한국어);
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
                switch(checkBox_temas.Checked)
                {
                    case true:
                        Opcione.Cambiar(true, true);
                        break;

                    case false:
                        Opcione.Cambiar(false, true);
                        break;

                    default:
                        Opcione.Cambiar(true, true);
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
                switch (checkBox_color.Checked)
                {
                    case true:
                        Opcione.Cambiar(true, false);
                        break;

                    case false:
                        Opcione.Cambiar(false, false);
                        break;

                    default:
                        Opcione.Cambiar(true, false);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Form: F_Menu - Metodo: checkBox2_CheckedChanged() = " + ex);
            }
        }

    }
}

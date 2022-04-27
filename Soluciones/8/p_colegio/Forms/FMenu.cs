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
using p_colegio.Enumeraciones;


namespace p_colegio.Forms
{

    public partial class FMenu : Form
    {
        //Constructores
        public FMenu()
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
                        Form F_Tema = new FTema();
                        F_Tema.Show();
                        break;

                    case "Opciones":
                        Form form_menu = new FMenu();
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
                throw new Exception("FORM: F_Imagen - METODO: menu_Click = " + ex);
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
                        Opcione.Cambiar(ETamano_Texto.Pequeno);
                        break;

                    case 2:
                        Opcione.Cambiar(ETamano_Texto.Mediano);
                        break;

                    case 3:
                        Opcione.Cambiar(ETamano_Texto.Grande);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("FORM: F_Menu - METODO: trackBar_tamanoTexto_Scroll = " + ex);
            }
        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                switch (comboBox_idioma.SelectedIndex)
                {
                    case 1:
                        Opcione.Cambiar(EIdioma.Espanol);
                        break;

                    case 2:
                        Opcione.Cambiar(EIdioma.English);
                        break;

                    case 3:
                        Opcione.Cambiar(EIdioma.한국어);
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("FORM: F_Menu - METODO: comboBox1_SelectedIndexChanged = " + ex);
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
                throw new Exception("FORM: F_Menu - METODO: checkBox1_CheckedChanged = " + ex);
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
                throw new Exception("FORM: F_Menu - METODO: checkBox2_CheckedChanged = " + ex);
            }
        }

        //Metodos de todas las Forms
        public void Actualizar_Idioma()
        {
            try
            {
                Label l_titulo;
                List<Label> l_subtitulos = new List<Label>();
                List<Label> l_textos = new List<Label>();

                //Index BORRAR
                switch (Opcione.Idioma)
                {
                    case EIdioma.Espanol:
                        l_titulo = Idioma.;
                }


            }
            catch (Exception ex)
            {
                throw new Exception("FORM: F_Menu - METODO: Actualizar_Idioma = " + ex);
            }
        }
    }
}

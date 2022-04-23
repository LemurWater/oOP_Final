using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


using System.IO;
using System.Diagnostics;

using p_colegio.Sistema;

namespace p_colegio.Forms
{
    public partial class F_Acceso : Form
    {
        //Atributos


        //Control
        private string clave = "";
        private bool control_clave = true;
        bool control_nombre = true;


        //Constructores
        public F_Acceso()
        {

            InitializeComponent();




            Text = Opcione.Nombre_del_programa + "  -  Acceso   " + Opcione.Version_del_programa + "                " + Opcione.Marca_de_la_empresa;

            ToolStrip tmp = Barra.Barra_De_Opciones(this, menu_Click);
        }


        //Accesores
        public string Clave
        {
            get
            {
                return clave;
            }
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Form: F_Acceso - Accesor Clave");
                }
                else clave = value;
            }
        }





        // Barra de Opciones
        public void Menu_Reiniciar()
        {
            //goto?
        }
        
        
        //Apariencia
        public void Cambiar_Colegio(string nombre)
        {
            try
            {
                label_colegio.Text = nombre;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Forms: F_Acceso - Metodo: Cambiar_Colegio(string)" + ex);
            }
        }
        public void Cambiar_Colegio(Bitmap escudo)
        {
            try
            {
                pb_escudo_colegio.Image = escudo;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Forms: F_Acceso - Metodo: Cambiar_Colegio(Bitmap)" + ex);
            }
        }
        public void Cambiar_Idioma(Language_Type nuevo_idioma)
        {
            
            try
            {
                switch (nuevo_idioma)
                {
                    case Language_Type.Espanol:
                        label_nombre.Text = Opcione.Obtener_Idioma(Language_Type.Espanol, "Nombre") + ':';
                        label_clave.Text = Opcione.Obtener_Idioma(Language_Type.Espanol, "ID") + ':';
                        boton_acceder.Text = Opcione.Obtener_Idioma(Language_Type.Espanol, "Acceder");
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Forms: F_Acceso - Metodo: Cambiar_Idioma(Language_Type)" + ex);
            }
        }
        public void Cambiar_Fondo(Color color)
        {
            try
            {
                BackColor = color;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Forms: F_Acceso - Metodo: Cambiar_Fondo(Color)" + ex);
            }
        }
        public void Cambiar_Fondo(Bitmap imagen)
        {
            try
            {
                BackgroundImage = imagen;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Forms: F_Acceso - Metodo: Cambiar_Fondo(Bitmap)" + ex);
            }
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
                throw new Exception("Error Forms: F_Acceso - Metodo: menu_Click" + ex);
            }
        }




        private void boton_acceder_Click(object sender, EventArgs e)
        {
            try
            {              
                if (rtb_nombre.Text is String && clave == "123")
                {
                    MessageBox.Show("Bienvenid@ " + rtb_nombre.Text
                    + " ...\n\n\n\n\n                                             Nombre_Colegio");
                   
                    Form form_informacion = new F_Informacion();
                    form_informacion.Show();

                    Hide();
                }

                else MessageBox.Show("Error! Clave no valida. Intentelo de nuevo ...");
            }
            catch (Exception ex)
            {
                throw new Exception("Error Forms: F_Acceso - Metodo: boton_acceder_Click" + ex);
            }
        }

        private void rtb_nombre_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                switch(control_nombre)
                {
                    case true:
                        rtb_nombre.Text = "";
                        control_nombre = false;
                        break;

                    case false:
                        break;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Error Forms: F_Acceso - Metodo: rtb_nombre_MouseDown" + ex);
            }
        }

        private void rtb_clave_MouseDown(object sender, MouseEventArgs e)
        {
            try
            {
                
                switch(control_clave)
                {
                    case true:
                        rtb_clave.Text = "";
                        control_clave = false;
                        break;

                    case false:
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Forms: F_Acceso - Metodo: rtb_clave_MouseDown" + ex);
            }
        }

        private void rtb_clave_TextChanged(object sender, EventArgs e)
        {
            try
            {
                byte tmp_tamano = 0;

                if (rtb_clave.Text.Length == 0)
                {

                }
                else if(tmp_tamano > rtb_clave.Text.Length)
                {
                    clave.Remove(clave.Length, 1);
                    tmp_tamano--;
                }
                else
                {
                    clave += rtb_clave.Text[rtb_clave.Text.Count() - 1];
                    string tmp_string = "";
                    foreach (char texto_clave in rtb_clave.Text)
                    {
                        tmp_string += "*";
                    }
                    rtb_clave.Text = tmp_string;

                    SendKeys.Send("{End}");
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Forms: F_Acceso - Metodo: rtb_clave_TextChanged" + ex);
            }
        }

        private void rtb_nombre_TextChanged(object sender, EventArgs e) // Falta
        {
            List<string> a = new List<string>();
            try
            {
                foreach (string nombre_estudiante in a)
                {
                    if (nombre_estudiante == rtb_nombre.Text)
                    {
                        //Cambiar_Colegio(Nombre_del_colegio);
                        //Cambiar_Colegio(Escudo_del_colegio);
                        //BackColor = Color_colegio;
                    }
                }       
            }
            catch(Exception ex)
            {
                throw new Exception("Error Forms: F_Acceso - Metodo: rtb_nombre_TextChanged" + ex);
            }
        }
    }
}

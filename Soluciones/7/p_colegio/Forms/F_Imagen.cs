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
using System.Drawing;

using p_colegio.Sistema;

using System.Diagnostics;


namespace p_colegio.Forms
{

    public partial class F_Imagen : Form
    {

        //Atributos

        public static string direccion_corta = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString()).ToString()).ToString()).ToString();
        public static string direccion_larga = direccion_corta + @"\Archivos\GUI\";

        DirectoryInfo d = new DirectoryInfo(direccion_larga);

        public List<Bitmap> l_imagenes = new List<Bitmap>();
        public Bitmap imagen;

        public byte contador_imagenes = 0;



        //Constructores

        public F_Imagen()
        {
            InitializeComponent();




            Text = Opcione.Nombre_del_programa + "  -  Acceso   " + Opcione.Version_del_programa + "                " + Opcione.Marca_de_la_empresa;

            ToolStrip tmp = Barra.Barra_De_Opciones(this, menu_Click);
        }




        //Metodos
        public void Cambiar_Imagen()
        {
            BackgroundImage = l_imagenes[contador_imagenes];

            richTextBox1.Text = "  " + (contador_imagenes + 1) + ".png";
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

        private void F_Imagen_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < d.GetFiles("*.bmp").Length; i++)
            {
                imagen = new Bitmap(direccion_larga + (i + 1).ToString() + ".bmp", true);
                l_imagenes.Add(imagen);
            }

            BackgroundImage = l_imagenes[0];
            richTextBox1.Text = "  1.png";
            button1.BackColor = Color.Red;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(contador_imagenes > 0)
            {
                if (button2.BackColor == Color.Red)
                    button2.BackColor = Color.LightGray;

                switch (contador_imagenes)
                {
                    case 1:
                        button1.BackColor = Color.Red;
                        break;
                }
                contador_imagenes--;
                Cambiar_Imagen();
            }
        }


        private void button2_Click(object sender, EventArgs e)
        {
            if (contador_imagenes < d.GetFiles("*.bmp").Length -1)
            {
                if(button1.BackColor == Color.Red)
                    button1.BackColor = Color.LightGray;

                switch (contador_imagenes)
                {
                    case 13:
                        button2.BackColor = Color.Red;
                        break;
                }
                contador_imagenes++;
                Cambiar_Imagen();
            }
        }
    }
}

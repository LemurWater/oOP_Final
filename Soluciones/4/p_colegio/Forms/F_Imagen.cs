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

namespace p_colegio.Forms
{
    public partial class F_Imagen : Form
    {

        public static string direccion_corta = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString()).ToString()).ToString()).ToString();
        public static string direccion_larga = direccion_corta + @"\Archivos\GUI\";

        DirectoryInfo d = new DirectoryInfo(direccion_larga);
        public List<Bitmap> l_imagenes = new List<Bitmap>();
        public Bitmap imagen;

        public byte contador_imagenes = 0;

        public F_Imagen()
        {
            InitializeComponent();
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
        public void Cambiar_Imagen()
        {
            BackgroundImage = l_imagenes[contador_imagenes];

            richTextBox1.Text = "  " + (contador_imagenes + 1) + ".png";
        }
    }
}

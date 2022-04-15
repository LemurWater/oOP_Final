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

        public static string direccion = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString();
        public static string direccion2 = @"X:\=Projects GitHub\U\U_oOP\oOP Final\oOP_Final\Soluciones\2\p_colegio\Archivos\Apariencia";

        DirectoryInfo d = new DirectoryInfo(direccion2);
        public List<Bitmap> l_imagenes = new List<Bitmap>();
        public Bitmap imagen;

        public F_Imagen()
        {
            InitializeComponent();
        }

        private void F_Imagen_Load(object sender, EventArgs e)
        {
            foreach (var _imagen in d.GetFiles("*.png"))
            {
                //imagen = _imagen as Bitmap;
                //Directory.Move(_imagen.FullName, filepath + "\\TextFiles\\" + _imagen.Name);


                imagen = new Bitmap(@"X:\=Projects GitHub\U\U_oOP\oOP Final\oOP_Final\Soluciones\2\p_colegio\Archivos\Apariencia\1.bmp", true);
                l_imagenes.Add(imagen);
                imagen = new Bitmap(@"X:\=Projects GitHub\U\U_oOP\oOP Final\oOP_Final\Soluciones\2\p_colegio\Archivos\Apariencia\2.bmp", true);
                l_imagenes.Add(imagen);


                richTextBox1.Text = imagen.ToString() + "\n";
            }
            //richTextBox1.Text = richTextBox1.Text + direccion;
            richTextBox1.Text = direccion2;

            pictureBox1.Image = imagen;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = l_imagenes[0];
            BackgroundImage = l_imagenes[0];
        }

        private void button2_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = l_imagenes[1];
            BackgroundImage = l_imagenes[1];
        }
    }
}

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace p_colegio.Forms
{
    public partial class F_Acceso : Form
    {

        public MenuStrip menu = new MenuStrip();


        public F_Acceso()
        {

            //MenuStrip
            Controls.Add(menu);
            menu.Name = "Menu";
            menu.Dock = DockStyle.Top;


            // Create a Menu Item
            ToolStripMenuItem menu_reiniciar = new ToolStripMenuItem("Reiniciar", null, menu_Click);
            ToolStripMenuItem menu_informacion = new ToolStripMenuItem("Informacion");
            ToolStripMenuItem menu_temas = new ToolStripMenuItem("Temas");
            ToolStripMenuItem menu_opciones = new ToolStripMenuItem("Opciones");
            ToolStripMenuItem menu_registro = new ToolStripMenuItem("Registro");
            menu_reiniciar.Text = "Reiniciar";
            menu_informacion.Text = "Informacion";
            menu_temas.Text = "Temas";
            menu_opciones.Text = "Opciones";
            menu_registro.Text = "Registro";

            menu_reiniciar.TextAlign = ContentAlignment.MiddleCenter;
            menu_informacion.MergeAction = MergeAction.Insert;           
            menu_reiniciar.ToolTipText = "Click Me";

            menu.RightToLeft = RightToLeft.Yes;

            //menu_informacion.MergeIndex = 2;
            //menu_reiniciar.BackColor = Color.OrangeRed;
            //menu_reiniciar.ForeColor = Color.Black;
            //menu_reiniciar.Font = newFont("Georgia", 16);

            //menu_reiniciar.Click += new EventHandler(menu_Click);
            menu_informacion.Click += new EventHandler(menu_Click);
            menu_temas.Click += new EventHandler(menu_Click);
            menu_opciones.Click += new EventHandler(menu_Click);
            menu_registro.Click += new EventHandler(menu_Click);

            Font tmp_font = new Font(menu_registro.Font.FontFamily,
                                     menu_registro.Font.Size,
                                     FontStyle.Bold);

            menu_registro.Font = tmp_font;

            Font tmp_font2 = new Font(menu_registro.Font.FontFamily,
                                         menu_registro.Font.Size,
                                         FontStyle.Italic);

            menu_reiniciar.Font = tmp_font2;

            Font tmp_font3 = new Font(menu_registro.Font.FontFamily,
                                         menu_registro.Font.Size,
                                         FontStyle.Underline);

            menu_opciones.Font = tmp_font3;

            menu.Items.Add(menu_registro);
            menu.Items.Add(menu_temas);
            menu.Items.Add(menu_informacion); 
            menu.Items.Add(menu_opciones);
            menu.Items.Add(menu_reiniciar);


            //ToolStripMenuItem menu = new ToolStripMenuItem(submenuName);

            //menu_reiniciar.DropDown.Items.Add(menu);
            InitializeComponent();
        }

        public void menu_Click(object sender, EventArgs e)
        {
            //var menuItem = sender as MenuItem;
            //string menuText = menuItem.Text;
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

            }
        }


        public void Menu_Reiniciar()
        {

        }
        private void boton_acceder_Click(object sender, EventArgs e)
        {
            try
            {              
                if (true)
                {
                    MessageBox.Show("Bienvenid@ " + "[Nombre_Usuario]"
                    + " ...\n\n\n\n\n                                             Nombre_Colegio");
                   
                    Form form_informacion = new F_Informacion();
                    form_informacion.Show();

                    this.Hide();
                }

                else MessageBox.Show("Error! Clave no valida. Intentelo de nuevo ...");
            }
            catch (Exception ex)
            {
                throw new Exception("Error Forms: F_Acceso - Metodo: boton_acceder_Click" + ex);
            }
        }
    }
}

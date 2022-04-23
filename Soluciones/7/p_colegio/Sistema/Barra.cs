using System;

using System.Drawing;
using System.Windows.Forms;


namespace p_colegio.Sistema
{

    internal static class Barra
    {

        //public MenuStrip menu = new MenuStrip();

        public static MenuStrip Barra_De_Opciones(Form form, EventHandler evento)
        {
            try
            {
                //MenuStrip
                MenuStrip menu = new MenuStrip();

                form.Controls.Add(menu);
                menu.Name = "Menu";
                menu.Dock = DockStyle.Top;


                // Create a Menu Item
                ToolStripMenuItem menu_reiniciar = new ToolStripMenuItem("Reiniciar");
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



                //menu_informacion.MergeIndex = 2;
                //menu_reiniciar.BackColor = Color.OrangeRed;
                //menu_reiniciar.ForeColor = Color.Black;
                //menu_reiniciar.Font = newFont("Georgia", 16);

                menu_reiniciar.Click += new EventHandler(evento);
                menu_informacion.Click += new EventHandler(evento);
                menu_temas.Click += new EventHandler(evento);
                menu_opciones.Click += new EventHandler(evento);
                menu_registro.Click += new EventHandler(evento);


                return menu;

            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Tema - Metodo: Hacer" + ex);
            }

        }
    }
}

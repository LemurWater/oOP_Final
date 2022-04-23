﻿using System;
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
    public partial class F_Informacion : Form
    {

        public MenuStrip menu = new MenuStrip();


        public F_Informacion()
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
            menu_reiniciar.Text = "Reiniciar";
            menu_informacion.Text = "Informacion";
            menu_temas.Text = "Temas";
            menu_opciones.Text = "Opciones";

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



            menu.Items.Add(menu_opciones);
            menu.Items.Add(menu_temas);
            menu.Items.Add(menu_informacion);
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

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            try              
            {
                /*
                if(usuario is Estudiante)
                {
                   MessageBox.(No tiene acceso a esta funcion)
                else if(usuario is Profesor)
                {
                registrar evaluiacion()
                }
                */
            }
            catch
            {

            }
        }
    }
}
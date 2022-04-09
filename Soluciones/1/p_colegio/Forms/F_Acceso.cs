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
        public F_Acceso()
        {
            InitializeComponent();
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

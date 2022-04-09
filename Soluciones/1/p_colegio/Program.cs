using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using p_colegio.Forms;



namespace p_colegio
{
    internal class Program
    {
        private static bool usar_forms = false;
        static void Main(string[] args)
        {
            usar_forms = true;

            Cargar_Forms();
        }

        public static bool Cargar_Forms()
        {
            try
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new F_Acceso());
                return true;
            }
            catch(Exception ex)
            {
                return false;
                throw new Exception("Error al cargar forms: F_Acceso" + ex);
            }
        }
    }
}

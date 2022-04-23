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

        private static string ascii =
            "╔══════════════════════╗" +
            "║	                    ║" +
            "║	                    ║" +
            "║	                    ║" +
            "║	                    ║" +
            "║	                    ║" +
            "║	                    ║" +
            "╠═══════════════╦══════╣" +
            "║	           ® ║ 𝟚𝟘𝟚𝟚 ║" +
            "╚═══════════════╩══════╝";


        private static bool usar_forms = false;
        public static string marca_de_la_empresa = "prueba®";


        static void Main(string[] args)
        {                
            
            //Inicio
            Console.ForegroundColor = ConsoleColor.Gray;
            //Console.BackgroundColor = ConsoleColor.White;
            Console.SetWindowSize(80, 47);
            Console.WriteLine("\n  " + marca_de_la_empresa + "\n\n");



            //ASCII
            Console.OutputEncoding = Encoding.Unicode;

            Console.SetWindowSize(79, 48);
            string[] lineas_ascii = ascii.Split(',');

            foreach (string linea in lineas_ascii)
            {
                switch (linea)
                {
                    case "C":
                        break;

                    case "M":
                        break;

                    case "Y":
                        break;

                    case "K":

                        break;

                    default:
                        break;
                }
                Console.WriteLine("  " + linea);
            }




            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.Write("\n  Presione ");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("[");
            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("ENTER");
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("] ");
            //ASCII fin



            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("para continuar ...");

            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("  Y");
            Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Cyan;
            


            if(true)
            {
                //Forms
                usar_forms = true;
            }
            else
            {
                //Forms
                usar_forms = true;
            }



            

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

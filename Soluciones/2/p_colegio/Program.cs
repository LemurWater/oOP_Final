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

                                        "KKKKKKKKKKKKKKKKKCKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKK......KK.....YKY....KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKK..YKKY....KKK..KY.KK.Y...K....KK....YK...C...K........K...CKKKKKKKKKK," +
                                        "KKKKKK..KKKKY..KKKKK.YY....K..K..KK....KK..K.KKY.Y.K..K..KY.K..YKKKKKKKKKKK," +
                                        "KKKKKK.......Y.......KY.KKKK..KY.YY..Y.YY.YK.KK..Y.K..K..KC.KY...KKKKKKKKKK," +
                                        "KKKKKKKC....KKK.....KKC.KKKK.YKKC..YKKY.Y.YK.KKY.Y.KYYKC.KK.K...KKKKKKKKKKK," +
                                        "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK....KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKK..KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKK..Y.YKKKKKKCYKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKK..YY..KKKY..YKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKK.YKKY.KKKY.KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKK..YY..KKK..KKKKKKYKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKYY..YKKKKKYKKKKKKYKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKKKKK.YKKKKKKKKKKK.YKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKKKKY..KKKKKKKKKKK.YKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKKKKY.YKKKKKKKKKKK.YKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKYY...KKKKKKKKKKKKKKKKKY...KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKK.YY..KKKKKKKKKKKKKKKY.YY..KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKY.YYY.KKKKKKKKKKKKKKK..CCYYKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKK..YYYKKKKKKKKKKKKKKKK..Y.KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKKK....KKKKKKKKKKKKKKKKKKKKKKY....CKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKC.YKKKKKKKKKKKKKKKKKKKKKKKKK..KK..KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKY.KKKKKKKKKKKKKKKKKKKKKKKKKK..KKY.KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKK....YKKKKKKKKKKKKKKKKKKKKKKY.KKY.KKY.YKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKKK..YKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK...KKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKKK..YCKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK.KKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKKKY.KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK.YKKKKKKKKKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKKKY.YKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKC.CKKK.Y.KKKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKKKK..CKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK.YY..KKKKKKKKKKKKKKKKKKKKK," +
                                        "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKC.YCCYKKKKKK.KKKKKKKKKKKKKK," +
                                        "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK..Y.YKKKKKK.KKKKKKKKKKKKKK," +
                                        "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK.....KKKKKKKKKKKKKK," +
                                        "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK..KKK.KKKKKKKKKKKKKK," +
                                        "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK..KKY.KKKKKKKKKKKKKK," +
                                        "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK..Y..KY......KKKKKK," +
                                        "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK.Y...C.YKKKKK," +
                                        "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK.K...K..KKKKK," +
                                        "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKK...Y...KKKKKK," +
                                        "KKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKKYCKKKKKKKK,";


        private static bool usar_forms = false;
        private static string marca_de_la_empresa = "prueba®";


        static void Main(string[] args)
        {                
            
            //Inicio
            Console.ForegroundColor = ConsoleColor.Gray;
            //Console.BackgroundColor = ConsoleColor.White;
            Console.SetWindowSize(80, 47);
            Console.WriteLine("\n  " + marca_de_la_empresa + "\n\n");



            //ASCII
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

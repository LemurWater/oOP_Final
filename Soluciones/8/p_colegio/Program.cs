using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;

using p_colegio.Forms;
using p_colegio.Sistema;


namespace p_colegio
{


    internal class Program
    {


        static void Main(string[] args)
        {
            try
            {
                //Inicio
                Console.ForegroundColor = ConsoleColor.Gray;
                //Console.BackgroundColor = ConsoleColor.White;
                Console.SetWindowSize(80, 47);
                Console.WriteLine("\n  " + Opcione.Marca_de_la_empresa + "\n");



                //ASCII
                var tmp_encoding = Console.OutputEncoding;
                Console.OutputEncoding = System.Text.Encoding.UTF8; //Console.OutputEncoding = Encoding.Unicode;


                Console.SetWindowSize(44, 10 + 8);
                string[] lineas_ascii = Opcione.Ascii.Split(',');

                foreach (string linea in lineas_ascii)
                {
                    Console.Write("\n     ");

                    foreach (char caracter in linea)
                    {
                        if(caracter == ' ')
                        {

                        }
                        else if (caracter == '╔' ||
                            caracter == '═' ||
                            caracter == '╗' ||
                            caracter == '║' ||
                            caracter == '╠' ||
                            caracter == '╦' ||
                            caracter == '╣' ||
                            caracter == '╚' ||
                            caracter == '╩' || 
                            caracter == '╩' ||
                            caracter == '╝')
                        {
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        }
                        else
                        {
                            switch (caracter)
                            {
                                case '0': // 𝟘
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    break;

                                case '2': // 𝟚
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    break;


                                default:
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    break;
                            }
                        }
                        Console.Write(caracter);
                    }
                }
                Console.WriteLine();
                Console.OutputEncoding = tmp_encoding;



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
                //Console.ReadLine();


                //Forms
                if (Console.ReadLine() == "No")
                {
                    Opcione.Usar_forms = false;
                }
                else
                {
                    Opcione.Usar_forms = true;

                    Cargar_Forms();
                }
                Console.ForegroundColor = ConsoleColor.Cyan;
            }

            catch (Exception ex)
            {
                throw new Exception("Error Program - " + ex);
            }

            finally
            {
                Console.ReadKey();
            }
        }




        public static bool Cargar_Forms()
        {
            try
            {

                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new FAcceso());
                return true;
            }
            catch (Exception ex)
            {
                throw new Exception("Error al cargar forms: F_Acceso - " + ex);
            }
        }
    }
}

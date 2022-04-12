using System;

using System.IO;


namespace p_lector_registro
{

    internal class Program
    {

        private static string marca_de_la_empresa = "prueba®";
        private static string salir_mensaje = "Presione una tecla para salir";


        private static string direccion = Directory.GetParent(Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString()).ToString()
            + @"\Archivos\Registros\"
            + "Registro.txt";


        private static string[] lineas;
        private static string tmp_marca;
        private static StreamReader sr;


        static void Main(string[] args)
        {

            try
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.SetWindowSize(40, 5);
                Console.WriteLine("\n " + marca_de_la_empresa);
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("\n Presione una tecla para continuar ...");
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.ReadLine();
                Console.ForegroundColor = ConsoleColor.Cyan;

                if (Leer_txt() == true)
                {
                    short tmp_tamano = 1;
                    foreach (string linea  in lineas)
                    {                        
                        if(linea.Length > tmp_tamano)
                        {
                            tmp_tamano = (short)linea.Length;
                        }
                    }
                    if(tmp_tamano < 30)
                    {
                        tmp_tamano = 30;
                    }

                    Console.Clear();
                    Console.SetWindowSize(tmp_tamano + 2, lineas.Length + 6);

                    Console.WriteLine();

                    for (byte i = 0; i < lineas.Length; i++)
                    {
                        if (i > 1)
                        {
                            Console.WriteLine(" " + lineas[i]);
                        }
                    }
                    Console.WriteLine();

                    string tmp_espacio = "";
                    for (byte i = 0; i < tmp_tamano / 3; i++)
                    {
                        tmp_espacio += " ";
                    }

                    Console.BackgroundColor = ConsoleColor.Blue;
                    Console.Write(tmp_espacio);
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Write(tmp_espacio);
                    Console.BackgroundColor = ConsoleColor.White;
                    Console.Write(tmp_espacio);
                    Console.BackgroundColor = ConsoleColor.Black;


                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("\n\n  - - - - - - - - - - - - - - - - \n | "
                        + salir_mensaje 
                        + " | \n  - - - - - - - - - - - - - - - - ");
                    Console.ForegroundColor = ConsoleColor.Yellow;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Main Program" + ex);
            }
            finally
            {
                Console.ReadKey();
            }
        }



        public static bool Leer_txt()
        {
            try
            {
                sr = new StreamReader(direccion);

                if (File.Exists(direccion))
                {
                    tmp_marca = sr.ReadLine();

                    if (tmp_marca == marca_de_la_empresa)
                    {

                        lineas = File.ReadAllLines(direccion);


                        for (byte i = 0; i < lineas.Length; i++)
                        {


                            if (string.IsNullOrEmpty(lineas[i]) || string.IsNullOrWhiteSpace(lineas[i]))
                            {
                                string error = String.Format("Error Registrar_Accion: Metodo: Leer_TXT() - Error al leer linea de documento de texto:  {0},  - , {1}:",
                                    i, lineas[i].ToString());


                                throw new Exception(error);
                            }
                        }
                        return true;
                    }
                    else throw new Exception("El archivo de registro es desconocido");
                }
                else throw new Exception("No se a encontrado archivo de registro");
            }
            catch (Exception ex)
            {
                throw new Exception("Error Program - Metodo: Leer_txt" + ex);
            }
        }
    }
}

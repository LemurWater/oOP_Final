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

        private static char simbolito = '░';

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
                    Console.SetWindowSize(tmp_tamano + 2 + 8, lineas.Length + 8 + 8);

                    Console.WriteLine();


                    //Impresiones
                    sbyte espacio = 2;
                    byte centinela = 0;
                    do
                    {
                        Console.Write(" ");
                        switch(centinela)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;

                            case 1:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(simbolito);

                                Console.ForegroundColor = ConsoleColor.Magenta;     
                                break;

                            case 2:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(simbolito);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write(simbolito);
                                

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                        }
                        
                        for (byte i = 0; i < tmp_tamano - (espacio - 1) + 6; i++)
                        {
                            Console.Write(simbolito);
                        }


                        // Final
                        switch (centinela)
                        {
                            case 0:
                                for (byte j = 0; j < 3; j++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    Console.Write(simbolito);
                                }
                                break;

                            case 1:
                                for (byte j = 0; j < 2; j++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.Write(simbolito);
                                }
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(simbolito);
                                break;
                            case 2:
                                for (byte j = 0; j < 1; j++)
                                {
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.Write(simbolito);
                                }
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write(simbolito);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(simbolito);
                                break;
                        }




                        Console.WriteLine();
                        centinela++;
                        espacio++;

                    } while (centinela <3);


                    //Marco
                    Console.Write(" ");
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(simbolito);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(simbolito);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(simbolito);
                    for (int i = 0; i < tmp_tamano + 2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(simbolito);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(simbolito);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(simbolito);

                    Console.WriteLine();




                    //Imprimir cada linea de dato
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    for (byte i = 0; i < lineas.Length; i++)
                    {
                        if (i > 1)
                        {
                            Console.Write(" ");

                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(simbolito);
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(simbolito);
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(simbolito);


                            switch (centinela)
                            {
                                case 0:
                                    Console.ForegroundColor = ConsoleColor.Cyan;
                                    break;

                                case 1:
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    break;

                                case 2:
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    break;
                            }

                            string tmp_espacio2 = ""; //variable
                            for (int j = 0; j < tmp_tamano - lineas[i].Length; j++)
                            {
                                tmp_espacio2 += " ";
                            }

 //                           Console.Write(" " + lineas[i] + tmp_espacio2 + " "); // Imprimir lineas -----

                            switch (lineas[i])
                            {
                                default:
                                    Console.Write(" " + lineas[i] + tmp_espacio2 + " "); // Imprimir lineas -----
                                    break;
                                
                                case ".":
                                    for (int j = 0; j < tmp_tamano + 2; j++)
                                    {
                                        Console.Write(" ");
                                    }
                                    break;
                            }

                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.Write(simbolito);
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.Write(simbolito);
                            Console.ForegroundColor = ConsoleColor.Cyan;
                            Console.Write(simbolito);
                            Console.WriteLine();

                            centinela++;
                            if (centinela > 2)
                            {
                                centinela = 0;
                            }

                        }
                    }

                    //Cerrar marco
                    Console.Write(" ");

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(simbolito);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(simbolito);
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(simbolito);
                    for (int i = 0; i < tmp_tamano + 2; i++)
                    {
                        Console.Write(" ");
                    }
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write(simbolito);
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write(simbolito);
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write(simbolito);

                    Console.WriteLine();


                    string tmp_espacio = "";
                    for (byte i = 0; i < (tmp_tamano + 6) / 3; i++)
                    {
                        tmp_espacio += " ";
                    }






                    //Linea Final
                    espacio = 2;
                    centinela = 0;
                    do
                    {
                        Console.Write(" ");

                        switch (centinela)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(simbolito);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write(simbolito);
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;

                            case 1:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(simbolito);

                                Console.ForegroundColor = ConsoleColor.Magenta;
                                break;

                            case 2:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(simbolito);
                                Console.Write(simbolito);


                                Console.ForegroundColor = ConsoleColor.Cyan;
                                break;
                        }

                        for (byte i = 0; i < tmp_tamano - (espacio + 1 ) + 6; i++)
                        {
                            Console.Write(simbolito);
                        }



                        // Final U
                        switch (centinela)
                        {
                            case 0:

                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.Write(simbolito);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.Write(simbolito);
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(simbolito);
                                break;  

                            case 1:
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                for (int i = 0; i < 4; i++)
                                {
                                    Console.Write(simbolito);
                                }
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                Console.Write(simbolito);
                                break;

                            case 2:
                                Console.ForegroundColor = ConsoleColor.Cyan;
                                for (byte j = 0; j < 5; j++)
                                {
                                    Console.Write(simbolito);
                                }
                                break;
                        }


                        Console.WriteLine();
                        centinela++;
                        espacio++;

                    } while (centinela < 3);



                    //CMYK
                    Console.Write("\n\n\n");
                    Console.Write(" ");

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.Write(tmp_espacio + " ");
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    Console.Write(tmp_espacio);
                    Console.BackgroundColor = ConsoleColor.Yellow;
                    Console.Write(tmp_espacio + " ");
                    Console.BackgroundColor = ConsoleColor.Black;
                    Console.WriteLine();



                    //Mensaje de salida
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write("\n\n  - - - - - - - - - - - - - - - - \n | ");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.Write(salir_mensaje);
                    Console.ForegroundColor = ConsoleColor.DarkGreen;
                    Console.Write(" | \n  - - - - - - - - - - - - - - - - ");
                    Console.ForegroundColor = ConsoleColor.Red;
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

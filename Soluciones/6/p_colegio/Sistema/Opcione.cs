using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;
using System.Drawing;


public enum Language_Type { Espanol, English, 한국어 }
public enum TamanoTexto_Type { Pequeno, Mediano, Grande}


namespace p_colegio.Sistema
{

    internal static class Opcione
    {

        //Atributos
        private static string direccion = Directory.GetCurrentDirectory().ToString();



        private static string direccion_registro_exe = Directory.GetCurrentDirectory().ToString()
                                    + @"\Archivos\Registros\"
                                    + ""; //p_lectorRegistro v0.01.exe

        private static DirectoryInfo directorio = new DirectoryInfo(Direccion_registro_exe);



        private static Language_Type idioma = Language_Type.Espanol;
        private static TamanoTexto_Type tamano_texto = TamanoTexto_Type.Mediano;
        private static bool usar_temas, usar_color;

        private static Color color_fondo;
        private static string imagen_fondo;


        private static List<string> idioma_espanol;
        private static List<string> idioma_ingles;
        private static List<string> idioma_coreano;


        //Empresa-Programa
        private static string marca_de_la_empresa = "prueba®";
        private static string nombre_del_programa = "Plataforma Interactiva";
        private static string version_del_programa = "v 1.02.1";
        private static string ascii =
                                      "╔══════════════════════╦═════════╗" + "," +
                                      "║                      ║ prueba® ║" + "," +
                                      "║                      ╚═════════╣" + "," +
                                      "║                                ║" + "," +
                                      "║                                ║" + "," +
                                      "║                                ║" + "," +
                                      "║                                ║" + "," +
                                      "╠═════════════════════════╦══════╣" + "," +
                                      "║ Plataforma Interactiva® ║ 2022 ║" + "," + //𝟚𝟘𝟚𝟚
                                      "╚═════════════════════════╩══════╝";

        //Control
        private static bool usar_forms = false;




        //Accesores
        public static string Direccion
        {
            get
            {
                return direccion;
            }
        }

        public static string Direccion_registro_exe { get => direccion_registro_exe; set => direccion_registro_exe = value; }// Falta
        public static DirectoryInfo Directorio { get => directorio; set => directorio = value; }




        public static Language_Type Idioma
        {
            get
            {
                return idioma;
            }
            set
            {
                if (value.ToString() == Language_Type.Espanol.ToString()
                    || value.ToString() == Language_Type.English.ToString()
                    || value.ToString() == Language_Type.한국어.ToString())
                {
                    idioma = value;
                }
                else throw new Exception("Clase: Opciones - Accesor: Idioma");
            }
        }
        public static TamanoTexto_Type Tamano_texto
        {
            get
            {
                return tamano_texto;
            }
            set
            {
                
                if (value.ToString() == TamanoTexto_Type.Pequeno.ToString()
                    || value.ToString() == TamanoTexto_Type.Mediano.ToString()
                    || value.ToString() == TamanoTexto_Type.Grande.ToString())
                {
                    tamano_texto = value;
                }
                else throw new Exception("Clase: Opciones - Accesor: Tamano_texto");
            }
        }
        public static bool Usar_temas
        {
            get
            {
                 return usar_temas;
            }
            set
            {
                if(value is Boolean)
                {
                    usar_temas = value;
                }
                else throw new Exception("Clase: Opciones - Accesor: Usar_temas");
            }
        }
        public static bool Usar_color
        {
            get
            {
                return usar_color;
            }
            set
            {
                if (value is Boolean)
                {
                    usar_temas = value;
                }
                else throw new Exception("Clase: Opciones - Accesor: Usar_color");
            }
        }

        public static Color Color_fondo
        {
            get
            {
                return color_fondo;
            }
            set
            {
                if(value.IsEmpty)
                {
                    color_fondo = value;
                }
            }
        }
        public static string Imagen_fondo
        {
            get
            {
                return imagen_fondo;
            }
            set
            {
                if(value.Contains(".bmp"))
                {
                    imagen_fondo = value;
                }
                else throw new Exception("Clase: Opciones - Accesor: Imagen_fondo");
            }
        }

        public static bool Usar_forms
        {
            get
            {
                return usar_forms;
            }

            set
            {
                if (value is Boolean)
                {
                    usar_forms = value;
                }
                else throw new Exception("Clase: Opciones - Accesor: Usar_forms");
            }
        }



        public static List<string> Idioma_espanol
        {
            get
            {
                return idioma_espanol;
            }
            set
            {
                if (value is null)
                {
                    throw new Exception("Clase: Opciones - Accesor: Idioma_espanol");
                }
                else idioma_espanol = value;
            }
        }
        public static List<string> Idioma_ingles
        {
            get
            {
                return idioma_ingles;
            }
            set
            {
                if (value is null)
                {
                    throw new Exception("Clase: Opciones - Accesor: Idioma_ingles");
                }
                else idioma_ingles = value;
            }
        }
        public static List<string> Idioma_coreano
        {
            get
            {
                return idioma_coreano;
            }
            set
            {
                if (value is null)
                {
                    throw new Exception("Clase: Opciones - Accesor: Idioma_coreano");
                }
                else idioma_coreano = value;
            }
        }




        //Empresa
        public static string Marca_de_la_empresa
        {
            get
            {
                return marca_de_la_empresa;
            }
        }

        public static string Ascii
        {
            get
            {
                return ascii;
            }
        }


        public static string Nombre_del_programa
        {
            get
            {
                return nombre_del_programa;
            }
        }
        public static string Version_del_programa
        {
            get
            {
                return version_del_programa;
            }
        }




        //METODOS


        // Preferencias
        public static bool Cargar_Preferencias()
        {
            try
            {
                if (File.Exists(Direccion))
                {
                    // Read a text file line by line.  
                    string[] opciones = File.ReadAllLines(Direccion);

                    if (opciones[0] == Opcione.Marca_de_la_empresa)
                    {

                        switch (opciones[5])
                        {
                            case "		Idioma = Espanol":
                                Idioma = Language_Type.Espanol;
                                break;

                            case "		Idioma = English":
                                Idioma = Language_Type.English;
                                break;

                            case "		Idioma = 한국어":
                                Idioma = Language_Type.한국어;
                                break;

                            default:
                                Idioma = Language_Type.Espanol;
                                break;
                        }

                        switch(opciones[8])
                        {
                            case "		Tamano de texto = Pequeno":
                                Tamano_texto = TamanoTexto_Type.Pequeno;
                                break;

                            case "		Tamano de texto = Mediano":
                                Tamano_texto = TamanoTexto_Type.Mediano;
                                break;

                            case "		Tamano de texto = Grande":
                                Tamano_texto = TamanoTexto_Type.Grande;
                                break;

                            default:
                                Tamano_texto = TamanoTexto_Type.Mediano;
                                break;
                        }

                        switch(opciones[11])
                        {
                            case "		Usar Temas = Si":
                                Usar_temas = true;
                                break;

                            case "		Usar Temas = No":
                                Usar_temas = false;
                                break;

                            default:
                                Usar_temas = true;
                                break;
                        }

                        switch (opciones[12])
                        {
                            case "		Usar Color = Si":
                                usar_color = true;
                                break;

                            case "		Usar Color = No":
                                Usar_color = false;
                                break;

                            default:
                                usar_color = true;
                                break;
                        }
                        string[] op_split = new string[3];


                        op_split = opciones[15].Split(',');


                        byte[] opciones_byte = new byte[3];

                        for (byte i = 0; i < op_split.GetLength(0); i++)
                        {
                            byte.TryParse(op_split[i], out opciones_byte[i]);
                        }

                        Color_fondo = Color.FromArgb(opciones_byte[0], opciones_byte[1], opciones_byte[2]);


                        string tmp_comparar = "		Imagen de fondo =";
                        string[] tmp_string_2 = opciones[16].Split('=');
                        if (tmp_string_2[0] == tmp_comparar)
                        {
                            Imagen_fondo = tmp_string_2[1];
                            return true;
                        }
                        else return false;
                    }
                    else return false;
                }
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Cargar_Opciones() = " + ex);
            }
        }




        public static bool Guardar_Preferencias(string nombre_imagen)
        {
            try
            {                

                if(!File.Exists(Direccion + @"\Preferencias.txt"))
                {
                    using (StreamWriter sw = File.CreateText(Direccion + @"\Preferencias.txt"))


                    return true;
                }

                string espacio = "-------------------------------------------------";
                string[] opciones = 

                    {
                        Opcione.Marca_de_la_empresa,
                        espacio,
                        "Preferencias:",
                        espacio,
                        "	" + "Idioma:",
                        "		" + "Idioma = Espanol",
                        espacio,
                        "	"+ "Tamano de texto:",
                        "		" + "Tamano de texto = mediano",
                        espacio,
                        "	" + "GUI:",
                        "		" + "Usar temas = Si",
                        "		" + "Usar Color = Si",
                        espacio,
                        "	Temas:",
                        "		" + "Color de fondo = 255,255,255",
                        "		" + "Imagen de fondo = " + nombre_imagen,
                        espacio
                    };


                using (StreamWriter sw = new StreamWriter(Direccion + @"\Preferencias.txt", false))
                {
                    foreach (string opcion in opciones)
                        sw.WriteLine(opcion);

                    return true;
                }
            }
            catch(Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Guardar_Opciones() = " + ex);
            }
        }

        




        //Retornar Atributos
        public static List<string> Retornar()
        {
            try
            {
                List<string> tmp_retornar = new List<string>();
                tmp_retornar.Add(Idioma.ToString());
                tmp_retornar.Add(Tamano_texto.ToString());
                tmp_retornar.Add(Usar_temas.ToString());
                tmp_retornar.Add(Usar_color.ToString());
                tmp_retornar.Add(Color_fondo.ToString());

                return tmp_retornar;
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Retornar() = " + ex);
            }
        }





        //Cambiar Atributos
        public static void Cambiar(Language_Type nuevo_idioma)
        {
            try
            {
                Idioma = nuevo_idioma;
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Cambiar(Language_Type) = " + ex);
            }
        }
        public static void Cambiar(TamanoTexto_Type nuevo_tamano)
        {
            try
            {
                Tamano_texto = nuevo_tamano;
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Cambiar(TamanoTexto_Type) = " + ex);
            }
        }
        public static void Cambiar(bool estado, bool temas_o_color)
        {
            try
            {
                switch (temas_o_color)
                {
                    case true:
                        Usar_temas = estado;
                        break;

                    case false:
                        Usar_color = estado;
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Cambiar(bool, bool) = " + ex);
            }
        }

        public static string Obtener_Idioma(Language_Type idioma,string texto)
        {
            try
            {
                string _tmp = "";

                for (byte i = 0; i < Idioma_espanol.Count; i++)
                {
                    if (Idioma_espanol[i] == texto)
                    {

                        switch (idioma)
                        {
                            case Language_Type.Espanol:
                                _tmp = Idioma_espanol[i];
                                break;

                            case Language_Type.English:
                                _tmp = Idioma_ingles[i];
                                break;

                            case Language_Type.한국어:
                                _tmp = Idioma_coreano[i];
                                break;

                            default:
                                _tmp = Idioma_espanol[i];
                                break;
                        }
                    }
                }
                return _tmp;
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Label_Idioma() = " + ex);
            }
        }
    }
}
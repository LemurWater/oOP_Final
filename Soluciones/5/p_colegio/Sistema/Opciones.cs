using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


using System.Windows.Forms;


public enum Language_Type { Espanol, English, 한국어 }
public enum TamanoTexto_Type { Pequeno, Mediano, Grande}


namespace p_colegio.Sistema
{

    internal static class Opciones
    {


        private static Language_Type idioma = Language_Type.Espanol;
        private static TamanoTexto_Type tamano_texto = TamanoTexto_Type.Mediano;
        private static bool usar_temas, usar_color;

        private static byte[] color_fondo = new byte[3];
        private static List<Label> l_labels_titulo;
        private static List<Label> l_labels_texto;
        private static List<Label> l_labels_otros;
        private static List<Label> l_labels_todas;

        //Cambiar todo
        private static string[,] textos_idiomas;
        private static List<Form> l_forms;
        public static string direccion = "";
        public static List<Bitmap> l_imagenes;


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
                if(value == true || value == false)
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
                if (value == true || value == false)
                {
                    usar_temas = value;
                }
                else throw new Exception("Clase: Opciones - Accesor: Usar_color");
            }
        }

        public static byte[] Color_fondo
        {
            get
            {
                return color_fondo;
            }
            set
            {
                if (value is byte[])
                {
                    color_fondo = value;
                }
                else throw new Exception("Clase: Opciones - Accesor: Color_fondo");
            }
        }

        public static List<Form> L_forms
        {
            get
            {
                return l_forms;
            }
            set
            {
                if(value is List<Form>)
                {
                    l_forms = value;
                }
                else throw new Exception("Clase: Opciones - Accesor: L_forms");
            }
        }
        public static string[,] Textos_idiomas { get => textos_idiomas; set => textos_idiomas = value; }


        // Metodos de OPCIONES
        public static bool Cargar_Preferencias()
        {
            try
            {
                if (File.Exists(direccion))
                {
                    // Read a text file line by line.  
                    string[] opciones = File.ReadAllLines(direccion);

                    if (opciones[0] == Program.marca_de_la_empresa)
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

                        for (int i = 0; i < op_split.GetLength(0); i++)
                        {
                            byte.TryParse(op_split[i], out opciones_byte[i]);
                        }

                        Color_fondo = opciones_byte;

                        return true;
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

                if(!File.Exists(direccion + @"\Preferencias.txt"))
                {
                    using (StreamWriter sw = File.CreateText(direccion + @"\Preferencias.txt"))


                    return true;
                }

                string espacio = "-------------------------------------------------";
                string[] opciones = 

                    {
                        Program.marca_de_la_empresa,
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


                using (StreamWriter sw = new StreamWriter(direccion + @"\Preferencias.txt", false))
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

        //Agregar muchas opciones
        public static void Agregar_Label(Label nueva_label)
        {
            try
            {
                l_labels_texto.Add(nueva_label);
            }
            catch(Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Agregar_Label() = " + ex);
            }
        }
        public static void Agregar_Form(Form form)
        {
            try
            {
                L_forms.Add(form);
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Agregar_Form() = " + ex);
            }
        }
        public static void Cambiar_Tamano_Texto(TamanoTexto_Type nuevo_tamano)
        {
            try 
            {
                float tamano;
                switch (nuevo_tamano)
                {
                    case TamanoTexto_Type.Pequeno:
                        tamano = 7.8f;
                            break;

                    case TamanoTexto_Type.Mediano:
                        tamano = 12f;
                        break;

                    case TamanoTexto_Type.Grande:
                        tamano = 18f;
                        break;

                    default:
                        tamano = 12f;
                        break;
                }


                Tamano_texto = nuevo_tamano;
                //Cambiar todos los textos
                foreach (Label label in l_labels_texto)
                {
                    label.Font = new System.Drawing.Font(label.Font.Name, tamano);
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Cambiar_Tamano_Texto() = " + ex);
            }
        }

        public static void Cambiar_Idioma(Language_Type nuevo_idioma)
        {
            try
            {
                byte idioma = 0;
                switch(nuevo_idioma)
                {
                    case Language_Type.Espanol:
                        idioma = 0;
                        break;

                    case Language_Type.English:
                        idioma = 1;
                        break;

                    case Language_Type.한국어:
                        idioma = 2;
                        break;
                }
                for (int i = 0; i < l_labels_todas.Count; i++)
                {
                    l_labels_todas[i].Text = Textos_idiomas[i, idioma];
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Cambiar_Idioma() = " + ex);
            }
        }
        public static void Cambiar_Tema(bool estado)
        {
            try
            {
                switch(estado)
                {
                    case true:
                        {
                            Usar_temas = true;
                            foreach(Form form in l_)
                            break;
                        }
                    case false:
                        {
                            Usar_temas = false;
                            foreach (Form form in l_forms)
                            {
                                form.BackColor = Control.DefaultBackColor;
                            }
                            break;
                        }
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Cambiar_Tema() = " + ex);
            }
        }

        public static void Cambiar_Color(Color color)
        {
            try
            {
                foreach (Form form in l_forms)
                {
                    form.BackColor = color;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Cambiar_Color(Color) = " + ex);
            }
        }
        public static void Cambiar_Color(bool estado, Color color)
        {
            try
            {
                switch( estado)
                {
                    case true:
                        Cambiar_Color(color);
                        break;

                    case false:
                        foreach (Form form in l_forms)
                        {
                            form.BackColor = Form.DefaultBackColor;
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Clase: Opciones - Metodo: Cambiar_Color(bool, Color) = " + ex);
            }
        }
    }
}

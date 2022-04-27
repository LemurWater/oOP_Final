using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.IO;

using p_colegio.Enumeraciones;

namespace p_colegio.Sistema
{
    internal static class Idioma
    {
        private static string direccion = Directory.GetCurrentDirectory().ToString();



        private static string direccion_idioma = Directory.GetCurrentDirectory().ToString()
                                    + @"\Archivos\Registros\"
                                    + ""; //Idiomas.exe

        private static List<string> l_acceso;
        private static List<string> l_mostrar;
        private static List<string> l_Barra;
        private static List<string> l_opciones;
        private static List<string> l_temas;
        private static List<string> l_mensajes;


        public static bool Leer_Idiomas()
        {
            try
            {
                if(true)
                {
                    //Opcione.Idioma = 
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception("STATIC CLASS: Idioma - METODO: Leer_Idiomas " + ex);
            }
        }
        public static string Obtener_Texto(byte index, EIdioma idioma)
        {
            try
            {
                switch(idioma)
                {
                    case EIdioma.Espanol:
                        {
                            break;
                        }
                    case EIdioma.English:
                        {
                            break;
                        }
                    case EIdioma.한국어:
                        {
                            break;
                        }
                }
                return test[0];
            }
            catch (Exception ex)
            {
                throw new Exception("STATIC CLASS: Idioma - METODO: Obtener_Texto " + ex);
            }
        }
    }
}

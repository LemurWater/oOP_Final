using System;

using System.IO;

using b_registro.Clases_Internas;


namespace b_registro.Clases_Publicas
{

    internal static class Registrar_Accion
    {
        private static string direccion = Directory.GetParent(Directory.GetParent(Directory.GetCurrentDirectory().ToString()).ToString()).ToString()
            + @"\Registros\"
            + @"Registro.txt";

        private static string marca_de_la_empresa = "prueba®";




        public static bool Registrar(Tipo_Accion tipo_accion, string notas)
        {
            try
            {
                Accion accion = new Accion(tipo_accion);

                Registro registro = new Registro(
                    DateTime.Now,
                    accion,
                    notas);


                if (registro is Registro)
                {
                    return true;
                }
                else return false;
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Registrar_Accion - Metodo: Registrar - " + ex);
            }
        }

        public static bool Guardar_TXT(string info)
        {
            try
            {
                if (File.Exists(direccion))
                {

                    StreamReader sr;
                    sr = new StreamReader(direccion);
                    string tmp = sr.ReadLine();

                    if (tmp == marca_de_la_empresa)
                    {
                        File.AppendText(direccion);


                        using (StreamWriter sw = File.AppendText(direccion))
                        {
                            sw.WriteLine(info);
                        }
                        return true;
                    }
                    else
                    {
                        throw new Exception("Archivo desconocido, nombre de la empresa no es igual");
                    }
                }
                else
                {
                    using (StreamWriter sw = File.CreateText(direccion))
                    {
                        sw.WriteLine(marca_de_la_empresa);
                        sw.WriteLine(".");
                        sw.WriteLine(info);
                    }
                    return true;
                }
            }
            catch (Exception ex)
            {
                throw new Exception("Error Clase: Registrar_Accion - Metodo: Leer_TXT() - " + ex);
            }
        }
    }
}

using System;
using System.Linq;


namespace p_colegio.Clases.Herencia
{

    internal class Integrante
    {

        internal string nombre;
        internal short id;
        internal DateTime f_nacimineto;



        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("CLASE: Integrante - ACCESOR: Nombre");
                }
                else nombre = value;
            }
        }



        public short Id
        {
            get
            {
                return id;
            }
            set
            {
                if (value.ToString().Count() > 6)
                {
                    id = value;
                }
                else throw new Exception("CLASE: Integrante - ACCESOR: Id");
            }
        }
        public DateTime F_nacimiento
        {
            get
            {
                return f_nacimineto;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new Exception("CLASE: Integrante - ACCESOR: F_nacimiento");
                }
                else f_nacimineto = value;
            }
        }
    }
}

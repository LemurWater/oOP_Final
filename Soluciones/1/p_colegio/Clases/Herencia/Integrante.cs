using System;
using System.Linq;

using p_colegio.Interfaces;


namespace p_colegio.Clases.Herencia
{

    internal abstract class Integrante:  IIntegrante
    {

        protected string nombre;
        protected short id;
        protected DateTime f_nacimiento;


        /*
        public Integrante(string nombre, short id, DateTime f_nacimiento)
        {
            Nombre = nombre;
            Id = id;
            F_nacimiento = f_nacimiento;
        }*/



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
                return f_nacimiento;
            }
            set
            {
                if (value > DateTime.Now)
                {
                    throw new Exception("CLASE: Integrante - ACCESOR: F_nacimiento");
                }
                else f_nacimiento = value;
            }
        }



        public abstract void Evaluacion();
    }
}

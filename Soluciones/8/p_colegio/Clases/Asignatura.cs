using System;
using System.Collections.Generic;


using p_colegio.Clases.Herencia;


namespace p_colegio.Clases
{

    internal class Asignatura
    {

        private string nombre;
        private byte grado;
        private List<Docente> l_docentes;


        public Asignatura(string nombre, byte grado, List<Docente> l_docentes)
        {
            Nombre = nombre;
            Grado = grado;
            L_docentes = l_docentes;
        }



        public string Nombre
        {
            get
            {
                return nombre;
            }
                
            set
            {
                if(string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    nombre = value;
                }
                else throw new Exception("CLASE: Asignatura - ACCESOR: Nombre");
            }
        }
        public byte Grado
        {
            get
            {
                return grado;
            }
            set
            {
                if (value > 12 || value == 0)
                {
                    throw new Exception("CLASE: Asignatura - ACCESOR: Grado");
                }
                else grado = value;
            }
        }
        internal List<Docente> L_docentes
        {
            get
            {
                return l_docentes;
            }
            set
            {
                if(value.Count == 0)
                {
                    throw new Exception("CLASE: Asignatura - ACCESOR: L_docentes");
                }
                else l_docentes = value;
            }
        }
    }
}

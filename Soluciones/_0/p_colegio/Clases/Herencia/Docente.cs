using System;
using System.Collections.Generic;


namespace p_colegio.Clases.Herencia
{

    internal class Docente : Integrante
    {

        private List<string> l_titulos;
        private Asignatura area_clase;



        public Docente(List<string> l_titulos, Asignatura area_clase, 
            string nombre, short id, DateTime f_nacimiento)
        {
            L_titulos = l_titulos;
            Area_clase = area_clase;

            Nombre = nombre;
            Id = id;
            F_nacimiento = f_nacimiento;
        }



        public List<string> L_titulos
        {
            get
            {
                return l_titulos;
            } 
            set
            {
                if(value.Count == 0)
                {
                    throw new Exception("CLASE: Docente - ACCESOR: L_titulos");
                }
                else l_titulos = value;
            }
        }

        internal Asignatura Area_clase

        {
            get
            {
                return area_clase;
            }
                
            set
            {
                if(value is Asignatura)
                {
                    area_clase = value;
                }
                else throw new Exception("CLASE: Docente - ACCESOR: Area_clase");
            }
        }



        public void Reportar_Evaluacion()
        {
            //Falta
        }
    }
}

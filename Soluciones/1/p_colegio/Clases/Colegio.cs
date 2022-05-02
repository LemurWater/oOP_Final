using System;
using System.Collections.Generic;

using p_colegio.Interfaces;
using p_colegio.Clases.Herencia;



namespace p_colegio.Clases
{

    internal class Colegio
    {

        private HistoriaAcademica historia_academica;



        public Colegio(HistoriaAcademica historia_academica)
        {
            Historia_academica = historia_academica;
        }



        internal HistoriaAcademica Historia_academica
        {
            get
            {
                return historia_academica;
            }
            set
            {
                if (value != null)
                {
                    historia_academica = value;
                }
                else throw new Exception("CLASE: Colegio - ACCESOR: Historia_academica");
            }
        }



        public List<Evaluacion> Recorrer_Evaluaciones()
        {      
            try
            {
                //Falta
                List<Evaluacion> l_eva = new List<Evaluacion>();//Borrar
                return l_eva;//                                   Borrar
            }
            catch (Exception ex)
            {
                throw new Exception("CLASE: Colegio - METODO: Recorrer_Evaluaciones = " + ex);
            }
        }

        //Interface
        public bool Estudiante(Pregrado estudiante)
        {
            try
            {
                //Falta
                return true;
            }
            catch(Exception ex)
            {
                throw new Exception("CLASE: Colegio - METODO: Estudiante(Pregrado) = " + ex);
            }
        }
        public void Estudiante(Posgrado estudiante)
        {
            try
            {
                //Falta
            }
            catch (Exception ex)
            {
                throw new Exception("CLASE: Colegio - METODO: Estudiante(Posgrado) = " + ex);
            }
        }
    }
}

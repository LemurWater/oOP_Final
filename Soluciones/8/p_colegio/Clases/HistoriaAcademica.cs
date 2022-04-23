using System;
using System.Collections.Generic;



namespace p_colegio.Clases
{

    internal class HistoriaAcademica
    {

        private DateTime anio;
        private byte periodo;
        private List<Evaluacion> l_evaluaciones;



        public HistoriaAcademica(DateTime anio, byte periodo, List<Evaluacion> l_evaluaciones)
        {
            Anio = anio;
            Periodo = periodo;
            L_evaluaciones = l_evaluaciones;
        }



        public DateTime Anio
        {
            get
            {
                return anio;
            }
            set
            {
                if(value > DateTime.Now)
                {
                    anio = value;
                }
            }
        }
        public byte Periodo
        {
            get
            {
                return periodo;
            } 
            set
            {
                if(value > 4)
                {
                    throw new Exception("CLASE: HistoriaAcademica - ACCESOR: Periodo");
                }
                else periodo = value;
            }
        }
        internal List<Evaluacion> L_evaluaciones
        {
            get
            {
                return l_evaluaciones;
            } 
            set
            {
                if(value.Count == 0)
                {        
                    throw new Exception("CLASE: HistoriaAcademica - ACCESOR: L_evaluaciones");
                }
                else l_evaluaciones = value;
            }
        }
    }
}

using System;
using System.Collections.Generic;



namespace p_colegio.Clases
{

    internal class HistoriaAcademica
    {

        private DateTime anio;
        private byte periodo;
        private static List<Evaluacion> l_evaluaciones;



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
                else throw new Exception("CLASE: HistoriaAcademica - ACCESOR: Anio = ");
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
                    throw new Exception("CLASE: HistoriaAcademica - ACCESOR: Periodo = ");
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
                    throw new Exception("CLASE: HistoriaAcademica - ACCESOR: L_evaluaciones = ");
                }
                else l_evaluaciones = value;
            }
        }



        public static string Recorrer()
        {
            try
            {
                int eg = 0; int ep = 0;
                List<string> _l_aGanan = new List<string>();
                List<string> _l_aPierden = new List<string>();
                List<short> _l_cGanan = new List<short>(); 
                List<short> _l_cPierden = new List<short>();
                

                foreach (Evaluacion e in l_evaluaciones)
                {
                    if (e.Nota_final < 3.0f)
                    {
                        ep++;

                        if(_l_aGanan.Contains(e.Asignatura.Nombre))
                        {
                            for (int i = 0; i < _l_aGanan.Count; i++)
                            {
                                if (_l_aGanan[i] == e.Asignatura.Nombre)
                                {
                                    _l_cPierden[i]++;
                                }
                            }
                        }
                        else _l_aGanan.Add(e.Asignatura.Nombre);
                    }
                    else
                    {
                        eg++;

                        if (_l_aGanan.Contains(e.Asignatura.Nombre))
                        {
                            for (int i = 0; i < _l_aGanan.Count; i++)
                            {
                                if (_l_aGanan[i] == e.Asignatura.Nombre)
                                {
                                    _l_cGanan[i]++;
                                }
                            }
                        }
                    }
                }

                short _tmp_control = 0;
                short _tmp_index = 0;
                for (short i = 0; i < _l_cGanan.Count; i++)
                {
                    if(_l_cGanan[i] > _tmp_control)
                    {
                        _tmp_control = _l_cGanan[i];
                        _tmp_index = i;
                    }
                }

                short _tmp_control2 = 0;
                short _tmp_index2 = 0;
                for (short i = 0; i < _l_cPierden.Count; i++)
                {
                    if (_l_cPierden[i] > _tmp_control2)
                    {
                        _tmp_control2 = _l_cPierden[i];
                        _tmp_index2 = i;
                    }
                }

                return eg + " estudiantes han GANADO evaluaciones" + "\n" +
                       ep + " estudiantes han PERDIDO evaluaciones" + "\n" +
                       "\n" +
                       _l_aGanan[_tmp_index].ToUpper() + " es la asignatura mas GANADA, con: " + _l_cGanan[_tmp_index] + " estudiantes" + "\n" +
                       _l_aPierden[_tmp_index].ToUpper() + " es la asignatura mas PERDIDA, con: " + _l_cPierden[_tmp_index] + " estudiantes";
            }
            catch (Exception ex)
            {
                throw new Exception("CLASE: HistoriaAcademica - METODO: Recorrer = " + ex);
            }
        }


        public static string Consultar(short id_estudiante)
        {
            try
            {
                foreach(Evaluacion evaluacion in l_evaluaciones)
                {
                    if (evaluacion.Estudiante.Id == id_estudiante)
                    {

                        return "ESTUDIANTE: " + evaluacion.Estudiante.Nombre + 
                            " - ASIGNATURA: " + evaluacion.Asignatura +
                            " - NOTA: " + evaluacion.Nota_final;
                    }
                }
                return "EROR: No encontrado";
            }
            catch (Exception ex)
            {
                throw new Exception("CLASE: HistoriaAcademica - METODO: Consultar = " + ex);
            }
        }
        public void Agregar(Evaluacion evaluacion)
        {
            try
            {
                L_evaluaciones.Add(evaluacion);
            }
            catch(Exception ex)
            {
                throw new Exception("CLASE: HistoriaAcademica - METODO: Agregar = " + ex);
            }
        }
    }
}

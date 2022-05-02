using System;


using p_colegio.Clases.Herencia;


namespace p_colegio.Clases
{

    internal class Evaluacion
    {

        private Estudiante estudiante;
        private Asignatura asignatura;
        private float nota_final;


        public Evaluacion(Estudiante estudiante, Asignatura asignatura, float nota_final)
        {
            Estudiante = estudiante;
            Asignatura = asignatura;
            Nota_final = nota_final;
        }


        public float Nota_final
        {
            get
            {
                return nota_final;
            }
            set
            {
                if(nota_final > 5.0f || nota_final < 0f)
                {
                    throw new Exception("CLASE: Evaluacion - ACCESOR: Nota_final = ");
                }
                else nota_final = value;
            }
        }
        internal Estudiante Estudiante
        {
            get 
            {
                return estudiante;
            }

            set
            {
                if(value is Estudiante)
                {
                    estudiante = value;
                }
                else throw new Exception("CLASE: Evaluacion - ACCESOR: Estudiante = ");
            }
        }
        internal Asignatura Asignatura
        {
            get
            {
                return asignatura;
            }
            set
            {
                if (value is Asignatura)
                {
                    asignatura = value;
                }
                else throw new Exception("CLASE: Evaluacion - ACCESOR: Asignatura = ");
            }
        }
    }
}

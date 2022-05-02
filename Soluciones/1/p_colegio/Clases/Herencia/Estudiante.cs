using System;

using p_colegio.Interfaces;


namespace p_colegio.Clases.Herencia
{

    internal abstract class Estudiante : Integrante, IEstudiante
    {

        internal string n_acudiente;


        protected Estudiante(string n_acudiente,
            string nombre, short id, DateTime f_nacimiento)
            : base(nombre, id, f_nacimiento)
        {
            N_acudiente = n_acudiente;

            Nombre = nombre;
            Id = id;
            F_nacimiento = f_nacimiento;
        }



        public string N_acudiente
        {
            get
            {
                return n_acudiente;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("CLASE: Estudiante - ACCESOR: N_acudiente");
                }
                else n_acudiente = value;
            }
        }



        public override void Evaluacion()
        {
            try
            {
                HistoriaAcademica.Consultar(Id);
            }
            catch (Exception ex)
            {
                throw new Exception("CLASE: Estudiante - METODO: Evaluacion = " + ex);
            }
        }



        public abstract void Graduacion();
    }
}

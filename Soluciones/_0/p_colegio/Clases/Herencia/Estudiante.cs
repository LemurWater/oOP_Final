using System;


namespace p_colegio.Clases.Herencia
{

    internal class Estudiante : Integrante
    {

        internal string n_acudiente;



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



        public void Consultar_Evaluacion()
        {
            //Falta
        }
    }
}

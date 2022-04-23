using System;
using System.Collections.Generic;


namespace p_colegio.Clases.Herencia
{

    internal class Pregrado : Estudiante
    {

        private string[,] estudios_p = new string[5,3];
        private string[] informacion = new string[3];



        public Pregrado(string[,] estudios_p, string[] informacion,
            string n_acudiente,
            string nombre, short id, DateTime f_nacimiento)
        {
            Estudios_p = estudios_p;
            Informacion = informacion;

            N_acudiente = n_acudiente;

            Nombre = nombre;
            Id = id;
            F_nacimiento = f_nacimiento;
        }


        
        public string[,] Estudios_p
        {
            get
            {
                return estudios_p;
            }
            set
            {
                if(value.GetLength(0) == 5 && value.GetLength(1) == 3)
                {
                    estudios_p = value;
                }
                else throw new Exception("CLASE: Pregrado - ACCESOR: Estudios_p");
            }
        }
        public string[] Informacion
        {
            get
            {
                return informacion;
            }
            set
            {
                if(value.GetLength(0) == 3)
                {
                    informacion = value;
                }
                else throw new Exception("CLASE: Pregrado - ACCESOR: Informacion");
            }
        }


        public List<string> Practica()
        {
            //Falta
            List<string> test = new List<string>();
            return test;
        }
        public void Pasantia()
        {

        }
        public void Plan_Negocios()
        {

        }
    }
}

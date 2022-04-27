using System;


namespace p_colegio.Clases.Herencia
{

    internal class Posgrado : Estudiante
    {

        public Posgrado(string n_acudiente,
            string nombre, short id, DateTime f_nacimiento)
        {
            N_acudiente = n_acudiente;

            Nombre = nombre;
            Id = id;
            F_nacimiento = f_nacimiento;
        }



        public void Tesis()
        {
            //Falta
        }
    }
}

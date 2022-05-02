using System;



namespace p_colegio.Clases.Herencia
{

    internal class Posgrado : Estudiante
    {

        public Posgrado(string n_acudiente,
            string nombre, short id, DateTime f_nacimiento)
            : base(n_acudiente, nombre, id, f_nacimiento)
        {
            N_acudiente = n_acudiente;

            Nombre = nombre;
            Id = id;
            F_nacimiento = f_nacimiento;
        }



        public void Tesis()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception("CLASE: Posgrado - METODO: Tesis = " + ex);
            }
        }

        

        public override void Graduacion()
        {
            try
            {

            }
            catch (Exception ex)
            {
                throw new Exception("CLASE: Posgrado - METODO: Graduacion = " + ex);
            }
        }
    }
}

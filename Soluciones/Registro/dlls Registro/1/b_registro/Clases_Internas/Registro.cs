using System;
using System.Collections.Generic;
using System.Text;


namespace b_registro.Clases_Internas
{

    internal class Registro
    {

        private DateTime fecha;
        private Accion _accion;
        private string notas;


        public Registro(DateTime fecha, Accion accion, string notas)
        {
            Fecha = fecha;
            _Accion = accion;
            Notas = notas;
        }



        public DateTime Fecha
        {
            get
            {
                return fecha;
            }
            set
            {
                if (value > DateTime.Now.AddMinutes(10) ||
                    value < DateTime.Now.AddMinutes(-10))
                {
                    fecha = value;
                }
                else throw new Exception("Error Clase: Registro - al intentar cambiar variable fecha");
            }
        }
        internal Accion _Accion
        {
            get
            {
                return _accion;
            }

            set
            {
                if (value != null)
                {
                    _accion = value;
                }
                else
                {
                    if (value is Accion)
                    {

                    }
                    else throw new Exception("Error Clase: Registro - al intentar cambiar variable _accion");
                }
            }
        }
        public string Notas
        {
            get
            {
                return notas;
            }
            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new Exception("Error Clase: Registro - al intentar cambiar variable notas");
                }
                else notas = value;
            }
        }
    }
}

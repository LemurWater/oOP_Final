using System;


namespace b_registro.Clases_Internas
{
    internal class Accion
    {

        Tipo_Accion tipo;


        public Accion(Tipo_Accion tipo)
        {
            Tipo = tipo;
        }



        public Tipo_Accion Tipo
        {
            get
            {
                return tipo;
            }
            set
            {
                if (value == Tipo_Accion.Inicio_Sesion
                    || value == Tipo_Accion.Agregar_Usuario
                    || value == Tipo_Accion.Agregar_Usuario
                    || value == Tipo_Accion.Eliminar_Usuario
                    || value == Tipo_Accion.Salir)
                {
                    tipo = value;
                }
                else throw new Exception("Error Accion: al intentar cambiar variable Tipo");
            }
        }
    }
}

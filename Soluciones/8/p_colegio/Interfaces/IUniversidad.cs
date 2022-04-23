using p_colegio.Clases.Herencia;


namespace p_colegio.Interfaces
{

    internal interface IUniversidad
    {

        bool Estudiante(Pregrado estudiante);
        void Estudiante(Posgrado estudiante);
    }
}

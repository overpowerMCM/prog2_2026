using ProyectoUno.Dominio.Entidades;

namespace ProyectoUno.Dominio.Interfaces
{
    public interface IRepositorioCuenta
    {
        // Método para agregar una cuenta al repositorio
        void AgregarCuenta(Cuenta cuenta);

        // Método para obtener una cuenta por su ID
        Cuenta? ObtenerCuentaPorId(int id);

        // Método para actualizar una cuenta existente
        void ActualizarCuenta(Cuenta cuenta);

        // Método para eliminar una cuenta por su ID
        void EliminarCuenta(int id);
    }
}
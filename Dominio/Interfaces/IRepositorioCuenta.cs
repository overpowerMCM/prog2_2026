using ProyectoUno.Dominio.Entidades;

namespace ProyectoUno.Dominio.Interfaces
{
    //Definimos el CRUD del repositorio Cuentas
    public interface IRepositorioCuenta
    {
        // Método para agregar una cuenta al repositorio
        // Create
        void AgregarCuenta(Cuenta cuenta);

        // Método para obtener una cuenta por su ID
        // Read
        Cuenta? ObtenerCuentaPorId(int id);

        // Método para actualizar una cuenta existente
        //Update
        void ActualizarCuenta(Cuenta cuenta);

        // Método para eliminar una cuenta por su ID
        // Delete
        void EliminarCuenta(int id);
    }
}
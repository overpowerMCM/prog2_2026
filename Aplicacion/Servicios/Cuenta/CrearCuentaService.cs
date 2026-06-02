using ProyectoUno.Aplicacion.Dto;
using ProyectoUno.Dominio.Entidades;
using ProyectoUno.Dominio.Interfaces;

namespace ProyectoUno.Aplicacion.Servicios
{
    public class CrearCuentaService
    {
        IRepositorioCuenta _repositorioCuenta;
        public CrearCuentaService(IRepositorioCuenta repositorioCuenta)
        {
            _repositorioCuenta = repositorioCuenta;
        }

        public int Ejecutar(CrearCuentaInput input)
        {
            // Crear una nueva cuenta con un ID generado y saldo inicial de 0
            //int nuevoId = GenerarNuevoId();
            var nuevaCuenta = new Cuenta();

            nuevaCuenta.EstablecerNombre(input.Nombre);
            nuevaCuenta.EstablecerSaldoInicial(5000m);
            if (input.TransactionLimit.HasValue)
            {
                nuevaCuenta.EstablecerTransactionLimit(input.TransactionLimit.Value);
            }
            
             // Generar un nuevo ID para la cuenta (puedes implementar tu lógica de generación de ID aquí)
            
            // Agregar la nueva cuenta al repositorio
            _repositorioCuenta.AgregarCuenta(nuevaCuenta);

            // Retornar el ID de la nueva cuenta creada
            return nuevaCuenta.Id;
        }

    }

}
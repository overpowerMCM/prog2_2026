using ProyectoUno.Aplicacion.Dto;
using ProyectoUno.Dominio.Interfaces;

namespace ProyectoUno.Aplicacion.Servicios
{
    public class RetiraDineroCuentaService
    {
        IRepositorioCuenta _repositorioCuenta;
        public RetiraDineroCuentaService(IRepositorioCuenta repositorioCuenta)
        {
            _repositorioCuenta = repositorioCuenta;
        }

        public void Ejecutar(int id, PatchCuentaInput input)
        {
            var modelo = _repositorioCuenta.ObtenerCuentaPorId(id);
            if(modelo == null)
            {
                throw new Exception("No existe la cuenta.");
            }
            
            if( input.Saldo.HasValue)
            {
                decimal monto = input.Saldo.Value;

                if (modelo.TransactionLimit.HasValue && monto > modelo.TransactionLimit.Value)
                {
                    throw new InvalidOperationException("La cantidad excede el límite por transacción.");
                }

                modelo.Retirar(monto);
            }

            _repositorioCuenta.ActualizarCuenta(modelo);
        }
    }
}
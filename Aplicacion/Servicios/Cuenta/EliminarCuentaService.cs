using System.Security.Cryptography.X509Certificates;
using ProyectoUno.Dominio.Interfaces;

namespace ProyectoUno.Aplicacion.Servicios
{
    public class EliminarCuentaService
    {
        
        IRepositorioCuenta _repositorioCuenta;

        public EliminarCuentaService(IRepositorioCuenta repositorio)
        {
            _repositorioCuenta = repositorio;
        }

        public void Ejecutar(int id)
        {
            var modelo = _repositorioCuenta.ObtenerCuentaPorId(id);

            if(modelo == null)
            {
                throw new Exception("No existe la cuenta.");
            }

            if(modelo.Saldo == 0)
            {
                _repositorioCuenta.EliminarCuenta(id);
            }
            else
            {
                throw new Exception("La cuenta tiene dinero");
            }
        }
    }
}
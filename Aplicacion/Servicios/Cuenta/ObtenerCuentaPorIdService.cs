using ProyectoUno.Aplicacion.Dto;
using ProyectoUno.Dominio.Entidades;
using ProyectoUno.Dominio.Interfaces;

namespace ProyectoUno.Aplicacion.Servicios
{
    public class ObtenerCuentaPorIdService
    {
        IRepositorioCuenta _repositorio;

        public ObtenerCuentaPorIdService(IRepositorioCuenta repo)
        {
            _repositorio = repo;
        }

        public CuentaDto? Ejecutar(int id)
        {
            Cuenta? cuenta = _repositorio.ObtenerCuentaPorId(id);
            
            if( cuenta == null) 
                return null;

            return new CuentaDto()
            {
                Id = cuenta.Id,
                Nombre = cuenta.Nombre,
                Saldo = cuenta.Saldo
            };
        }
    }
}
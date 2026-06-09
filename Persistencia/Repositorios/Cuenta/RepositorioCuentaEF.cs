
using Microsoft.EntityFrameworkCore;
using ProyectoUno.Dominio.Entidades;
using ProyectoUno.Dominio.Interfaces;
using ProyectoUno.Persistencia;

namespace ProyectoUno.Persistencia.Repositorios
{
    // TODO: PAra que esta implementacion funcione, deberan 
    // mapear correctamente la entidad Cuenta a CuentaEF, y viceversa.
    // no olvidarse del dto input y output para el controlador.
    public class RepositorioCuentaEF : IRepositorioCuenta
    {
        private readonly Contexto _contexto;

        public RepositorioCuentaEF(Contexto contexto)
        {
            _contexto = contexto;
        }

        public void ActualizarCuenta(Cuenta cuenta)
        {

            _contexto.Cuentas.Update(cuenta);
            _contexto.SaveChanges();
        }

        public void AgregarCuenta(Cuenta cuenta)
        {
            _contexto.Cuentas.Add(cuenta);
            _contexto.SaveChanges();
        }

        public void EliminarCuenta(int id)
        {
            var cuenta = _contexto.Cuentas.Find(id);
            if (cuenta != null)
            {
                _contexto.Cuentas.Remove(cuenta);
                _contexto.SaveChanges();
            }
        }

        public Cuenta? ObtenerCuentaPorId(int id)
        {
            return _contexto.Cuentas.Find(id);
        }
    }
}
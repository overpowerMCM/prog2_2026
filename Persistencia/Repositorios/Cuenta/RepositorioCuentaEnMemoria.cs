using ProyectoUno.Dominio.Entidades;
using ProyectoUno.Dominio.Interfaces;

namespace ProyectoUno.Persistencia.Repositorios
{
    public class RepositorioCuentaEnMemoria : IRepositorioCuenta
    {
        private readonly List<Cuenta> _cuentas = new List<Cuenta>();

        public void ActualizarCuenta(Cuenta cuenta)
        {
            for( int i = 0; i < _cuentas.Count; i++)
            {
                if (_cuentas[i].Id == cuenta.Id)
                {
                    _cuentas[i] = cuenta; // Actualizar la cuenta en la lista
                    return; // Salir del método después de actualizar
                }
            }
        }

        public void AgregarCuenta(Cuenta cuenta)
        {
            _cuentas.Add(cuenta);
        }

        public void EliminarCuenta(int id)
        {
            int i = 0;
            while(i < _cuentas.Count)
            {
                if (_cuentas[i].Id == id)
                {
                    _cuentas.RemoveAt(i);
                    return;
                    //i = _cuentas.Count; // Salir del bucle después de eliminar la cuenta
                }

                i++;
            }
        }

        public Cuenta? ObtenerCuentaPorId(int id)
        {
            for( int i = 0; i < _cuentas.Count; i++)
            {
                if (_cuentas[i].Id == id)
                {
                    return _cuentas[i];
                }
            }

            return null;
        }

        // Otros métodos para manejar las cuentas en memoria (actualizar, eliminar, etc.)
    }
}
namespace ProyectoUno.Dominio.Entidades
{
    public class Cuenta
    {
        // Propiedades de la clase Cuenta
        public int Id { get; private set; }
        public string Nombre { get; private set; }
        public float Saldo { get; private set; }

        // Constructor de la clase Cuenta
        public Cuenta()
        {            
            
        }

        public Cuenta( string nombre, float saldo)
        {            
            Id = 0;
            EstablecerNombre(nombre);
            EstablecerSaldoInicial(saldo);  
        }

        public void EstablecerNombre(string nuevoNombre)
        {
            if (!string.IsNullOrWhiteSpace(nuevoNombre))
            {
                Nombre = nuevoNombre;
            }
            else
            {
                throw new ArgumentException("El nombre no puede estar vacío.");
            }
        }

        public void EstablecerSaldoInicial(float saldoInicial)
        {
            if (saldoInicial >= 0)
            {
                Saldo = saldoInicial;
            }
            else
            {
                throw new ArgumentException("El saldo inicial no puede ser negativo.");
            }
        }
        // Método para depositar dinero en la cuenta
        public void Depositar(float cantidad)
        {            
            if (cantidad > 0)
            {                
                Saldo += cantidad;
            }   
            else
            {
                throw new ArgumentException("La cantidad a depositar debe ser mayor que cero.");
            }
        }

        // Método para retirar dinero de la cuenta
        public void Retirar(float cantidad)
        {            
            if (cantidad > 0)
            {                
                if (Saldo >= cantidad)
                {                    
                    Saldo -= cantidad;  
                }
                else
                {
                    throw new InvalidOperationException("Saldo insuficiente para realizar el retiro.");
                }
            }
            else
            {
                throw new ArgumentException("La cantidad a retirar debe ser mayor que cero.");
            }
        }
    }
}
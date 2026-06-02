namespace ProyectoUno.Dominio.Entidades
{
    public class Cuenta
    {
        // Propiedades de la clase Cuenta
        public int Id { get; set; }
        public string Nombre { get; private set; }
        public decimal Saldo { get; private set; }
        public decimal? TransactionLimit { get; private set; }

        // Constructor de la clase Cuenta
        public Cuenta()
        {
        }

        public Cuenta(string nombre, decimal saldo, decimal? transactionLimit = null)
        {
            Id = 0;
            EstablecerNombre(nombre);
            EstablecerSaldoInicial(saldo);
            TransactionLimit = transactionLimit;
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

        public void EstablecerSaldoInicial(decimal saldoInicial)
        {
            if (saldoInicial >= 0)
            {
                Saldo = Math.Round(saldoInicial, 2);
            }
            else
            {
                throw new ArgumentException("El saldo inicial no puede ser negativo.");
            }
        }
        // Método para depositar dinero en la cuenta
        public void Depositar(decimal cantidad)
        {            
            if (cantidad > 0)
            {
                if (TransactionLimit.HasValue && cantidad > TransactionLimit.Value)
                {
                    throw new InvalidOperationException("La cantidad excede el límite por transacción.");
                }

                Saldo += Math.Round(cantidad, 2);
            }
            else
            {
                throw new ArgumentException("La cantidad a depositar debe ser mayor que cero.");
            }
        }

        // Método para retirar dinero de la cuenta
        public void Retirar(decimal cantidad)
        {            
            if (cantidad > 0)
            {
                if (TransactionLimit.HasValue && cantidad > TransactionLimit.Value)
                {
                    throw new InvalidOperationException("La cantidad excede el límite por transacción.");
                }

                if (Saldo >= cantidad)
                {
                    Saldo -= Math.Round(cantidad, 2);
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

        public void EstablecerTransactionLimit(decimal? limite)
        {
            if (limite.HasValue && limite.Value < 0)
            {
                throw new ArgumentException("El límite de transacción no puede ser negativo.");
            }

            TransactionLimit = limite;
        }
    }
}
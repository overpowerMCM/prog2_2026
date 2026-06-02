namespace ProyectoUno.Aplicacion.Dto
{
    public class CuentaDto
    {
        // Propiedades de la clase CuentaDto
        public int Id { get; set; }
        public string Nombre { get; set; }
        public decimal Saldo { get; set; }
        public decimal? TransactionLimit { get; set; }
    }
}
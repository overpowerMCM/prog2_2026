namespace ProyectoUno.Aplicacion.Dto
{
    public class PatchCuentaInput
    {
        public string? Nombre { get; set; }
        public decimal? TransactionLimit { get; set; }
        public decimal? Saldo { get; set; }
    }
}
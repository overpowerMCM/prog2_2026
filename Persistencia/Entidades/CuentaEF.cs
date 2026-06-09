using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProyectoUno.Persistencia.Entidades
{
    [Table("Cuentas")]
    public class CuentaEF
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(128)]
        public string Nombre { get; private set; }
        public decimal Saldo { get; private set; }
        public decimal? TransactionLimit { get; private set; }

    }
}
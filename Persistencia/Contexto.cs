using Microsoft.EntityFrameworkCore;
using ProyectoUno.Dominio.Entidades;

namespace ProyectoUno.Persistencia
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> options) : base(options) { }
        
        public DbSet<Cuenta> Cuentas { get; set; }



    }
}
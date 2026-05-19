using Microsoft.AspNetCore.Mvc;
using ProyectoUno.Aplicacion.Dto;
using ProyectoUno.Aplicacion.Servicios;
using ProyectoUno.Dominio.Entidades;
using ProyectoUno.Dominio.Interfaces;
using ProyectoUno.Persistencia.Repositorios;

namespace ProyectoUno.Presentacion.Controllers
{
    [ApiController] // Indica que es un controlador de API
    [Route("api/cuentas")] // Define la ruta (ej: api/productos)
    public class CuentaController : ControllerBase
    {

        [HttpGet]
        public IActionResult Dummy()
        {
            return Ok(new { mensaje = "Hola desde ASP.NET Core" });
        }

        [HttpGet("{id:int}")]
        public CuentaDto? ObtenerPorId(int id, ObtenerCuentaPorIdService service)
        {
            return service.Ejecutar(id);
        }

        [HttpPost]
        public int CrearCuenta([FromBody] CrearCuentaInput input, CrearCuentaService crearCuentaService)
        {
            // Aquí puedes llamar a tu servicio de aplicación para crear una cuenta
            // Por ejemplo: _crearCuentaService.Ejecutar(input);
            return crearCuentaService.Ejecutar(input);
            // Retornar una respuesta adecuada (ej: 201 Created con el ID de la nueva cuenta)
            //return CreatedAtAction(nameof(ObtenerCuenta), new { id = 0 }, null); // Reemplaza 0 con el ID real de la cuenta creada
        }

        [HttpDelete("{id:int}")]
        public void Delete(int id, EliminarCuentaService servicio)
        {
            servicio.Ejecutar(id);
        }

        [HttpPatch("{id:int}/extraer")]
        public void Patch(int id, PatchCuentaInput input, RetiraDineroCuentaService service)
        {
            service.Ejecutar(id, input);
        }
    }
}
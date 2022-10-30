using FacturacionBackend;
using FacturacionBackend.Datos;
using FacturacionBackend.Servicios;
using FacturacionBackend.Servicios.Interfaces;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace FacturacionAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FacturacionController : ControllerBase
    {
        private IServicio servicio;

        public FacturacionController()
        {
            servicio = new FactoryImplement().crearservicio();
        }



        // GET api/<FacturacionController>/5
        [HttpGet("/articulos")]
        public IActionResult GetArticulos()
        {
            return Ok(servicio.getarticulos());
        }
        [HttpGet("/todasfacturas")]
        public IActionResult GetTodasfacturas()
        {
            return Ok(servicio.todasfacturas());
        }
        [HttpGet("/usuariospass")]
        public IActionResult Getusuarios()
        {
            return Ok(servicio.usuarios());
        }
        // POST api/<FacturacionController>
        [HttpPost("/cargarfactura")]
        public IActionResult Post(Factura factura)
        {
            try
            {
                if (factura == null)
                    return BadRequest("factura incorrecta");
                return Ok(servicio.crearfactura(factura));
            }
            catch(Exception ex)
            {
                return StatusCode(500,"error interno nico");
            }
        }

        // PUT api/<FacturacionController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<FacturacionController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}

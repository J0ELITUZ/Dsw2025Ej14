using Dsw2025Ej14.Api.Data;
using Microsoft.AspNetCore.Mvc;
using Dsw2025Ej14.Api.Domain;
namespace Dsw2025Ej14.Api.Controller
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
        private readonly IPersistencia _persistencia;

        public ProductsController(IPersistencia persistencia)
        {
            _persistencia = persistencia;
        }

        [HttpGet("products")]
        public ActionResult<List<Product>> Get()
        {
            var productos = _persistencia.ObtenerProductos();
            return Ok(productos);
        }

       



    }
}
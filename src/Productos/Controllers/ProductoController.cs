using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using Models;

namespace Producto.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductoController : ControllerBase
    {

        private readonly AppDbContext _dbContext;

        public ProductoController(AppDbContext productos)
        {
            _dbContext = productos;
        }

        [HttpGet]
        public async Task<ActionResult<IEnumerable<Productos>>> Get()
        {
            return await _dbContext.Productos.ToListAsync();
        }

        [HttpPost]
        public async Task<ActionResult<IEnumerable<Productos>>> Post(Productos productos)
        {
            _dbContext.Productos.Add(productos);
            await _dbContext.SaveChangesAsync();

            return await _dbContext.Productos.ToListAsync();
        }
    }
}

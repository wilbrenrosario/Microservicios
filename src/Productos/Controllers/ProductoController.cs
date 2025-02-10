using MassTransit;
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
        private readonly IBus _bus;

        public ProductoController(AppDbContext productos, IBus bus)
        {
            _dbContext = productos;
            _bus = bus ?? throw new ArgumentNullException(nameof(bus));
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

            ProductoProducer productoProducer = new ProductoProducer(_bus);
            await productoProducer.EnviarMensajeAsync(new MensajeProducto(Guid.NewGuid(), productos.Name, productos.Price));

            return await _dbContext.Productos.ToListAsync();
        }
    }
}

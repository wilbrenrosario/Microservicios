using MassTransit;
using Models;

public class ProductoProducer
{
    private readonly IBus _bus;

    public ProductoProducer(IBus bus) => _bus = bus;

    public async Task EnviarMensajeAsync(MensajeProducto mensaje)
    {
        await _bus.Publish(mensaje);
    }
}

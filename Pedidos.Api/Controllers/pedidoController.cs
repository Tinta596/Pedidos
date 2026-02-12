using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.DTOs;
using Pedidos.Application.Ports;

namespace Pedidos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PedidoController : ControllerBase
{
    private readonly IPedidosService _service;

    public PedidoController(IPedidosService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _service.GetAll());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var pedido = await _service.GetById(id);
        if (pedido == null) return NotFound();
        return Ok(pedido);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreatePedidoRequest request)
    {
        var pedido = await _service.Create(request);
        return Ok(pedido);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdatePedidoRequest request)
    {
        var pedido = await _service.Update(id, request);
        if (pedido == null) return NotFound();
        return Ok(pedido);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _service.Delete(id);
        if (!deleted) return NotFound();
        return NoContent();
    }
}

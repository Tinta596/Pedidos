using Microsoft.AspNetCore.Mvc;
using Pedidos.Application.DTOs;
using Pedidos.Application.Ports;

namespace Pedidos.Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class PedidoItemController : ControllerBase
{
    private readonly IPedidosItemService _service;

    public PedidoItemController(IPedidosItemService service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<IActionResult> GetAll()
        => Ok(await _service.GetAll());

    [HttpGet("{id}")]
    public async Task<IActionResult> GetById(int id)
    {
        var pedidoItem = await _service.GetById(id);
        if (pedidoItem == null) return NotFound();
        return Ok(pedidoItem);
    }

    [HttpPost]
    public async Task<IActionResult> Create(CreatePedidoItemRequest request)
    {
        var pedidoItem = await _service.Create(request);
        return Ok(pedidoItem);
    }

    [HttpPut("{id}")]
    public async Task<IActionResult> Update(int id, UpdatePedidoItemRequest request)
    {
        var pedidoItem = await _service.Update(id, request);
        if (pedidoItem == null) return NotFound();
        return Ok(pedidoItem);
    }

    [HttpDelete("{id}")]
    public async Task<IActionResult> Delete(int id)
    {
        var deleted = await _service.Delete(id);
        if (!deleted) return NotFound();
        return NoContent();
    }
}

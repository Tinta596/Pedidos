using System;
using Pedidos.Application.Ports.In;
using Pedidos.Application.Ports.Out;
using Pedidos.Domain.Entities;
using Pedidos.Domain.Enums;

namespace Pedidos.Application.UseCases
{
    public class CrearPedido : ICrearPedidoUseCase
    {
        private readonly IPedidoRepository _pedidoRepository;
        private readonly IClienteRepository _clienteRepository;

        public CrearPedido(
            IPedidoRepository pedidoRepository,
            IClienteRepository clienteRepository)
        {
            _pedidoRepository = pedidoRepository;
            _clienteRepository = clienteRepository;
        }

        public Pedido Ejecutar(int clienteId, string nombre)
        {
            var cliente = _clienteRepository.ObtenerPorId(clienteId);

            if (cliente == null)
            {
                throw new Exception("Cliente no existe");
            }

            var pedido = new Pedido
            {
                ClienteId = cliente,
                Nombre = nombre,
                Estado = EstadoPedido.Pendiente
            };

            _pedidoRepository.Guardar(pedido);

            return pedido;
        }
    }   
}

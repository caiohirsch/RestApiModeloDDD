using RestApiModeloDDD.Domain.Entities;
using RestApiMoodeloDDD.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiMoodeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperCliente
    {
        Cliente MapperDtoToEntity(ClienteDto clienteDto);
        IEnumerable<ClienteDto> MapperListClientesDto(IEnumerable<Cliente> clientes);
        ClienteDto MapperEntityToDto(Cliente cliente);
    }
}

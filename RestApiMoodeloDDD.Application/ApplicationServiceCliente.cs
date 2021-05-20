using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiMoodeloDDD.Application.Dtos;
using RestApiMoodeloDDD.Application.Interfaces;
using RestApiMoodeloDDD.Application.Interfaces.Mappers;
using System.Collections.Generic;

namespace RestApiMoodeloDDD.Application
{
    public class ApplicationServiceCliente : IApplicationServiceCliente
    {
        private readonly IServiceCliente _serviceCliente;
        private readonly IMapperCliente _mapperCliente;

        public ApplicationServiceCliente(IServiceCliente serviceCliente, IMapperCliente mapperCliente)
        {
            _serviceCliente = serviceCliente;
            _mapperCliente = mapperCliente;
        }

        public void Add(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Add(cliente);
        }

        public IEnumerable<ClienteDto> GetAll()
        {
            var clientes = _serviceCliente.GetAll();
            return _mapperCliente.MapperListClientesDto(clientes);
        }

        public ClienteDto GetById(int id)
        {
            var cliente = _serviceCliente.GetById(id);
            return _mapperCliente.MapperEntityToDto(cliente);
        }

        public void Remove(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Remove(cliente);
        }

        public void Update(ClienteDto clienteDto)
        {
            var cliente = _mapperCliente.MapperDtoToEntity(clienteDto);
            _serviceCliente.Update(cliente);
        }
    }
}

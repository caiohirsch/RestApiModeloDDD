using RestApiModeloDDD.Domain.Core.Interfaces.Repositories;
using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiModeloDDD.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiModeloDDD.Domain.Services
{
    public class ServiceCliente : ServiceBase<Cliente>, IServiceCliente
    {
        private readonly IRepositoryCliente _repository;

        public ServiceCliente(IRepositoryCliente repository) : base(repository)
        {
            _repository = repository;
        }
    }
}

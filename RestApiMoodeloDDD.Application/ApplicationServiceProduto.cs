using RestApiModeloDDD.Domain.Core.Interfaces.Services;
using RestApiMoodeloDDD.Application.Dtos;
using RestApiMoodeloDDD.Application.Interfaces;
using RestApiMoodeloDDD.Application.Interfaces.Mappers;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiMoodeloDDD.Application
{
    public class ApplicationServiceProduto : IApplicationServiceProduto
    {
        private readonly IServiceProduto _serviceProduto;
        private readonly IMapperProduto _mapperProduto;

        public ApplicationServiceProduto(IServiceProduto serviceProduto, IMapperProduto mapperProduto)
        {
            _serviceProduto = serviceProduto;
            _mapperProduto = mapperProduto;
        }

        public void Add(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Add(produto);
        }

        public IEnumerable<ProdutoDto> GetAll()
        {
            var produto = _serviceProduto.GetAll();
            return _mapperProduto.MapperListProdutosDto(produto);
        }

        public ProdutoDto GetById(int id)
        {
            var produto = _serviceProduto.GetById(id);
            return _mapperProduto.MapperEntityToDto(produto);
        }

        public void Remove(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Remove(produto);
        }

        public void Update(ProdutoDto produtoDto)
        {
            var produto = _mapperProduto.MapperDtoToEntity(produtoDto);
            _serviceProduto.Update(produto);
        }
    }
}

using RestApiModeloDDD.Domain.Entities;
using RestApiMoodeloDDD.Application.Dtos;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestApiMoodeloDDD.Application.Interfaces.Mappers
{
    public interface IMapperProduto
    {
        Produto MapperDtoToEntity(ProdutoDto produtoDto);
        IEnumerable<ProdutoDto> MapperListProdutosDto(IEnumerable<Produto> produtos);
        ProdutoDto MapperEntityToDto(Produto produto);
    }
}

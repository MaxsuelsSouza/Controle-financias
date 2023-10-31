using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFinancia.Api.Domain.Repositorys.Interfaces
{
    public interface IRepository<T, I> where T : class
    {
        Task<IEnumerable<T?>> Obter();
        Task<T?> ObterPorId(I id);
        Task<T?> Adicionar(T entidade);
        Task<T?> Atualizar(T entidade);
        Task Deletar(T entidade);
    }
}
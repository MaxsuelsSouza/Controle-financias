using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControleFinancia.Api.Domain.Models;

namespace ControleFinancia.Api.Domain.Repositorys.Interfaces
{
    public interface IUsuarioRepository : IRepository<Usuario, long>
    {
        Task<Usuario?> ObterPorEmail(string email);
    }
}
using ControleFinancia.Api.Data;
using ControleFinancia.Api.Domain.Models;
using ControleFinancia.Api.Domain.Repositorys.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ControleFinancia.Api.Domain.Repositorys.Classes
{
    public class UsuarioRepositorio : IUsuarioRepository
    {
        private readonly AplicationContext _context;

        public UsuarioRepositorio(AplicationContext context)
        {
            _context = context;
        }

        public async Task<Usuario> Adicionar(Usuario entidade)
        {
            await _context.Usuario.AddAsync(entidade);
            await _context.SaveChangesAsync();
            return entidade;
        }

        public async Task<Usuario> Atualizar(Usuario entidade)
        {
            Usuario entidadeBanco = await _context.Usuario
                .Where(u => u.Id == entidade.Id)
                .FirstOrDefaultAsync();

            _context.Entry(entidadeBanco).CurrentValues.SetValues(entidade);
            _context.Update<Usuario>(entidadeBanco);
            return entidade;
        }

        public async Task Deletar(Usuario entidade)
        {
            _context.Entry(entidade).State = EntityState.Deleted;
            await _context.SaveChangesAsync();

        }

        public async Task<IEnumerable<Usuario>> Obter()
        {
            return await _context.Usuario.AsNoTracking()
            .OrderBy(u => u.Id)
            .ToListAsync();
        }

        public async Task<Usuario> ObterPorEmail(string email)
        {
            return await _context.Usuario.AsNoTracking()
            .Where(u => u.Email == email)
            .FirstOrDefaultAsync();
        }

        public async Task<Usuario> ObterPorId(long id)
        {
            return await _context.Usuario.AsNoTracking()
            .Where(u => u.Id == id)
            .FirstOrDefaultAsync();
        }
    }
}
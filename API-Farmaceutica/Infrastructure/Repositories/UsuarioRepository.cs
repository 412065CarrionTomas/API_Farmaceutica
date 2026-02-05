using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API_Farmaceutica.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsusarioRepository
    {
        private readonly FarmaceuticaContext _context;

        public UsuarioRepository(FarmaceuticaContext context)
        {
            _context = context;
        }

        public async Task<Usuarios> GetUsuarioByGuid(Guid userId)
        {
            Usuarios? usuario = await _context.Usuarios.FindAsync(userId);
            if (usuario == null)
                return null;
            return usuario;
        }

        public async Task<Usuarios?> LoginAsync(Usuarios usuario)
        {
            var user = await _context.Usuarios.FirstOrDefaultAsync(x => 
                x.Email.Equals(usuario.Email));

            if (user == null)
            {
                return null;
            }
            if (new PasswordHasher<Usuarios>().VerifyHashedPassword(user, user.Passwordhash, usuario.Passwordhash)
                == PasswordVerificationResult.Failed)
            {
                return null;
            }

            return user;
        }

        public async Task RegisterAsync(Usuarios usuario)
        {
            if (await _context.Usuarios.AnyAsync(x => x.Email.Equals(usuario.Email) || x.Id.Equals(usuario.Id)))
            {
                throw new ArgumentException("Usuario ya existente.");
            }

            Usuarios user = new Usuarios();
            string hashedPassword = new PasswordHasher<Usuarios>()
                .HashPassword(user, usuario.Passwordhash);

            user.Email = usuario.Email;
            user.Passwordhash = hashedPassword;
            user.Rol = usuario.Rol;

            await _context.Usuarios.AddAsync(user);
            await _context.SaveChangesAsync();
        }

        public async Task UpdateUsuario(Usuarios usuario)
        {
            Usuarios userTrack = await _context.Usuarios.FirstOrDefaultAsync(x =>
                                x.Id.Equals(usuario.Id)!);

            userTrack.Refreshtoken = usuario.Refreshtoken;
            userTrack.Refreshtokenexpirytime = usuario.Refreshtokenexpirytime;

            await _context.SaveChangesAsync();
        }
    }
}

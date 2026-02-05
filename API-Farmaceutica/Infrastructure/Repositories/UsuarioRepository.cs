using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using Domain.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;

namespace API_Farmaceutica.Infrastructure.Repositories
{
    public class UsuarioRepository : IUsusarioRepository
    {
        private readonly FarmaceuticaContext _Context;

        public UsuarioRepository(FarmaceuticaContext context)
        {
            _Context = context;
        }

        public async Task<Usuarios> GetUsuarioByGuid(Guid userId)
        {
            Usuarios? usuario = await _Context.Usuarios.FindAsync(userId);
            if (usuario == null)
                return null;
            return usuario;
        }

        public async Task<Usuarios?> LoginAsync(Usuarios usuario)
        {
            var user = await _Context.Usuarios.FirstOrDefaultAsync(x => 
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
            if (await _Context.Usuarios.AnyAsync(x => x.Email.Equals(usuario.Email) || x.Id.Equals(usuario.Id)))
            {
                throw new ArgumentException("Usuario ya existente.");
            }

            Usuarios user = new Usuarios();
            string hashedPassword = new PasswordHasher<Usuarios>()
                .HashPassword(user, usuario.Passwordhash);

            user.Email = usuario.Email;
            user.Passwordhash = hashedPassword;
            user.Rol = usuario.Rol;

            await _Context.Usuarios.AddAsync(user);
            await _Context.SaveChangesAsync();
        }

        public async Task UpdateUsuario(Usuarios usuario)
        {
            Usuarios userTrack = await _Context.Usuarios.FirstOrDefaultAsync(x =>
                                x.Id.Equals(usuario.Id)!);

            userTrack.Refreshtoken = usuario.Refreshtoken;
            userTrack.Refreshtokenexpirytime = usuario.Refreshtokenexpirytime;

            await _Context.SaveChangesAsync();
        }
    }
}

using API_Farmaceutica.Application.Features.JWTFeatures.Authenticate;
using API_Farmaceutica.Application.Shareds.InterfacesRepository;
using API_Farmaceutica.Application.Shareds.ROP;
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

        public async Task<Usuarios?> LoginAsync(Usuarios entity)
        {
            var usuario = await _Context.Usuarios.FirstOrDefaultAsync(x => 
                x.Email.Equals(entity.Email) && x.Id.Equals(entity.Id));

            if (usuario == null)
            {
                return null;
            }
            if (new PasswordHasher<Usuarios>().VerifyHashedPassword(usuario, usuario.Passwordhash, entity.Passwordhash)
                == PasswordVerificationResult.Failed)
            {
                return null;
            }

            return usuario;
        }

        public async Task RegisterAsync(Usuarios entity)
        {
            if (await _Context.Usuarios.AnyAsync(x => x.Email.Equals(entity.Email) || x.Id.Equals(entity.Id)))
            {
                throw new ArgumentException("Usuario ya existente.");
            }

            Usuarios usuario = new Usuarios();
            string hashedPassword = new PasswordHasher<Usuarios>()
                .HashPassword(usuario, entity.Passwordhash);

            usuario.Email = entity.Email;
            usuario.Passwordhash = hashedPassword;
            usuario.Rol = entity.Rol;

            await _Context.Usuarios.AddAsync(usuario);
            await _Context.SaveChangesAsync();
        }
    }
}

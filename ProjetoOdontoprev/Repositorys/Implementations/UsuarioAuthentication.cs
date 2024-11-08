using Microsoft.EntityFrameworkCore;
using ProjetoOdontoprev.Context;
using ProjetoOdontoprev.DTOs;
using ProjetoOdontoprev.Models;
using ProjetoOdontoprev.Repositorys.Interfaces;

namespace ProjetoOdontoprev.Repositorys.Implementations
{
    public class UsuarioAuthentication : IUsuarioAuthentication
    {
        private readonly DataContext _dataContext;

        public UsuarioAuthentication(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<UsuarioModel> CreateUser(UsuarioModelRegister request)
        {
            var getUser = await _dataContext.Usuarios.FirstOrDefaultAsync(x => x.Email == request.Email);
            if (getUser == null)
            {
                UsuarioModel newUser = new UsuarioModel
                {
                    Email = request.Email,
                    Password = BCrypt.Net.BCrypt.HashPassword(request.Password),
                    Name = request.Name,
                };
                _dataContext.Usuarios.Add(newUser);
                _dataContext.SaveChanges();

                return newUser;
            }
            return getUser;
        }

        public void DeleteUser(int id)
        {
            var user = _dataContext.Usuarios.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                user.isActive = false;
            }

        }

        public async Task<UsuarioModel> GetUserByEmail(UsuarioModelLogin request)
        {
            var getUser = await _dataContext.Usuarios.FirstOrDefaultAsync(x => x.Email == request.Email);
            if (getUser == null)
            {
                return null;
            }
            if (BCrypt.Net.BCrypt.Verify(request.Password, getUser.Password))
            {
                if (getUser.isActive)
                {
                    return getUser;
                }
                return null;
            }

            return null;

        }
    }
}



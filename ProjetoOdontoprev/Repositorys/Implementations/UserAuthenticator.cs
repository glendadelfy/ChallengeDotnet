using Microsoft.EntityFrameworkCore;
using ProjetoOdontoprev.Controllers;
using ProjetoOdontoprev.DTOs;
using ProjetoOdontoprev.Models;
using ProjetoOdontoprev.Repositorys.Interfaces;

namespace ProjetoOdontoprev.Repositorys.Implementations
{
    public class UserAuthenticator : IUserAuthenticator
    {
        private readonly DataContext _dataContext;
        public UserAuthenticator(DataContext dataContext)
        {
            _dataContext = dataContext;
        }
        public async Task<Dentista> CreateDentista(UserRegisterDto request)
        {
            var getUser = await _dataContext.Dentistas.FirstOrDefaultAsync(x => x.Email == request.Email);
            if (getUser == null)
            {
                Dentista newUser = new Dentista
                {
                    Email = request.Email,
                    Password = BCrypt.Net.BCrypt.HashPassword(request.Password),
                    Name = request.Name,
                };
                _dataContext.Dentistas.Add(newUser);
                _dataContext.SaveChanges();

                return newUser;
            }
            return getUser;
        }

        public void DeleteDentista(int id)
        {
            var user = _dataContext.Dentistas.FirstOrDefault(x => x.Id == id);
            if (user != null)
            {
                user.isActive = false;
            }
        }

        public async Task<Dentista> GetUserByEmail(UserLoginDto request)
        {
            var getUser = await _dataContext.Dentistas.FirstOrDefaultAsync(x => x.Email == request.Email);
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

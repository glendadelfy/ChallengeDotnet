using ProjetoOdontoprev.DTOs;
using ProjetoOdontoprev.Models;

namespace ProjetoOdontoprev.Repositorys.Interfaces
{
    public interface IUserAuthenticator
    {
        Task<Dentista> GetUserByEmail(UserLoginDto request);

        Task<Dentista> CreateDentista(UserRegisterDto request); 
        void DeleteDentista(int id);
    }
}

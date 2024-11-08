using ProjetoOdontoprev.DTOs;
using ProjetoOdontoprev.Models;


namespace ProjetoOdontoprev.Repositorys.Interfaces
{
    public interface IUsuarioAuthentication
    {
        Task<UsuarioModel> GetUserByEmail(UsuarioModelLogin request);
        Task<UsuarioModel> CreateUser(UsuarioModelRegister request); 
        void DeleteUser (int id);

    }
}

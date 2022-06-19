using MovieSearchAPI.DataModels;
using System.Threading.Tasks;

namespace MovieSearchAPI.Repository
{
    public interface IUserDataRepository
    {
        Task<UserData> CheckIfUserIsValid(string email, string password);
    }
}

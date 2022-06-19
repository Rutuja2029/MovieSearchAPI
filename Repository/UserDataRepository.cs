using Microsoft.EntityFrameworkCore;
using MovieSearchAPI.DataModels;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSearchAPI.Repository
{
    public class UserDataRepository : IUserDataRepository
    {
        private readonly MovieSearchContext context;

        public UserDataRepository(MovieSearchContext context)
        {
            this.context = context;
                                
        }

        public async Task<UserData> CheckIfUserIsValid(string email, string password)
        {
            return await context.UserData.Where(x => x.UserEmailId == email && x.UserPassword == password).SingleOrDefaultAsync();

        }

       
    }
}

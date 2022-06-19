using MovieSearchAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MovieSearchAPI.Repository
{
    public interface IWatchListRepository
    {
        int AddNewWatchList(WatchList watchlist);
        int DeleteWatchList(Guid id);

        Task<IEnumerable<WatchList>> GetAllWatchList();
        Task<WatchList> GetWatchListByListName(string listName);
    }
}

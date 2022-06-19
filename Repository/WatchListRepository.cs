using Microsoft.EntityFrameworkCore;
using MovieSearchAPI.DataModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MovieSearchAPI.Repository
{
    public class WatchListRepository : IWatchListRepository
    {
        private readonly MovieSearchContext context;

        public WatchListRepository(MovieSearchContext context)
        {
            this.context = context;
                
        }
        public int AddNewWatchList(WatchList watchlist)
        {
            context.WatchList.Add(watchlist);
            context.SaveChanges();  // It saves changes made
            return 1;
        }

        public int DeleteWatchList(Guid id )
        {
            var watchList = context.WatchList.Where(y => y.Id == id).SingleOrDefault();
            context.Remove(watchList);
            context.SaveChanges();
            return 1;
        }

        public async Task<IEnumerable<WatchList>> GetAllWatchList()
        {
            return await context.WatchList.ToListAsync();
        }

        public async Task<WatchList> GetWatchListByListName(string listName)
        {
            return await context.WatchList.Where(x => x.ListName == listName).SingleOrDefaultAsync();
        }
    }
}

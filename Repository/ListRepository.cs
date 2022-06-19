using MovieSearchAPI.DataModels;

namespace MovieSearchAPI.Repository
{
    public class ListRepository : IListRepository
    {
        private readonly MovieSearchContext context;

        public ListRepository(MovieSearchContext context)
        {
            this.context = context;    
        }
        public int AddNewList(List list)
        {
            context.List.Add(list);
            context.SaveChanges();  // It saves changes made
            return 1;
        }
    }
}

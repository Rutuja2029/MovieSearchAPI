using Microsoft.AspNetCore.Mvc;
using MovieSearchAPI.DataModels;
using MovieSearchAPI.Repository;
using System;
using System.Threading.Tasks;

namespace MovieSearchAPI.Controllers
{
    public class WatchListController : Controller
    {
        private readonly IWatchListRepository watchListRepository;

        public WatchListController(IWatchListRepository watchListRepository)
        {
            this.watchListRepository = watchListRepository;  
        }

        [HttpPost]
        [Route("[Controller]")]
        public IActionResult AddNewWatchList(WatchList watchList)
        {
            
            try  //Exception Handling
            {
                return new ObjectResult(watchListRepository.AddNewWatchList(watchList));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        
        [HttpDelete]
        [Route("[Controller]")]
        public IActionResult DeleteWatchList(Guid id)
        {

            try //Exception handling
            {
                return new ObjectResult(watchListRepository.DeleteWatchList(id));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        
        [HttpGet]
        [Route("[Controller]")]

        public async Task<IActionResult> GetAllWatchList()
        {
            try
            {
                return new ObjectResult(await watchListRepository.GetAllWatchList());
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        /*
        [HttpGet]
        [Route("[Controller]")]
        
        public async Task<IActionResult> GetWatchListByName(string listName)
        {
            try
            {
                return new ObjectResult(await watchListRepository.GetWatchListByListName(listName));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }
        */

    }
}

using Microsoft.AspNetCore.Mvc;
using MovieSearchAPI.DataModels;
using MovieSearchAPI.Repository;
using System;

namespace MovieSearchAPI.Controllers
{
    public class ListController : Controller
    {
        private readonly IListRepository listRepository;

        public ListController(IListRepository listRepository)
        {
            this.listRepository = listRepository;
        }
        [HttpPost]
        [Route("AddNewList")]
        public IActionResult AddNewList(List list)
        {
            try  //Exception Handling
            {
                return new ObjectResult(listRepository.AddNewList(list));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }

        }
    }
}

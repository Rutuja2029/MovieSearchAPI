using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MovieSearchAPI.DomainModels;
using MovieSearchAPI.Repository;
using System;
using System.Threading.Tasks;

namespace MovieSearchAPI.Controllers
{
    
    [ApiController]
    public class UserDataController : Controller
    {
        private readonly IUserDataRepository userDataRepository;



        public UserDataController(IUserDataRepository userDataRepository)
        {
            this.userDataRepository = userDataRepository;
        }

        [HttpGet]
        [Route("CheckIfUserIsValid/{email}/{password}")] // Route for checking admin is valid or not
        public async Task<IActionResult> CheckIfUserIsValid(string email, string password)
        {
            try //Exception handling
            {
                return new ObjectResult(await userDataRepository.CheckIfUserIsValid(email, password));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return null;
            }
        }

    }


}

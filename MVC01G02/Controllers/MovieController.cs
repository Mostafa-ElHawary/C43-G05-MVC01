using Microsoft.AspNetCore.Mvc;

namespace MVC01G02.Controllers
{
    public class MovieController : Controller
    {
        // Acction : public non-static Method

        public string GetMovie(int id)
        {

            return $"Get Movie With: {id}";
        }



    }
}

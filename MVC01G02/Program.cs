namespace MVC01G02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews(); // Register Built-in MVC services
            var app = builder.Build();

            app.MapGet("/", () => "Hellooooooo World!");
            //app.MapGet("/signin", () => "u r signin !");
            app.MapGet("/signin", User);

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Movie}/{action=Index}/{id?}"
            );

            app.MapControllerRoute(
                name: "Home",
                pattern: "{controller=Home}/{action=SignIn}/{username}"
            );

            // Map routes for additional action results
            app.MapControllerRoute(
                name: "GetMovieJson",
                pattern: "Movie/GetMovieJson/{id}",
                defaults: new { controller = "Movie", action = "GetMovieJson" }
            );

            app.MapControllerRoute(
                name: "RedirectToHome",
                pattern: "Movie/RedirectToHome",
                defaults: new { controller = "Movie", action = "RedirectToHome" }
            );

            app.MapControllerRoute(
                name: "GetContent",
                pattern: "Movie/GetContent",
                defaults: new { controller = "Movie", action = "GetContent" }
            );

            app.MapControllerRoute(
                name: "MovieNotFound",
                pattern: "Movie/MovieNotFound",
                defaults: new { controller = "Movie", action = "MovieNotFound" }
            );

            app.MapControllerRoute(
                name: "BadRequestExample",
                pattern: "Movie/BadRequestExample",
                defaults: new { controller = "Movie", action = "BadRequestExample" }
            );

            // Map routes for new action methods
            app.MapControllerRoute(
                name: "SubmitForm",
                pattern: "Movie/SubmitForm",
                defaults: new { controller = "Movie", action = "SubmitForm" }
            );

            app.MapControllerRoute(
                name: "Details",
                pattern: "Movie/Details/{id}",
                defaults: new { controller = "Movie", action = "Details" }
            );

            app.MapControllerRoute(
                name: "Search",
                pattern: "Movie/Search",
                defaults: new { controller = "Movie", action = "Search" }
            );

            app.MapControllerRoute(
                name: "UploadFile",
                pattern: "Movie/UploadFile",
                defaults: new { controller = "Movie", action = "UploadFile" }
            );

            app.Run();
        }

        public static string User(string username)
        {
            return $" Helloo {username}";
        }
    }
}

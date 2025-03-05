namespace MVC01G02
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
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


            app.Run();
        }
        
        public static string User(string username) {

            return $" Helloo {username}";

        }
    }
}

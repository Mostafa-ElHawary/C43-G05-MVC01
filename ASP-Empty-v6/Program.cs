namespace ASP_Empty_v6
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // Register Any Services

            
            builder.Services.AddControllersWithViews(); // Register Buit-in MVC services
            builder.Services.AddControllers(); // Register Buit-in Web APIs Services
            builder.Services.AddRazorPages(); // // Register Razor Pages  services
            var app = builder.Build();

            app.MapGet("/", () => "Hello World!");

            app.Run();
        }
    }
}

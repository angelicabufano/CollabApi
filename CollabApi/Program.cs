using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CollabApi.Data;
namespace CollabApi;

public class Program {
    public static void Main(string[] args) {
        var builder = WebApplication.CreateBuilder(args);
        builder.Services.AddDbContext<CollabApiContext>(options =>
            options.UseSqlServer(builder.Configuration.GetConnectionString("AppDbContext") ?? throw new InvalidOperationException("Connection string 'CollabApiContext' not found.")));

        // Add services to the container.

        builder.Services.AddControllers();

        var app = builder.Build();

        // Configure the HTTP request pipeline.

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}

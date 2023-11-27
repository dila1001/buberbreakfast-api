using BuberBreakfast.Api.Persistence;
using BuberBreakfast.Api.Services.Breakfasts;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);


{
    builder.Services.AddControllers();
    builder.Services.AddScoped<IBreakfastService, BreakfastService>();
    builder.Services.AddDbContext<BuberBreakfastDbContext>(options => 
        options.UseSqlite("Data Source=BuberBreakfast.db"));
}

var app = builder.Build();


{
    app.UseExceptionHandler("/error"); // catches uncaught errors
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

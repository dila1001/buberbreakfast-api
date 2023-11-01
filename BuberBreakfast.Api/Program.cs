using BuberBreakfast.Api.Services.Breakfasts;

var builder = WebApplication.CreateBuilder(args);


{
    builder.Services.AddControllers();
    builder.Services.AddScoped<IBreakfastService, BreakfastService>();
}

var app = builder.Build();


{
    app.UseExceptionHandler("/error"); // catches uncaught errors
    app.UseHttpsRedirection();
    app.MapControllers();
    app.Run();
}

using api.Data;
using Microsoft.EntityFrameworkCore;

var AllowedOrigin = "http://localhost:4200/";

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<ApiDbContext>(options =>
    options.UseSqlServer(connectionString)
);

builder.Services.AddCors(options =>
{
    options.AddPolicy(name: AllowedOrigin, policy =>
    {
        policy.WithOrigins("http://localhost:4200/");
    });
});

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors(AllowedOrigin);
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();

using TaskManager.ApiGateway.Models.Settings;
using Refit;
using TaskManager.ApiGateway.Interfaces;
using TaskManager.ApiGateway.Interfaces.Services;
using TaskManager.ApiGateway.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();

builder.Services.AddSwaggerGen();

builder.Services.AddScoped<IAuthService, AuthService>();

builder.Services.Configure<JwtSettings>(builder.Configuration.GetSection("JwtSettings"));
builder.Services.Configure<MicroservicesSettings>(builder.Configuration.GetSection("Microservices"));

var microservicesSettings = builder.Configuration.GetSection("Microservices").Get<MicroservicesSettings>();
builder.Services.AddRefitClient<IUserMicroservice>()
        .ConfigureHttpClient(c =>
        {
            c.BaseAddress = new Uri(microservicesSettings.User.Uri);
            c.DefaultRequestHeaders.Add("user-secret-key", microservicesSettings.User.SecretKey);
        });

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

using BlazorMediatorDemo.Shared;
using BlazorMediatorDemo.Shared.Services;
using MediatR;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<IPersonService, PersonService>();
builder.Services.AddSingleton<ITemperatureService, TemperatureService>();
builder.Services.AddSingleton<IWalletService, WalletService>();
builder.Services.AddMediatR(typeof(LibraryMediatREntryPoint).Assembly);

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

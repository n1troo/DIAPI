using DIAPI.Data;
using DIAPI.DataServices;
using DIAPI.Middleware;
using DIAPI.Unity;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IDataRepo, NoSqlDataRepo>();
builder.Services.AddScoped<IDataService, HttpDataService>();

builder.Services.AddTransient<IOperationTransient, Operation>();
builder.Services.AddScoped<IOperationScoped, Operation>();
builder.Services.AddSingleton<IOperationSingleton, Operation>();

var app = builder.Build();


if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseMiddleware<CustomMiddleware>();

app.UseHttpsRedirection();

app.MapGet("/getdata", (IOperationScoped scoped, IOperationTransient transient, IOperationSingleton singleton) =>
{
    Console.WriteLine($"Endpoint: " +
                      $"TransientId:{transient.OperationId} " +
                      $"ScopedId:{scoped.OperationId} " +
                      $"SingletonId:{singleton.OperationId}");
    return Results.Ok();
});

app.Run();
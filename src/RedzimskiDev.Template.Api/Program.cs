using RedzimskiDev.Template.Api;
using RedzimskiDev.Template.Application;
using RedzimskiDev.Template.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddApi()
    .AddApplication()
    .AddInfrastructure();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.Run();

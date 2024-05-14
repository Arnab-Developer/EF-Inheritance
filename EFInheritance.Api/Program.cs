using EFInheritance.Api;
using EFInheritance.Api.Endpoints;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddEFContexts(builder.Configuration);

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.RegisterDefaultEndpoints();
app.RegisterTptEndpoints();
app.RegisterTpcEndpoints();

app.Run();
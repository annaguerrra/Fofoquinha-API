using Microsoft.EntityFrameworkCore;
using FofoquinhaAPI.Models;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<FofoquinhaAPIDbContext>(opt =>
{
    var sqlConn = Environment.GetEnvironmentVariable("CONNECTION_STRING");
    opt.UseSqlServer(sqlConn);
});

var app = builder.Build();
app.Run();

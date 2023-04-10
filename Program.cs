using API.Data;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
builder.Services.AddDbContext<DataContext>(opt =>
{
    opt.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection"));
});
// 配置跨域资源共享
builder.Services.AddCors();

var app = builder.Build();

// Configure the HTTP request pipeline.
// UseCors启用Cors中间件，配置Cors允许客户端的任何请求头，任何请求方法以及来自4200域的请求
app.UseCors(builder => builder.AllowAnyHeader().AllowAnyMethod().WithOrigins("https://localhost:4200"));
app.MapControllers();

app.Run();

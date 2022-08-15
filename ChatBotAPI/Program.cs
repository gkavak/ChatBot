
using ChatBot.Common.DataAccess;
using ChatBot.DataLayer.Abstract;
using ChatBot.DataLayer.Concrete;
using ChatBot.Managers.Abstract;
using ChatBot.Managers.Concrete;
using ChatBot.Managers.Mapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Mongo db connection
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbSettings"));
builder.Services.Configure<MsSQLDbSettings>(builder.Configuration.GetSection("MS-SQLSettings"));
builder.Services.AddSingleton<DbContext, MsSQLDbContext>();//??
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddAutoMapper(typeof(MapperProfiles));
builder.Services.AddSingleton<IUserManager, UserManager>();
builder.Services.AddSingleton<IUserDAL, UserDAL>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();


app.Run();

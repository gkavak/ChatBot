
using Autofac;
using Autofac.Extensions.DependencyInjection;
using ChatBot.Common.DataAccess;
using ChatBot.DataLayer.Abstract;
using ChatBot.DataLayer.Concrete;
using ChatBot.Managers.Abstract;
using ChatBot.Managers.Concrete;
using ChatBot.Managers.DependencyResolvers.Autofac;
using ChatBot.Managers.Mapper;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// using autofac builder
builder.Host.UseServiceProviderFactory(new AutofacServiceProviderFactory());
builder.Host.ConfigureContainer<ContainerBuilder>(builder =>
{
    builder.RegisterModule(new AutofacBusinessModule());
});
    

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
//builder.Services.AddSingleton<IUserManager, UserManager>();
//builder.Services.AddSingleton<IUserDAL, UserDAL>();
////
//builder.Services.AddSingleton<IChatBotQuestionManager, ChatBotQuestionManager>();
//builder.Services.AddSingleton<IChatBotQuestionDAL, ChatBotQuestionDAL>();
//builder.Services.AddSingleton<IChatBotEntryManager, ChatBotEntryManager>();
//builder.Services.AddSingleton<IChatBotEntryDAL, ChatBotEntryDAL>();
//builder.Services.AddSingleton<IChatBotManager, ChatBotManager>();
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

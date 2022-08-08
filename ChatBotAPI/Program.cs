
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Mongo db connection
builder.Services.Configure<MongoDbSettings>(builder.Configuration.GetSection("MongoDbSettings"));

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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

//endpoints
/*
app.MapGet("/", () => "User API!");

app.MapGet("/api/get_all_users", );


app.MapGet("/api/find_user",);

app.MapPost("/api/add_user",);

app.MapPost("/api/delete_user",);

app.MapPost("/api/update_user",);
*/

app.Run();

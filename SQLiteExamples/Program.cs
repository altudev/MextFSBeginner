using SQLiteExamples.Data;
using SQLiteExamples.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// Singleton
// Scoped
// Transient
builder.Services.AddDbContext<ApplicationDbContext>();

builder.Services.AddSingleton<MyUrlService>(new MyUrlService("https://www.google.com"));
builder.Services.AddSingleton<RequestCounterService>(new RequestCounterService());

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
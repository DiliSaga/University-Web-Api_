using Microsoft.EntityFrameworkCore;
using UniTest.Interface;
using UniTest.Model;
using UniTest.Repository;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddScoped<ITestRepository, TestRepository>();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<UniversityContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("\"Data Source=SAGA\\\\SQLEXPRESS;Initial Catalog=university;Integrated " +
        "Security=True;Connect Timeout=30;Encrypt=False;Trust Server Certificate=False;Application Intent=ReadWrite;Multi Subnet Failover=False\""));
});

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

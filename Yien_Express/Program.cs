using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Yien_Express.Data;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connection = "Data Source=DESKTOP-H6ES71O;Initial Catalog=YienDB;TrustServerCertificate=True;Persist Security Info=True;Integrated Security=True";

builder.Services.AddDbContext<AppDBContext>(options => options.UseSqlServer(connection));
builder.Services.AddScoped<IPackageRepo, PackageRepo>();
builder.Services.AddScoped<ICustomerRepo, CustomerRepo>();
builder.Services.AddScoped<IEmployeeRepo, EmployeeRepo>();
builder.Services.AddScoped<IOrderRepo, OrderRepo>();

builder.Services.AddScoped<IUserRepo, UserRepo>();
builder.Services.AddAutoMapper(AppDomain.CurrentDomain.GetAssemblies());
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

app.Run();

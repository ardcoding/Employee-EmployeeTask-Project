using BusinessServicess.Layer.Concrete;
using BusinessServicess.Layer.Interface;
using DataAccess.Layer.Concrete;
using DataAccess.Layer.Interface;
using OfficeDb.Entities;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers().AddNewtonsoftJson(options =>
    options.SerializerSettings.ReferenceLoopHandling = Newtonsoft.Json.ReferenceLoopHandling.Ignore
);
builder.Services.AddDbContext<OfficeDbContext>();

builder.Services.AddScoped<IEmployeeTaskBusiness, EmployeeTaskBusiness>();
builder.Services.AddScoped<IEmployeeBusiness, EmployeeBusiness>();

builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IEmployeeTaskRepository, EmployeeTaskRepository>();
// Add services to the container.

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

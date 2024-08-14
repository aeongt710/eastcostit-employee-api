using DemoApi.Data;
using DemoApi.DataSeeding;
using DemoApi.IRepository;
using DemoApi.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

//Add CORS
builder.Services.AddCors();
builder.Services.AddControllers();
builder.Services.AddDbContext<DemoDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddCors(options =>
{
    options.AddPolicy("Development", b =>
    {
        b.AllowAnyHeader();
        b.AllowAnyMethod();
        b.AllowAnyOrigin();
    });
});


builder.Services.AddTransient<DatabaseConnection>();
builder.Services.AddScoped<IEmployeeRepository, EmployeeRepository>();
builder.Services.AddScoped<IGenderRepository, GenderRepository>();
builder.Services.AddScoped<IPrivateEmployeeRepository, PrivateEmployeeRepository>();

var app = builder.Build();

using (var scope = app.Services.CreateScope())
{
    var services = scope.ServiceProvider;
    var context = services.GetRequiredService<DemoDbContext>();
    context.Database.Migrate();
    var genderSeedManager = new SeedManager(context);
    genderSeedManager.Seed();
}



app.UseCors("Development");
// Configure the HTTP request pipeline.
//if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(builder => builder
 .AllowAnyOrigin()
 .AllowAnyMethod()
 .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

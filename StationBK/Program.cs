using AutoMapper;
using Microsoft.EntityFrameworkCore;
using Serilog;
using StationBK.Core.Interfaces.Company;
using StationBK.Core.Interfaces.Station;
using StationBK.Infrastructure.Data.Config;
using StationBK.Infrastructure.Data.Repository;
using StationBK.Infrastructure.Data.Repository.company;
using StationBK.Infrastructure.Data.Repository.Station;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddAutoMapper(typeof(MapperConfig));
builder.Services.AddDbContext<AppDbContext>(options =>
{
    var config = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
    var connString = config.GetSection("constr").Value;
    options.UseMySQL(connString);
});
builder.Services.AddScoped<IPurchaceRepository, PurchaceRepository>();
builder.Services.AddScoped<IPriceRepository, PriceRepository>();
builder.Services.AddScoped<IDepositRepository, DepositRepository>();
builder.Services.AddScoped<IBalanceRepository, BalanceRepository>();
builder.Services.AddScoped<IDailyShiftRepository,DailyShiftRepository>();
builder.Services.AddScoped<IExpenseRepository, ExpenseRepository>();
builder.Services.AddScoped<IFuelBalanceRepository, FuelBalanceRepository>();
builder.Services.AddScoped<IFuelRepository, FuelRepository>();
builder.Services.AddScoped<IOilRepository, OilRepository>();
builder.Services.AddScoped<IOilPriceRepository, OilPriceRepository>();
builder.Services.AddScoped<IMonthlyBalanceRepository, MonthlyBalanceRepository>();

builder.Host.UseSerilog((ctx, lc) => lc.WriteTo.Console().ReadFrom.Configuration(ctx.Configuration));
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddAWSLambdaHosting(LambdaEventSource.RestApi);

builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowOrigin",
        builder => builder.AllowAnyOrigin()
                          .AllowAnyHeader()
                          .AllowAnyMethod());
});
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowOrigin");
app.UseHttpsRedirection();

//app.UseAuthorization();

app.MapControllers();

app.Run();

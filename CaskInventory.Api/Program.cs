using CaskInventory.Application.cask.Create;
using CaskInventory.Common.Interfaces;
using CaskInventory.Common.Services;
using CaskInventory.Data.Entities;
using CaskInventory.Data.Interfaces;
using CaskInventory.Data.Repositories;
using Cqrs.Hosts;
using MediatR;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.DependencyInjection.Extensions;
using System.Configuration;

var builder = WebApplication.CreateBuilder(args);

var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");
builder.Services.AddDbContext<CaskdbContext>(options => options.UseMySQL(connectionString!));
builder.Services.TryAddScoped<CaskdbContext>();

// Add services to the container.
builder.Services.AddIdentityCore<ApplicationUser>(o =>
{
    o.Password.RequireDigit = true;
    o.Password.RequireLowercase = false;
    o.Password.RequireUppercase = false;
    o.Password.RequireNonAlphanumeric = false;
    o.Password.RequiredLength = 10;
    o.User.RequireUniqueEmail = true;
});

builder.Services.AddDefaultIdentity<ApplicationUser>()
.AddRoles<IdentityRole>()
.AddEntityFrameworkStores<CaskdbContext>()
.AddDefaultTokenProviders();

builder.Services.AddHealthChecks().AddDbContextCheck<CaskdbContext>();
builder.Services.AddAuthentication();



builder.Services.AddDbContext<CaskdbContext>();
builder.Services.AddMvc();
builder.Services.AddScoped<ICaskRepository, CaskRepository>();
builder.Services.AddScoped<IDistilleryRepository, DistilleryRepository>();
builder.Services.AddScoped<ICaskFillingRepository, CaskFillingRepository>();
builder.Services.AddScoped<IClientRepository, ClientRepository>();
builder.Services.AddScoped<IPurchaseRepository, PurchaseRepository>();
builder.Services.AddScoped<ISalespersonRepository, SalespersonRepository>();
builder.Services.AddScoped<ISupplierRepository, SupplierRepository>();
builder.Services.AddScoped<ITransferRepository, TransferRepository>();


var t = typeof(CreateCaskHandler).Assembly;
builder.Services.AddMediatR(t);


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

app.UseAuthentication();

app.MapControllers();
app.MapHealthChecks("/efcorehealth");

app.Run();

using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.OpenApi.Models;
using Swashbuckle.AspNetCore.Filters;
using X.Data.EF;
using X.Data.Entities;
using X.WebAPI.Services.Implements;
using X.WebAPI.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddIdentity<AppUser, AppRole>()
    .AddEntityFrameworkStores<XDbContext>()
    .AddSignInManager()
    .AddRoles<AppRole>();
// Add services to the container.
builder.Services.AddDbContext<XDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("XDatabase") ??
        throw new InvalidOperationException("Connection String is not found"));
});

builder.Services.AddSwaggerGen(options =>
{
    options.AddSecurityDefinition("oauth2", new OpenApiSecurityScheme
    {
        In = ParameterLocation.Header,
        Name = "Authorization",
        Type = SecuritySchemeType.ApiKey
    });

    options.OperationFilter<SecurityRequirementsOperationFilter>();
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddMemoryCache();
//builder.Services.AddTransient<IProductService, ProductService>();
builder.Services.AddTransient<RoleManager<AppRole>, RoleManager<AppRole>>();
builder.Services.AddTransient<IAuthService, AuthService>();
//builder.Services.AddTransient<IAuthenService, AuthenService>();

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
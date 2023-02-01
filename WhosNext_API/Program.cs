
#region Builder Services

using AutoMapper;
using Microsoft.EntityFrameworkCore;
using WhosNext_Domain.Account;
using WhosNext_Domain.Interfaces;
using WhosNext_Infra.Context;
using WhosNext_Infra.Repository;
using WhosNext_Services.MapperConfig;
using WhosNext_Services.Services.Account;
using WhosNext_Services.Services.Interfaces;

var builder = WebApplication.CreateBuilder(args);

ConfigurationManager configuration = builder.Configuration;

builder.Services.AddControllers();
builder.Services.AddHttpClient();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ApplicationDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("ApplicationDb"), opt =>
    {
        opt.CommandTimeout(60 * 60);
        opt.EnableRetryOnFailure(5);
    });
});

#endregion

#region Dependency Injection

#region Services DI
builder.Services.AddTransient<IAccountService, AccountService>();

#endregion

#region Repository DI
builder.Services.AddScoped<IBaseRepository<AccountDomain>, ApplicationBaseRepository<AccountDomain>>();
builder.Services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();
#endregion

#region Cache
builder.Services.AddMemoryCache();
#endregion

#region Mapper DI
builder.Services.AddSingleton(new MapperConfiguration(config =>
{
    config.AddProfile<ProfileMapperConfiguration>();
}).CreateMapper());
#endregion

#endregion

#region App Configuration

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();

#endregion
